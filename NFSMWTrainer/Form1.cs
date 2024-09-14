using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NFSMWTrainer
{
    public partial class TrainerForm : Form
    {
     
        Mem svchost = new Mem();
        public TrainerForm()
        {
            InitializeComponent();
        }

        #region Etc
        private void Form1_Load(object sender, EventArgs e)
        {
            svchost.OpenProcess("NFS13");         
        }

        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void ControlTimer_Tick(object sender, EventArgs e)
        {

            #region TopMost
            if (TopMostCheckBox.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            #endregion
           
            #region Color
            if (RainbowCheckBox.Checked == true) { Rainbow.Start(); } else { Rainbow.Stop(); }
            if (Rainbow2CheckBox.Checked == true) { Rainbow2.Start(); } else { Rainbow2.Stop(); }
            if (ColorCheckBox.Checked == true)
            {
                // TrackBar minimum ve maksimum değerlerini ayarlayın
                RedTrack.Minimum = 0;
                RedTrack.Maximum = 1000;

                GreenTrack.Minimum = 0;
                GreenTrack.Maximum = 1000;

                BlueTrack.Minimum = 0;
                BlueTrack.Maximum = 1000;

                // TrackBar'dan alınan değerleri float'a dönüştürün
                float r = (float)RedTrack.Value / 1000.0f;
                float g = (float)GreenTrack.Value / 1000.0f;
                float b = (float)BlueTrack.Value / 1000.0f;

                // Float değerleri ondalıklı formata dönüştürmek için
                string rStr = r.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
                string gStr = g.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
                string bStr = b.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);

                // Bellek adreslerine yazma işlemi
                svchost.WriteMemory("NFS13.exe+00CF5F48,30", "float", rStr); // Kırmızı
                svchost.WriteMemory("NFS13.exe+00CF5F48,34", "float", gStr); // Yeşil
                svchost.WriteMemory("NFS13.exe+00CF5F48,38", "float", bStr); // Mavi
            }
            else
            {             
            }

            if (ColorCheckBox2.Checked == true)
            { // TrackBar minimum ve maksimum değerlerini ayarlayın
                RedTrack2.Minimum = 0;
                RedTrack2.Maximum = 1000;

                GreenTrack2.Minimum = 0;
                GreenTrack2.Maximum = 1000;

                BlueTrack2.Minimum = 0;
                BlueTrack2.Maximum = 1000;

                // TrackBar'dan alınan değerleri float'a dönüştürün
                float r = (float)RedTrack2.Value / 1000.0f;
                float g = (float)GreenTrack2.Value / 1000.0f;
                float b = (float)BlueTrack2.Value / 1000.0f;

                // Float değerleri ondalıklı formata dönüştürmek için
                string rStr = r.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
                string gStr = g.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
                string bStr = b.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);

                // Bellek adreslerine yazma işlemi
                /*RED 2*/
                svchost.WriteMemory("NFS13.exe+00CF5F48,60", "float", rStr);
                /*Green 2*/
                svchost.WriteMemory("NFS13.exe+00CF5F48,64", "float", gStr);
                /*Blue 2*/
                svchost.WriteMemory("NFS13.exe+00CF5F48,68", "float", bStr);

            }
            else
            {
            }
            #endregion

            #region Misc
            /*Plate*/
            if (PlateBox.Checked == true)
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,40,0,EC,424", "String", Plate.Text);
            }
            if (ActiveButton.Checked == true)
            {
                /*Acceleration*/
                svchost.WriteMemory("NFS13.exe+00CEDB00,730,84,4,294,1D2C", "float", AccelerationUpDown.Value.ToString());
                /*Shift Delay*/
                svchost.WriteMemory("NFS13.exe+00CEDB00,730,84,4,294,4DC", "float", ShiftDelayUpDown.Value.ToString());
                /*Aéro Speed*/
                svchost.WriteMemory("NFS13.exe+00CEDB00,730,84,4,294,7D4", "float", AeroSpeedUpDown.Value.ToString());
                /*Aéro Downforce*/
                svchost.WriteMemory("NFS13.exe+00CEDB00,730,84,4,294,7D8", "float", AeroDownforceUpDown.Value.ToString());

            }
            if (Nitro.Checked == true)
            {
                svchost.WriteMemory("NFS13.exe+00CF5F48,-1DB680", "float", "100");
            }
            else
            {
              
            } 
            #endregion

        }

        #region Car Changer
        private void button1_Click(object sender, EventArgs e)
        {

            /* Police Cars */
            if (comboBox1.Text == "[122713] Crown Vic Interceptor")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719575385E-40");
            }
            else if (comboBox1.Text == "[510072] Ford SUV Interceptor")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "7.147631103E-40");
            }
            else if (comboBox1.Text == "[122699] Corvette Z06")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719379203E-40");
            }
            else if (comboBox1.Text == "[122706] SRT8 Charger")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719477294E-40");
            }
            else if (comboBox1.Text == "[1467242] S.W.A.T")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.056043961E-39");
            }


            /* CARS */

            else if (comboBox1.Text == "[1085698] Alfa Romeo 4C")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.52138694E-39");
            }
            else if (comboBox1.Text == "[2196263] Alfa Romeo Mito")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077619969E-39");
            }
            else if (comboBox1.Text == "[1160082] Ariel Atom V8")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.625621125E-39");
            }
            else if (comboBox1.Text == "[2196529] Aston Martin DB5")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077992715E-39");
            }
            else if (comboBox1.Text == "[2196595] Aston Martin DBS")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.0780852E-39");
            }
            else if (comboBox1.Text == "[122672] Aston Martin Vantage")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719000852E-40");
            }
            else if (comboBox1.Text == "[1160139] Audi A1")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.625700999E-39");
            }
            else if (comboBox1.Text == "[122675] Audi R8")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719042891E-40");
            }
            else if (comboBox1.Text == "[2196131] Audi RS3")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077434998E-39");
            }
            else if (comboBox1.Text == "[1160025] BAC Mono")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.625541251E-39");
            }
            else if (comboBox1.Text == "[866774] Bentley Supersports")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.214609075E-39");
            }
            else if (comboBox1.Text == "[2196065] BMW M1")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077342512E-39");
            }
            else if (comboBox1.Text == "[122682] BMW M3 E92")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719140982E-40");
            }
            else if (comboBox1.Text == "[393276] BMW M3 E46")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "5.510970549E-40");
            }
            else if (comboBox1.Text == "[122692] Bugatti Veyron")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719281112E-40");
            }
            else if (comboBox1.Text == "[2076005] Bugatti Veyron Vitesse")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909102618E-39");
            }
            else if (comboBox1.Text == "[393001] Caterham R500")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "5.507116978E-40");
            }
            else if (comboBox1.Text == "[621053] Chevrolet Camaro ZL1")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "8.702806152E-40");
            }
            else if (comboBox1.Text == "[122701] Chevrolet Corvette ZR1")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719407229E-40");
            }
            else if (comboBox1.Text == "[2196466] Dodge Charger R/T")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077904433E-39");
            }
            else if (comboBox1.Text == "[300097] Ford Raptor F150")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "4.205254652E-40");
            }
            else if (comboBox1.Text == "[2196197] Ford Fiesta ST")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077527483E-39");
            }
            else if (comboBox1.Text == "[1160480] Ford Focus RS500")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.626178842E-39");
            }
            else if (comboBox1.Text == "[122714] Ford GT")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719589398E-40");
            }
            else if (comboBox1.Text == "[122716] Ford Mustang Boss 302")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719617423E-40");
            }
            else if (comboBox1.Text == "[2076137] Hennessey Venom")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.90928759E-39");
            }
            else if (comboBox1.Text == "[1399602] Jaguar XKR")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.961260133E-39");
            }
            else if (comboBox1.Text == "[589261] Koenigsegg Agera")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "8.257305344E-40");               
            }
            else if (comboBox1.Text == "[392074] Lamborghini Aventador")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "5.494126941E-40");
            }
            else if (comboBox1.Text == "[2076203] Lamborghini Aventador J")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909380076E-39");
            }
            else if (comboBox1.Text == "[1085091] Lamborghini Countach")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.520536352E-39");
            }
            else if (comboBox1.Text == "[2076339] Lamborghini Diablo")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909570652E-39");
            }
            else if (comboBox1.Text == "[1085633] Lamborghini Gallardo")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521295856E-39");
            }
            else if (comboBox1.Text == "[1097100] Lancia Delta HF")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.537364545E-39");
            }
            else if (comboBox1.Text == "[1085958] Land Rover Evoque")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521751278E-39");
            }
            else if (comboBox1.Text == "[1085511] Lexus LFA")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521124897E-39");
            }
            else if (comboBox1.Text == "[1551590] Marussia B2")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.174240684E-39");
            }
            else if (comboBox1.Text == "[122757] Maserati GT MC12")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.720191956E-40");
            }
            else if (comboBox1.Text == "[2076070] McLaren F1")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909193703E-39");
            }
            else if (comboBox1.Text == "[122765] McLaren MP4-12C")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.72030406E-40");
            }
            else if (comboBox1.Text == "[122769] Mercedes Benz SL 65")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.720360112E-40");
            }
            else if (comboBox1.Text == "[122773] Mercedes Benz SLS")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.720416164E-40");
            }
            else if (comboBox1.Text == "[866832] Mitsubishi Lancer Evo")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.21469035E-39");
            }
            else if (comboBox1.Text == "[2076462] Nissan 350Z")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909743012E-39");
            }
            else if (comboBox1.Text == "[435169] Nissan R35")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "6.098016514E-40");
            }
            else if (comboBox1.Text == "[2076524] Nissan R34")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909829892E-39");
            }
            else if (comboBox1.Text == "[535435] Pagani Huayra")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "7.503042432E-40");
            }
            else if (comboBox1.Text == "[2076266] Pagani Zonda R")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.909468357E-39");
            }
            else if (comboBox1.Text == "[2196399] Pontiac Firebird")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077810546E-39");
            }
            else if (comboBox1.Text == "[1085007] Porsche 911")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.520418643E-39");
            }
            else if (comboBox1.Text == "[2076399] Porsche 911 GT2")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "2.90965473E-39");
            }
            else if (comboBox1.Text == "[1085186] Porsche 911 Turbo 3")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.520669475E-39");
            }
            else if (comboBox1.Text == "[2196000] Porsche 918 Spyder")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077251428E-39");
            }
            else if (comboBox1.Text == "[1085830] Porsche 918 Concept")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521571912E-39");
            }
            else if (comboBox1.Text == "[535621] Porsche Panamera Turbo")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "7.505648848E-40");
            }
            else if (comboBox1.Text == "[1085576] Shelby Cobra 427")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521215982E-39");
            }
            else if (comboBox1.Text == "[2196334] Shelby GT500")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "3.077719461E-39");
            }
            else if (comboBox1.Text == "[122704] Dodge Challenger SRT8")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.719449268E-40");
            }
            else if (comboBox1.Text == "[1160350] Dodge Viper SRT8")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.625996673E-39");
            }
            else if (comboBox1.Text == "[122814] Subaru Impreza STI")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.720990696E-40");
            }
            else if (comboBox1.Text == "[1085764] Tesla Roadster Sport")
            {
                svchost.WriteMemory("NFS13.exe+00D0FD08,8,50,308,18,-160A4", "float", "1.521479426E-39");
            }

        }

        #endregion

        #region Rainbow Car Color
        Random random = new Random();
        Random random2 = new Random();
        public static System.Drawing.Color FromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return System.Drawing.Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return System.Drawing.Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return System.Drawing.Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return System.Drawing.Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return System.Drawing.Color.FromArgb(255, t, p, v);
            else
                return System.Drawing.Color.FromArgb(255, v, p, q);
        }

        private void Rainbow_Tick(object sender, EventArgs e)
        {
            // Rastgele RGB değerleri üret
            float r = (float)random.NextDouble();
            float g = (float)random.NextDouble();
            float b = (float)random.NextDouble();

            // Float değerleri ondalıklı formata dönüştürmek için
            string rStr = r.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
            string gStr = g.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
            string bStr = b.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);

            // Bellek adreslerine yazma işlemi
            svchost.WriteMemory("NFS13.exe+00CF5F48,30", "float", rStr); // Kırmızı
            svchost.WriteMemory("NFS13.exe+00CF5F48,34", "float", gStr); // Yeşil
            svchost.WriteMemory("NFS13.exe+00CF5F48,38", "float", bStr); // Mavi
        }
        #endregion

        #region Rainbow Car Color 2
        private void Rainbow2_Tick(object sender, EventArgs e)
        {
            // Rastgele RGB değerleri üret
            float r = (float)random2.NextDouble();
            float g = (float)random2.NextDouble();
            float b = (float)random2.NextDouble();

            // Float değerleri ondalıklı formata dönüştürmek için
            string rStr = r.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
            string gStr = g.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);
            string bStr = b.ToString("0.0000000000", System.Globalization.CultureInfo.InvariantCulture);

            // Bellek adreslerine yazma işlemi
            svchost.WriteMemory("NFS13.exe+00CF5F48,60", "float", rStr);
            svchost.WriteMemory("NFS13.exe+00CF5F48,64", "float", gStr);
            svchost.WriteMemory("NFS13.exe+00CF5F48,68", "float", bStr);
        }

        #endregion
      
    }
}
