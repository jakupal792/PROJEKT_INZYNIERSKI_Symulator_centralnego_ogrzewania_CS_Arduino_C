using System;
using System.Windows.Forms;
using System.Globalization;

namespace Projekt_inz_1
{
    public partial class Generator_sygnalow : Form
    {
        string temperatury; //format danych: "wysyłanie do aplikacji (0);czujnik 1; czujnik 2; czujnik kotła;"
        bool generatorOtwarty; //flaga używana do sygnalizowania oknu głównemu że generator jest otwarty
 
        public Generator_sygnalow(double t1, double t2, double tKotla)
        {
            InitializeComponent();
            generatorOtwarty = true;
            temperatury = "0; " + t1.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; " + t2.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; "
                   + tKotla.ToString(CultureInfo.InvariantCulture.NumberFormat) + ";";
            numT1.Value = (decimal)t1;
            numT2.Value = (decimal)t2;
            numTKotla.Value = (decimal)tKotla;
        }

        public string Temperatury
        {
            get { return temperatury; }
        }

        public bool GeneratorOtwarty
        {
            get { return generatorOtwarty; }
        }
 
        private void Generator_sygnalow_FormClosing(object sender, FormClosingEventArgs e)
        {
            generatorOtwarty = false;
        }

        private void numT1_ValueChanged(object sender, EventArgs e)
        {
            temperatury = "0; " + numT1.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; " + 
                numT2.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; "
              + numTKotla.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + ";";
        }

        private void numT2_ValueChanged(object sender, EventArgs e)
        {
            temperatury = "0; " + numT1.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; " + 
                numT2.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; "
              + numTKotla.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + ";";
        }

        private void numTKotla_ValueChanged(object sender, EventArgs e)
        {
            temperatury = "0; " + numT1.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; " + 
                numT2.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + "; "
              + numTKotla.Value.ToString(CultureInfo.InvariantCulture.NumberFormat) + ";";
        }
    }
}
