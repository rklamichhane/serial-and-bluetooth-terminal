namespace serial_communication
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.COMlist = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.automatic = new System.Windows.Forms.RadioButton();
            this.mannual = new System.Windows.Forms.RadioButton();
            this.setup = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Parity_Bits = new System.Windows.Forms.ComboBox();
            this.Baud_Rate = new System.Windows.Forms.ComboBox();
            this.Stop_Bits = new System.Windows.Forms.ComboBox();
            this.Data_Bits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.current_setting_panel = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Label();
            this.brl = new System.Windows.Forms.Label();
            this.dbl = new System.Windows.Forms.Label();
            this.sbl = new System.Windows.Forms.Label();
            this.pl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.current_setting_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMlist
            // 
            this.COMlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMlist.FormattingEnabled = true;
            this.COMlist.Location = new System.Drawing.Point(440, 32);
            this.COMlist.Name = "COMlist";
            this.COMlist.Size = new System.Drawing.Size(121, 24);
            this.COMlist.TabIndex = 2;
            this.COMlist.Text = "COM PORTS";
            this.COMlist.TabIndexChanged += new System.EventHandler(this.port_name);
            this.COMlist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disable_key_press);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // automatic
            // 
            this.automatic.AutoSize = true;
            this.automatic.Location = new System.Drawing.Point(54, 32);
            this.automatic.Name = "automatic";
            this.automatic.Size = new System.Drawing.Size(129, 21);
            this.automatic.TabIndex = 0;
            this.automatic.TabStop = true;
            this.automatic.Text = "automatic setup";
            this.automatic.UseVisualStyleBackColor = true;
            this.automatic.CheckedChanged += new System.EventHandler(this.setup_changed_automatic);
            // 
            // mannual
            // 
            this.mannual.AutoSize = true;
            this.mannual.Location = new System.Drawing.Point(54, 66);
            this.mannual.Name = "mannual";
            this.mannual.Size = new System.Drawing.Size(122, 21);
            this.mannual.TabIndex = 1;
            this.mannual.TabStop = true;
            this.mannual.Text = "mannual setup";
            this.mannual.UseVisualStyleBackColor = true;
            this.mannual.CheckedChanged += new System.EventHandler(this.setup_changed_mannual);
            // 
            // setup
            // 
            this.setup.BackColor = System.Drawing.SystemColors.Control;
            this.setup.Cursor = System.Windows.Forms.Cursors.Default;
            this.setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setup.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.setup.Location = new System.Drawing.Point(7, 23);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(172, 100);
            this.setup.TabIndex = 4;
            this.setup.Text = "Setup Menu";
            this.setup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setup.Click += new System.EventHandler(this.setup_clicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main menu  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.MaximumSize = new System.Drawing.Size(200, 100);
            this.label3.MinimumSize = new System.Drawing.Size(131, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = "Control mode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(12, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 100);
            this.label4.TabIndex = 4;
            this.label4.Text = "Setup Menu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.current_setting_panel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Parity_Bits);
            this.panel1.Controls.Add(this.Baud_Rate);
            this.panel1.Controls.Add(this.Data_Bits);
            this.panel1.Controls.Add(this.Stop_Bits);
            this.panel1.Controls.Add(this.COMlist);
            this.panel1.Controls.Add(this.automatic);
            this.panel1.Controls.Add(this.mannual);
            this.panel1.Location = new System.Drawing.Point(210, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 467);
            this.panel1.TabIndex = 5;
            // 
            // Parity_Bits
            // 
            this.Parity_Bits.FormattingEnabled = true;
            this.Parity_Bits.Location = new System.Drawing.Point(440, 220);
            this.Parity_Bits.Name = "Parity_Bits";
            this.Parity_Bits.Size = new System.Drawing.Size(121, 24);
            this.Parity_Bits.TabIndex = 3;
            this.Parity_Bits.Text = "PARITY";
            this.Parity_Bits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disable_key_press);
            // 
            // Baud_Rate
            // 
            this.Baud_Rate.FormattingEnabled = true;
            this.Baud_Rate.Location = new System.Drawing.Point(440, 79);
            this.Baud_Rate.Name = "Baud_Rate";
            this.Baud_Rate.Size = new System.Drawing.Size(121, 24);
            this.Baud_Rate.TabIndex = 3;
            this.Baud_Rate.Text = "BAUD RATE";
            this.Baud_Rate.SelectedIndexChanged += new System.EventHandler(this.text_updated_baud);
            this.Baud_Rate.TextUpdate += new System.EventHandler(this.text_updated_baud);
            // 
            // Stop_Bits
            // 
            this.Stop_Bits.FormattingEnabled = true;
            this.Stop_Bits.Location = new System.Drawing.Point(440, 173);
            this.Stop_Bits.Name = "Stop_Bits";
            this.Stop_Bits.Size = new System.Drawing.Size(121, 24);
            this.Stop_Bits.TabIndex = 3;
            this.Stop_Bits.Text = "STOP BITS";
            this.Stop_Bits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disable_key_press);
            // 
            // Data_Bits
            // 
            this.Data_Bits.Location = new System.Drawing.Point(440, 126);
            this.Data_Bits.Name = "Data_Bits";
            this.Data_Bits.Size = new System.Drawing.Size(121, 24);
            this.Data_Bits.TabIndex = 3;
            this.Data_Bits.Text = "DATA BITS";
            this.Data_Bits.SelectedIndexChanged += new System.EventHandler(this.data_bits_changed);
            this.Data_Bits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.disable_key_press);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "available com ports";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "bits to represent data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of stop bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Parity";
            // 
            // current_setting_panel
            // 
            this.current_setting_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_setting_panel.Controls.Add(this.pl);
            this.current_setting_panel.Controls.Add(this.sbl);
            this.current_setting_panel.Controls.Add(this.dbl);
            this.current_setting_panel.Controls.Add(this.brl);
            this.current_setting_panel.Controls.Add(this.pnl);
            this.current_setting_panel.Location = new System.Drawing.Point(14, 126);
            this.current_setting_panel.Name = "current_setting_panel";
            this.current_setting_panel.Size = new System.Drawing.Size(241, 180);
            this.current_setting_panel.TabIndex = 5;
            this.current_setting_panel.Click += new System.EventHandler(this.label_update);
            // 
            // pnl
            // 
            this.pnl.AutoSize = true;
            this.pnl.Location = new System.Drawing.Point(19, 22);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(90, 17);
            this.pnl.TabIndex = 0;
            this.pnl.Text = "current port=";
            // 
            // brl
            // 
            this.brl.AutoSize = true;
            this.brl.Location = new System.Drawing.Point(19, 51);
            this.brl.Name = "brl";
            this.brl.Size = new System.Drawing.Size(126, 17);
            this.brl.TabIndex = 0;
            this.brl.Text = "current baud rate=";
            // 
            // dbl
            // 
            this.dbl.AutoSize = true;
            this.dbl.Location = new System.Drawing.Point(19, 80);
            this.dbl.Name = "dbl";
            this.dbl.Size = new System.Drawing.Size(119, 17);
            this.dbl.TabIndex = 0;
            this.dbl.Text = "current data bits=";
            // 
            // sbl
            // 
            this.sbl.AutoSize = true;
            this.sbl.Location = new System.Drawing.Point(19, 109);
            this.sbl.Name = "sbl";
            this.sbl.Size = new System.Drawing.Size(105, 17);
            this.sbl.TabIndex = 0;
            this.sbl.Text = "no of stop bits=";
            // 
            // pl
            // 
            this.pl.AutoSize = true;
            this.pl.Location = new System.Drawing.Point(19, 138);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(77, 17);
            this.pl.TabIndex = 0;
            this.pl.Text = "parity bits=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setup);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.current_setting_panel.ResumeLayout(false);
            this.current_setting_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox COMlist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton automatic;
        private System.Windows.Forms.RadioButton mannual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label setup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Parity_Bits;
        private System.Windows.Forms.ComboBox Baud_Rate;
        private System.Windows.Forms.ComboBox Stop_Bits;
        private System.Windows.Forms.ComboBox Data_Bits;
        private System.Windows.Forms.Panel current_setting_panel;
        private System.Windows.Forms.Label sbl;
        private System.Windows.Forms.Label dbl;
        private System.Windows.Forms.Label brl;
        private System.Windows.Forms.Label pnl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pl;
    }
}

