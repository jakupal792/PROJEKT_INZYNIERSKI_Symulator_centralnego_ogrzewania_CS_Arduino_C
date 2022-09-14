namespace Projekt_inz_1
{
    partial class Symulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txt_t1 = new System.Windows.Forms.TextBox();
            this.txt_t2 = new System.Windows.Forms.TextBox();
            this.txt_t_kotla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.track_t_oczek = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmb_skale_temperatur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnZmienSkaleT = new System.Windows.Forms.Button();
            this.btnUsunietoAwarie = new System.Windows.Forms.Button();
            this.lstAwarie = new System.Windows.Forms.ListBox();
            this.num_t_oczek = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_stan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCzasStanUstalony = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOpal = new System.Windows.Forms.TextBox();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track_t_oczek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_oczek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_t1
            // 
            this.txt_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_t1.Location = new System.Drawing.Point(1069, 208);
            this.txt_t1.Name = "txt_t1";
            this.txt_t1.Size = new System.Drawing.Size(76, 28);
            this.txt_t1.TabIndex = 0;
            // 
            // txt_t2
            // 
            this.txt_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_t2.Location = new System.Drawing.Point(1377, 208);
            this.txt_t2.Name = "txt_t2";
            this.txt_t2.Size = new System.Drawing.Size(76, 28);
            this.txt_t2.TabIndex = 1;
            // 
            // txt_t_kotla
            // 
            this.txt_t_kotla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_t_kotla.Location = new System.Drawing.Point(1731, 205);
            this.txt_t_kotla.Name = "txt_t_kotla";
            this.txt_t_kotla.Size = new System.Drawing.Size(76, 28);
            this.txt_t_kotla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(892, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1213, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1529, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura kotła:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(204, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ustaw oczekiwaną temperaturę:";
            // 
            // track_t_oczek
            // 
            this.track_t_oczek.Location = new System.Drawing.Point(136, 205);
            this.track_t_oczek.Maximum = 30;
            this.track_t_oczek.Minimum = 10;
            this.track_t_oczek.Name = "track_t_oczek";
            this.track_t_oczek.Size = new System.Drawing.Size(362, 56);
            this.track_t_oczek.TabIndex = 8;
            this.track_t_oczek.Value = 10;
            this.track_t_oczek.Scroll += new System.EventHandler(this.track_t_oczek_Scroll);
            // 
            // cmb_skale_temperatur
            // 
            this.cmb_skale_temperatur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmb_skale_temperatur.FormattingEnabled = true;
            this.cmb_skale_temperatur.Location = new System.Drawing.Point(209, 417);
            this.cmb_skale_temperatur.Name = "cmb_skale_temperatur";
            this.cmb_skale_temperatur.Size = new System.Drawing.Size(121, 30);
            this.cmb_skale_temperatur.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(470, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "30 [°C]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(298, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(185, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Skala temperatury:";
            // 
            // btnZmienSkaleT
            // 
            this.btnZmienSkaleT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnZmienSkaleT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZmienSkaleT.Location = new System.Drawing.Point(399, 379);
            this.btnZmienSkaleT.Name = "btnZmienSkaleT";
            this.btnZmienSkaleT.Size = new System.Drawing.Size(176, 68);
            this.btnZmienSkaleT.TabIndex = 22;
            this.btnZmienSkaleT.Text = "Zmień skalę temperatury";
            this.btnZmienSkaleT.UseVisualStyleBackColor = false;
            this.btnZmienSkaleT.Click += new System.EventHandler(this.btnZmienSkaleT_Click);
            // 
            // btnUsunietoAwarie
            // 
            this.btnUsunietoAwarie.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUsunietoAwarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunietoAwarie.Location = new System.Drawing.Point(209, 768);
            this.btnUsunietoAwarie.Name = "btnUsunietoAwarie";
            this.btnUsunietoAwarie.Size = new System.Drawing.Size(343, 52);
            this.btnUsunietoAwarie.TabIndex = 26;
            this.btnUsunietoAwarie.Text = "Usunięto wszystkie awarie";
            this.btnUsunietoAwarie.UseVisualStyleBackColor = false;
            this.btnUsunietoAwarie.Click += new System.EventHandler(this.btnUsunietoAwarie_Click);
            // 
            // lstAwarie
            // 
            this.lstAwarie.BackColor = System.Drawing.SystemColors.Menu;
            this.lstAwarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstAwarie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstAwarie.FormattingEnabled = true;
            this.lstAwarie.ItemHeight = 22;
            this.lstAwarie.Location = new System.Drawing.Point(158, 648);
            this.lstAwarie.Name = "lstAwarie";
            this.lstAwarie.Size = new System.Drawing.Size(452, 70);
            this.lstAwarie.TabIndex = 27;
            // 
            // num_t_oczek
            // 
            this.num_t_oczek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_t_oczek.Location = new System.Drawing.Point(571, 208);
            this.num_t_oczek.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_t_oczek.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_t_oczek.Name = "num_t_oczek";
            this.num_t_oczek.Size = new System.Drawing.Size(66, 28);
            this.num_t_oczek.TabIndex = 34;
            this.num_t_oczek.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_t_oczek.ValueChanged += new System.EventHandler(this.num_t_oczek_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1178, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Temperatury w instalacji:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(228, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ustaw skalę temperatury:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(281, 576);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 29);
            this.label12.TabIndex = 37;
            this.label12.Text = "Sytuacje awaryjne:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(824, 277);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Temperatura kotła";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Temperatura 1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Temperatura 2";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1037, 567);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            title2.Name = "Temperatura:";
            this.chart1.Titles.Add(title2);
            // 
            // label_stan
            // 
            this.label_stan.AutoSize = true;
            this.label_stan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_stan.Location = new System.Drawing.Point(393, 498);
            this.label_stan.Name = "label_stan";
            this.label_stan.Size = new System.Drawing.Size(169, 32);
            this.label_stan.TabIndex = 39;
            this.label_stan.Text = "Wygaszony";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(183, 498);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 32);
            this.label13.TabIndex = 40;
            this.label13.Text = "Stan układu:";
            // 
            // txtCzasStanUstalony
            // 
            this.txtCzasStanUstalony.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCzasStanUstalony.Location = new System.Drawing.Point(1707, 893);
            this.txtCzasStanUstalony.Name = "txtCzasStanUstalony";
            this.txtCzasStanUstalony.Size = new System.Drawing.Size(76, 28);
            this.txtCzasStanUstalony.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(1329, 896);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(326, 22);
            this.label14.TabIndex = 42;
            this.label14.Text = "Czas osiągnięcia stanu ustalonego:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(1805, 896);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 22);
            this.label15.TabIndex = 43;
            this.label15.Text = "min";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(1227, 896);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 22);
            this.label16.TabIndex = 46;
            this.label16.Text = "kg";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(857, 896);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(237, 22);
            this.label17.TabIndex = 45;
            this.label17.Text = "Masa dodawanego opału:";
            // 
            // txtOpal
            // 
            this.txtOpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOpal.Location = new System.Drawing.Point(1129, 893);
            this.txtOpal.Name = "txtOpal";
            this.txtOpal.Size = new System.Drawing.Size(76, 28);
            this.txtOpal.TabIndex = 44;
            // 
            // btnGenerator
            // 
            this.btnGenerator.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerator.Location = new System.Drawing.Point(158, 866);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(452, 52);
            this.btnGenerator.TabIndex = 47;
            this.btnGenerator.Text = "Otwórz generator sygnałów";
            this.btnGenerator.UseVisualStyleBackColor = false;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(84, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1699, 48);
            this.label18.TabIndex = 48;
            this.label18.Text = "Symulator do monitorowania temperatury i sterowania centralnym ogrzewaniem domu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(217, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "15";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(385, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 22);
            this.label19.TabIndex = 50;
            this.label19.Text = "25";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(142, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 22);
            this.label20.TabIndex = 51;
            this.label20.Text = "10";
            // 
            // Symulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtOpal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCzasStanUstalony);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_stan);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_t_oczek);
            this.Controls.Add(this.lstAwarie);
            this.Controls.Add(this.btnUsunietoAwarie);
            this.Controls.Add(this.btnZmienSkaleT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_skale_temperatur);
            this.Controls.Add(this.track_t_oczek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_t_kotla);
            this.Controls.Add(this.txt_t2);
            this.Controls.Add(this.txt_t1);
            this.Name = "Symulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Symulator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.track_t_oczek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_t_oczek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_t1;
        private System.Windows.Forms.TextBox txt_t2;
        private System.Windows.Forms.TextBox txt_t_kotla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar track_t_oczek;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmb_skale_temperatur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnZmienSkaleT;
        private System.Windows.Forms.Button btnUsunietoAwarie;
        private System.Windows.Forms.ListBox lstAwarie;
        private System.Windows.Forms.NumericUpDown num_t_oczek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_stan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCzasStanUstalony;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOpal;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

