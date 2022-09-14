namespace Projekt_inz_1
{
    partial class Generator_sygnalow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTKotla = new System.Windows.Forms.NumericUpDown();
            this.numT2 = new System.Windows.Forms.NumericUpDown();
            this.numT1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTKotla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(755, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Temperatura kotła:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(396, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperatura 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Temperatura 1:";
            // 
            // numTKotla
            // 
            this.numTKotla.DecimalPlaces = 1;
            this.numTKotla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numTKotla.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTKotla.Location = new System.Drawing.Point(972, 129);
            this.numTKotla.Name = "numTKotla";
            this.numTKotla.Size = new System.Drawing.Size(92, 28);
            this.numTKotla.TabIndex = 11;
            this.numTKotla.ValueChanged += new System.EventHandler(this.numTKotla_ValueChanged);
            // 
            // numT2
            // 
            this.numT2.DecimalPlaces = 1;
            this.numT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numT2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numT2.Location = new System.Drawing.Point(605, 127);
            this.numT2.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numT2.Name = "numT2";
            this.numT2.Size = new System.Drawing.Size(92, 28);
            this.numT2.TabIndex = 10;
            this.numT2.ValueChanged += new System.EventHandler(this.numT2_ValueChanged);
            // 
            // numT1
            // 
            this.numT1.DecimalPlaces = 1;
            this.numT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numT1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numT1.Location = new System.Drawing.Point(248, 127);
            this.numT1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numT1.Name = "numT1";
            this.numT1.Size = new System.Drawing.Size(92, 28);
            this.numT1.TabIndex = 9;
            this.numT1.ValueChanged += new System.EventHandler(this.numT1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(907, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generator wartości temperatur do symulatora instalacji grzewczej:";
            // 
            // Generator_sygnalow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1101, 199);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTKotla);
            this.Controls.Add(this.numT2);
            this.Controls.Add(this.numT1);
            this.Controls.Add(this.label1);
            this.Name = "Generator_sygnalow";
            this.Text = "Generator_sygnalow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generator_sygnalow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numTKotla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTKotla;
        private System.Windows.Forms.NumericUpDown numT2;
        private System.Windows.Forms.NumericUpDown numT1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}