using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Projekt_inz_1
{
    public partial class Symulator : Form
    {
        // *** DEKLARACJA DANYCH ***
        enum Skala_temperatury
        {
            Celsjusz,
            Fahrenheit,
            Kelvin
        }

        int licznikPomiarow = 0;
        double t1, t2, tKotla, tSrednia, tOczek=10;
        bool podajnik, zwiekszanieTemperatury, stanAwaryjny, awariaInstalacji, tPokojuPrzekroczono,
            tKotlaPrzekroczono, rozpalony, generatorOtwarty;
        Skala_temperatury skala;
        string skalaSelected, zmienStanUkladu; //zmien_stan_ukladu - format danych: "wysyłanie do Arduino (1); podajnik; awaria czujnika lub instalacji; przekr. temp. pokoju; przekr. temp. kotła"
        const double maxTempPokoju = 30.0, maxTempKotla = 75.0, maxOdchylenieCzujnikow = 7.0,
            tRozpalenia = 15.0, cieploWlasciweWody = 4174.0, ilWodyWInstalacji = 370, sprawnoscKotla = 0.75, 
            kalorycznoscOpalu = 25000000.0, przelTWodyNaTPowietrza = 2.5; //przelTWodynNaTPowietrza - o ile Kelwinów trzeba zwiększyć temperaturę wody w instalacji żeby temperatura w pokoju zwiększyła się o 1 Kelwin 
        Generator_sygnalow generator; //okno generatora

        // *** PROCEDURA OKNA GŁÓWNEGO - odpowiednik SETUP() ***
        public Symulator()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; //ustawienia okna
            this.Bounds = Screen.PrimaryScreen.Bounds;

            cmb_skale_temperatur.Items.Add("°C"); //dodanie skal do comboBox'a w GUI
            cmb_skale_temperatur.Items.Add("°F");
            cmb_skale_temperatur.Items.Add("K");
            cmb_skale_temperatur.Text = "°C";

            num_t_oczek.Value = Convert.ToInt32(tOczek); //początkowa wartość pola numerycznego

            chart1.ChartAreas[0].AxisY.Minimum = 0; //konfiguracja wykresu
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = 1;

            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = "COM4"; //nazwa portu do którego Arduino jest podłączone
                serialPort1.BaudRate = 9600; //predkosc transmisji szeregowej 
                serialPort1.DtrEnable = true; //terminal danych gotowy do przesyłania danych
                serialPort1.Open(); //otwarcie portu
                serialPort1.DataReceived += SerialPort1OdbiorDanych; //wywołanie procedury umożliwiającej odbiór danych
            }
        }

        // *** KOMUNIKACJA PRZEZ PORT SZEREGOWY ***
        private void SerialPort1OdbiorDanych(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string daneOdebrane;

            if (generator != null) //pobieranie danych z portu szeregowego lub generatora wartości
            {
                generatorOtwarty = generator.GeneratorOtwarty;
            }

            if (!generatorOtwarty)
            {
                daneOdebrane = serialPort1.ReadLine();
            }
            else
            {
                daneOdebrane = generator.Temperatury;
            }

            if (daneOdebrane.StartsWith("0")) //obsługa tylko danych oznaczonych jako przychodzące (w celu odróżnienia od wychodzących)
            {
                Wyodrebnij_dane(daneOdebrane); //wywołanie procedury dekompozytującej dane
                Sterowanie(); //wywołanie funkcji sterującej pracą układu
                this.Invoke(new EventHandler(WyswietlDane)); //wywołanie procedury wyświetlającej pobrane dane
            }
            licznikPomiarow++; //licznik używany do odświeżania wykresu
        }

        private void SerialPort1WyslanieDanych(string zmienStan)
        {
            serialPort1.WriteLine(zmienStan);
        }

        // *** PROCEDURA STEROWANIA KOTŁEM  - odpowiednik LOOP() ***
        private void Sterowanie()
        {
            tSrednia = (t1 + t2) / 2;

            if ((!stanAwaryjny) && tKotla < tRozpalenia) //oznaczenie stanu układu jako "wygaszony"
            {
                rozpalony = false;
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Wygaszony";
                    label_stan.Refresh();
                }));
            }
            else if (!stanAwaryjny && !zwiekszanieTemperatury) //oznaczenie stanu układu jako "spalanie"
            {
                rozpalony = true;
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Spalanie";
                    label_stan.Refresh();
                }));
            }

            if (!stanAwaryjny && rozpalony && !zwiekszanieTemperatury && Math.Abs(tSrednia - tOczek) >= 1.0 &&
                tOczek > tSrednia) //podwyższenie temperatury, gdy jest za niska
            {
                zwiekszanieTemperatury = true;
                Thread t = new Thread(() => Ladowanie(tSrednia, tOczek)); //procedura startuje w osobnym wątku
                t.Start();
            }

            // *** WYKRYWANIE SYTUACJI AWARYJNYCH ***
            if (Math.Abs(t1 - t2) > maxOdchylenieCzujnikow || tKotla > tSrednia * 2.5 + 15) //zbytnie odchylenie wartości czujników świadczące o awarii instalacji (np. wycieku wody)
            {
                awariaInstalacji = true;
                lstAwarie.Invoke(new Action(delegate ()
                {
                    if (!lstAwarie.Items.Contains("AWARIA INSTALACJI!!!"))
                    {
                        lstAwarie.Items.Add("AWARIA INSTALACJI!!!");
                    }
                }));
                stanAwaryjny = true;
            }

            if (t1 > maxTempPokoju || t2 > maxTempPokoju) //przekroczenie dopuszczalnej temperatury w pokojach
            {
                tPokojuPrzekroczono = true;
                lstAwarie.Invoke(new Action(delegate ()
                {
                    if (!lstAwarie.Items.Contains("PRZEKROCZONO DOPUSZCZLNĄ TEMPERATURĘ W POKOJU!!!"))
                    {
                        lstAwarie.Items.Add("PRZEKROCZONO DOPUSZCZLNĄ TEMPERATURĘ W POKOJU!!!");
                    }
                }));
                stanAwaryjny = true;
            }

            if (tKotla > maxTempKotla) //przekroczenie dopuszczalnej temperatury kotła
            {
                tKotlaPrzekroczono = true;
                lstAwarie.Invoke(new Action(delegate ()
                {
                    if (!lstAwarie.Items.Contains("PRZEKROCZONO DOPUSZCZLNĄ TEMPERATURĘ W KOTLE!!!"))
                    {
                        lstAwarie.Items.Add("PRZEKROCZONO DOPUSZCZLNĄ TEMPERATURĘ W KOTLE!!!");
                    }
                }));
                stanAwaryjny = true;
            }

            if (stanAwaryjny) //oznaczenie stanu awaryjnego
            {
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Awaria";
                    label_stan.Refresh();
                }));
            }

            zmienStanUkladu = "1; " + Convert.ToInt32(podajnik) + "; " + Convert.ToInt32(awariaInstalacji) + "; "
                + Convert.ToInt32(tPokojuPrzekroczono) + "; " + Convert.ToInt32(tKotlaPrzekroczono) + ";"; //tworzenie łańcucha z danymi do wysłania
            SerialPort1WyslanieDanych(zmienStanUkladu); //wysłanie przez port szeregowy danych z żadaniem zmianu stanu układu

            lstAwarie.Invoke(new Action(delegate () //dodanie danych do wykresu
            {
                chart1.Series["Temperatura kotła"].Points.AddXY(licznikPomiarow, tKotla);
                chart1.Series["Temperatura 1"].Points.AddXY(licznikPomiarow, t1);
                chart1.Series["Temperatura 2"].Points.AddXY(licznikPomiarow, t2);
            }));
        }

        // *** PROCERUDY OBSŁUGUJĄCE CYKL PRACY, WSPÓŁPRACUJĄCE Z PROCEDURĄ STEROWANIE() ***
        private void Ladowanie(double tSrednia, double tOczek) //procedura obsługująca fazę ładowania opału
        {
            if (!stanAwaryjny)
            {
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Ładowanie";
                    label_stan.Refresh();
                }));
            }

            double masaOpalu = MasaOpalu(tSrednia, tOczek);
            double czasOczek = CzasRozpaleniaOpalu(tOczek, tKotla, masaOpalu);

            if (czasOczek > 60000) //jeśli czas oczekiwania jest większy niż 70 sekund, przyjmuje się że zasypanie kotła taką ilością opału spowoduje jego wygaszenie
            {
                int i = 1;
                while (czasOczek > 60000) //wtedy szuka się maksymalnej masy opału którą można dodać, by nie wygasić kotła, zmniejszając temperaturę oczekiwaną co krok o 1 Kelvin
                {
                    masaOpalu = MasaOpalu(tSrednia, tOczek - i);
                    czasOczek = CzasRozpaleniaOpalu(tOczek-i, tKotla, masaOpalu);
                    i++;
                }
            }

            int czasLadowania = Convert.ToInt32(CzasLadowania(masaOpalu));
            txtOpal.Invoke(new Action(delegate ()
            {
                txtOpal.Text = masaOpalu.ToString();
                txtOpal.Text = Math.Round(masaOpalu, 2).ToString();
            }));

            podajnik = true; //rozpoczęcie ładowania opału przez podajnik do pieca
            Thread.Sleep(czasLadowania); //oczekiwanie na zakończenie ładowania opału
            podajnik = false;
            Oczekiwanie(tOczek, tKotla, masaOpalu, czasOczek); //rozpoczęcie fazy oczekiwania na dojście do stanu ustalonego
        }

        private void Oczekiwanie(double tOczek, double tKotla, double masaOpalu, double czasOczek) //procedura obsługująca fazę oczekiwania na dojście do stanu ustalonego
        {
            if (!stanAwaryjny)
            {
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Oczekiwanie";
                    label_stan.Refresh();
                }));
            }

            txtCzasStanUstalony.Invoke(new Action(delegate ()
            {
                txtCzasStanUstalony.Text = Math.Round(czasOczek / 1000, 2).ToString(); //czas wyświetlany jest w minutach, co odpowiadałoby rzeczywistemu obiektowi, jednak w symulatorze wynosi liczbowo odpowiadającą ilość sekund
            }));

            Thread.Sleep(CzasRozpaleniaOpalu(tOczek, tKotla, masaOpalu)); //oczekiwanie aż całe dodane paliwo się zapali i temperatura osiągnie maksymalną wartość
            zwiekszanieTemperatury = false; //powrót do stanu "spalanie"
            if (!stanAwaryjny)
            {
                label_stan.Invoke(new Action(delegate ()
                {
                    label_stan.Text = "Spalanie";
                    label_stan.Refresh();
                }));
            }

            txtCzasStanUstalony.Invoke(new Action(delegate () //wyczyszczenie informacji dot. zwiększania temperatury
            {
                txtCzasStanUstalony.Text = "";
            }));

            txtOpal.Invoke(new Action(delegate ()
            {
                txtOpal.Text = "";
            }));
        }

        // *** PROCEDURY WYWOŁYWANE Z POZIOMU GUI ***

        private void btnZmienSkaleT_Click(object sender, EventArgs e) //zmiana skali temperatury
        {
            skalaSelected = cmb_skale_temperatur.Text;
            if (skalaSelected == "°C")
            {
                skala = Skala_temperatury.Celsjusz;
            }
            else if (skalaSelected == "°F")
            {
                skala = Skala_temperatury.Fahrenheit;
            }
            else if (skalaSelected == "K")
            {
                skala = Skala_temperatury.Kelvin;
            }
            else
            {
                cmb_skale_temperatur.Text = skala.ToString();
            }
        }

        private void btnUsunietoAwarie_Click(object sender, EventArgs e) //przycisk którym użytkownik zgłasza naprawę awarii (wszystkich które zaistniały)
        {
            stanAwaryjny = false;
            awariaInstalacji = false;
            tPokojuPrzekroczono = false;
            tKotlaPrzekroczono = false;
            lstAwarie.Items.Clear();
        }

        private void track_t_oczek_Scroll(object sender, EventArgs e) //zmiana wartości temperatury oczekiwanej na suwaku
        {
            tOczek = track_t_oczek.Value;
            num_t_oczek.Value = Convert.ToInt32(tOczek);
        }

        private void num_t_oczek_ValueChanged(object sender, EventArgs e) //zmiana wartości temperatury oczekiwanej na numBox'ie
        {
            tOczek = Convert.ToDouble(num_t_oczek.Value);
            track_t_oczek.Value = Convert.ToInt32(tOczek);
        }

        private void btnGenerator_Click(object sender, EventArgs e) //otwarcie okna generatora wartości temperatur
        {
            if (generator==null || !generator.GeneratorOtwarty)
            {
                generator = new Projekt_inz_1.Generator_sygnalow(t2, t2, tKotla);
                generator.Show();
            }
        }

        private void Symulator_FormClosing(object sender, FormClosingEventArgs e) //procedura końcowa
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close(); //zamknięcie portu szeregowego
            }
        }

        // *** INNE PROCEDURY ***
        private void Wyodrebnij_dane(string dane) //wyodrebnienie informacji przesłanych przez port szeregowy
        {
            try
            {
                string[] dane_podzielone = dane.Split(';'); //dekompozycja danych - podział na podciągi oddzielone średnikiem
                t1 = Convert.ToDouble(dane_podzielone[1], CultureInfo.InvariantCulture.NumberFormat); //wskazanie by kompilator uznawał kropkę jako znak oddzielający część całkowitą od ułamkowej
                t2 = Convert.ToDouble(dane_podzielone[2], CultureInfo.InvariantCulture.NumberFormat);
                tKotla = Convert.ToDouble(dane_podzielone[3], CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception e) { }
        }

        private void WyswietlDane(object sender, EventArgs e) //wyświetlanie danych wyjściowych w GUI
        {
            if (skala == Skala_temperatury.Celsjusz) //wyświetlanie temperatury w wybranej skali
            {
                txt_t1.Text = t1.ToString();
                txt_t2.Text = t2.ToString();
                txt_t_kotla.Text = tKotla.ToString();
            }
            else if (skala == Skala_temperatury.Fahrenheit)
            {
                txt_t1.Text = CelsToFahr(t1).ToString();
                txt_t2.Text = CelsToFahr(t2).ToString();
                txt_t_kotla.Text = CelsToFahr(tKotla).ToString();
            }
            else if (skala == Skala_temperatury.Kelvin)
            {
                txt_t1.Text = CelstToKelvin(t1).ToString();
                txt_t2.Text = CelstToKelvin(t2).ToString();
                txt_t_kotla.Text = CelstToKelvin(tKotla).ToString();
            }
        }

        private double CelsToFahr(double val) //konwersja temperatury do skali Fahrenheita
        {
            return val * 9 / 5 + 32;
        }

        private double CelstToKelvin(double val) //konwersja temperatury do skali Kelvina
        {
            return val + 273.15;
        }

        private double MasaOpalu(double tSrednia, double tOczek) //wyznaczenie masy opału potrzebnej do zwiększenia temperatury o zadaną wartość
        {
            double parametryFizTech = ilWodyWInstalacji * cieploWlasciweWody * przelTWodyNaTPowietrza / (sprawnoscKotla * kalorycznoscOpalu);
            double masaOpalu = 0;
            for (double i = tSrednia; i < tOczek; i += 0.1) //obliczenie masy opału w oparciu o przyjętą charakterystę
            {
                masaOpalu += (2 / ((i + 4) / (11.0 - tSrednia / 10.0)) + 1) * parametryFizTech / 10;
            }
            return masaOpalu;
        }

        private int CzasLadowania(double masaOpalu) //wyznaczenie czasu pracy podajnika koniecznego do podania do kotła zadanej masy opału
        {
            return Convert.ToInt32(masaOpalu * 6 * 1000); //1 kg wegla ładuje sie 6 sekund
        }

        private int CzasRozpaleniaOpalu(double tOczek, double tKotla, double masaOpalu) //wyznaczanie czasu oczekiwania na osiągięcie maksymalnej temperatury po dodaniu opału
        {
            return Convert.ToInt32(40.3 * Math.Exp(0.352 * masaOpalu) * Math.Exp(-0.02 * tKotla) * 1000);
        }
    }
}

