// *** DEFINICJA WEJŚĆ I WYJŚĆ *** 
#define CZUJNIK1 A1
#define CZUJNIK2 A2
#define CZUJNIK_KOTLA A3 
#define PODAJNIK 2
#define T_KOTLA_PRZEKROCZONO 3
#define T_POKOJU_PRZEKROCZONO 4
#define AWARIA_INSTALACJI 5

// *** DEKLARACJA ZMIENNYCH I STAŁYCH***
double t_kotla, t_1, t_2; 
String stan_ukladu_send, stan_ukladu_received;
bool podajnik, awaria_instalacji, t_pokoju_przekroczono, t_kotla_przekroczono;
const int odstep_czasu=100; //odstęp czasu pomiędzy cyklami programu [ms]

// *** PROCEDURA SETUP ***
void setup() {
  Serial.begin(9600); // inicjalizacja połączenia szeregowego
  pinMode(PODAJNIK, OUTPUT); 
  pinMode(AWARIA_INSTALACJI, OUTPUT);
  pinMode(T_POKOJU_PRZEKROCZONO, OUTPUT);
  pinMode(T_KOTLA_PRZEKROCZONO, OUTPUT);
}

// *** PROCEDURA LOOP ***
void loop() {
  t_kotla = skalowanie_t_kotla(analogRead(CZUJNIK_KOTLA)); //pobranie wartości z czujników
  t_1 = skalowanie_t_czujnika(analogRead(CZUJNIK1));
  t_2 = skalowanie_t_czujnika(analogRead(CZUJNIK2));

  stan_ukladu_send = "0; " + (String)t_1 + "; " + (String)t_2 + "; " + (String)t_kotla + ";"; //format danych: "wysyłanie do aplikacji (0);czujnik 1; czujnik 2; czujnik kotła;"
  Serial.println(stan_ukladu_send); //wysłanie danych przez portu szeregowy
  
  stan_ukladu_received=Serial.readString(); //odebranie danych z portu szeregowego
  if (stan_ukladu_received.startsWith("1")) 
  {
  char stan_rec_decomposed[14]; //dekompozycja danych pobranych z aplikacji
  strcpy(stan_rec_decomposed, stan_ukladu_received.c_str());  
  podajnik = (stan_rec_decomposed[3]=='1') ? true : false; 
  awaria_instalacji = (stan_rec_decomposed[6]=='1') ? true : false; 
  t_pokoju_przekroczono = (stan_rec_decomposed[9]=='1') ? true : false; 
  t_kotla_przekroczono = (stan_rec_decomposed[12]=='1') ? true : false;   
  }

  // *** STEROWANIE WYJŚCIAMI ***
  if(podajnik && !awaria_instalacji && !t_pokoju_przekroczono && !t_kotla_przekroczono)
  {
    digitalWrite(PODAJNIK, HIGH);    
  } else digitalWrite(PODAJNIK, LOW); 

  if (awaria_instalacji)
  {
    digitalWrite(PODAJNIK, LOW);
    digitalWrite(AWARIA_INSTALACJI, HIGH);
  } else digitalWrite(AWARIA_INSTALACJI, LOW);

  if (t_pokoju_przekroczono)
  {
    digitalWrite(PODAJNIK, LOW);
    digitalWrite(T_POKOJU_PRZEKROCZONO, HIGH);
  } else digitalWrite(T_POKOJU_PRZEKROCZONO, LOW);
  
  if (t_kotla_przekroczono)
  {
    digitalWrite(PODAJNIK, LOW);
    digitalWrite(T_KOTLA_PRZEKROCZONO, HIGH);
  } else digitalWrite(T_KOTLA_PRZEKROCZONO, LOW);
  
  delay(odstep_czasu);
}

// *** PROCEDURY SKALUJĄCE SYGNAŁ Z POTENCJOMETRU NA SYMULOWANĄ WARTOŚĆ TEMPERATURY ***
double skalowanie_t_czujnika(double value) //temperatura 0 - 40 stopni Celsjusza
{
    return round((value/25)*10)/10.0;    
}

double skalowanie_t_kotla(double value) //temperatura 0 - 100 stopni Celsjusza
{
    return value/10;
}
