namespace HMI_prototipo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxPort = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBautRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelBaut = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.groupBoxLed = new System.Windows.Forms.GroupBox();
            this.buttonledOff = new System.Windows.Forms.Button();
            this.buttonLedOn = new System.Windows.Forms.Button();
            this.pictureBoxLed = new System.Windows.Forms.PictureBox();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPort.SuspendLayout();
            this.groupBoxLed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPort.Controls.Add(this.buttonClose);
            this.groupBoxPort.Controls.Add(this.buttonOpen);
            this.groupBoxPort.Controls.Add(this.comboBoxBautRate);
            this.groupBoxPort.Controls.Add(this.comboBoxPort);
            this.groupBoxPort.Controls.Add(this.labelBaut);
            this.groupBoxPort.Controls.Add(this.labelPort);
            this.groupBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPort.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxPort.Location = new System.Drawing.Point(12, 15);
            this.groupBoxPort.Name = "groupBoxPort";
            this.groupBoxPort.Size = new System.Drawing.Size(372, 156);
            this.groupBoxPort.TabIndex = 0;
            this.groupBoxPort.TabStop = false;
            this.groupBoxPort.Text = "COM PORT SETTINGS";
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(110, 121);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(83, 28);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.ForeColor = System.Drawing.Color.Black;
            this.buttonOpen.Location = new System.Drawing.Point(9, 121);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(66, 28);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxBautRate
            // 
            this.comboBoxBautRate.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxBautRate.ForeColor = System.Drawing.Color.Black;
            this.comboBoxBautRate.FormattingEnabled = true;
            this.comboBoxBautRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBautRate.Location = new System.Drawing.Point(110, 72);
            this.comboBoxBautRate.Name = "comboBoxBautRate";
            this.comboBoxBautRate.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBautRate.TabIndex = 3;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPort.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(110, 27);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 26);
            this.comboBoxPort.TabIndex = 2;
            // 
            // labelBaut
            // 
            this.labelBaut.AutoSize = true;
            this.labelBaut.Location = new System.Drawing.Point(6, 80);
            this.labelBaut.Name = "labelBaut";
            this.labelBaut.Size = new System.Drawing.Size(99, 18);
            this.labelBaut.TabIndex = 1;
            this.labelBaut.Text = "BAUT RATE";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 35);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(98, 18);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "COM PORT";
            this.labelPort.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // groupBoxLed
            // 
            this.groupBoxLed.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLed.Controls.Add(this.buttonledOff);
            this.groupBoxLed.Controls.Add(this.buttonLedOn);
            this.groupBoxLed.Controls.Add(this.pictureBoxLed);
            this.groupBoxLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLed.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxLed.Location = new System.Drawing.Point(12, 208);
            this.groupBoxLed.Name = "groupBoxLed";
            this.groupBoxLed.Size = new System.Drawing.Size(203, 177);
            this.groupBoxLed.TabIndex = 1;
            this.groupBoxLed.TabStop = false;
            this.groupBoxLed.Text = "LED CONTROL";
            // 
            // buttonledOff
            // 
            this.buttonledOff.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonledOff.Location = new System.Drawing.Point(100, 141);
            this.buttonledOff.Name = "buttonledOff";
            this.buttonledOff.Size = new System.Drawing.Size(97, 31);
            this.buttonledOff.TabIndex = 2;
            this.buttonledOff.Text = "Led OFF";
            this.buttonledOff.UseVisualStyleBackColor = true;
            this.buttonledOff.Click += new System.EventHandler(this.buttonledOff_Click);
            // 
            // buttonLedOn
            // 
            this.buttonLedOn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn.Location = new System.Drawing.Point(6, 141);
            this.buttonLedOn.Name = "buttonLedOn";
            this.buttonLedOn.Size = new System.Drawing.Size(79, 31);
            this.buttonLedOn.TabIndex = 1;
            this.buttonLedOn.Text = "Led ON";
            this.buttonLedOn.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLed
            // 
            this.pictureBoxLed.Image = global::HMI_prototipo1.Properties.Resources.blue_power_button;
            this.pictureBoxLed.Location = new System.Drawing.Point(57, 36);
            this.pictureBoxLed.Name = "pictureBoxLed";
            this.pictureBoxLed.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLed.TabIndex = 0;
            this.pictureBoxLed.TabStop = false;
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(12, 177);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(372, 25);
            this.progressBarConnection.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(230, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVO CONTROL(valvula)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "180°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "0°";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 53);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(914, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarConnection);
            this.Controls.Add(this.groupBoxLed);
            this.Controls.Add(this.groupBoxPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(291, 214);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPort.ResumeLayout(false);
            this.groupBoxPort.PerformLayout();
            this.groupBoxLed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.GroupBox groupBoxLed;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBautRate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelBaut;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.PictureBox pictureBoxLed;
        private System.Windows.Forms.Button buttonledOff;
        private System.Windows.Forms.Button buttonLedOn;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

