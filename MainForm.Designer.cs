namespace WaterLevelController
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudRate_Combo = new System.Windows.Forms.ComboBox();
            this.ComPort_Combo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Output_Box = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Fill_Full_Button = new System.Windows.Forms.Button();
            this.Fill_Half_Button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Connect_Button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BaudRate_Combo);
            this.groupBox1.Controls.Add(this.ComPort_Combo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port:";
            // 
            // BaudRate_Combo
            // 
            this.BaudRate_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate_Combo.FormattingEnabled = true;
            this.BaudRate_Combo.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate_Combo.Location = new System.Drawing.Point(186, 46);
            this.BaudRate_Combo.Name = "BaudRate_Combo";
            this.BaudRate_Combo.Size = new System.Drawing.Size(147, 21);
            this.BaudRate_Combo.TabIndex = 1;
            // 
            // ComPort_Combo
            // 
            this.ComPort_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort_Combo.FormattingEnabled = true;
            this.ComPort_Combo.Location = new System.Drawing.Point(186, 19);
            this.ComPort_Combo.Name = "ComPort_Combo";
            this.ComPort_Combo.Size = new System.Drawing.Size(147, 21);
            this.ComPort_Combo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Output_Box);
            this.groupBox2.Location = new System.Drawing.Point(6, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim:";
            // 
            // Output_Box
            // 
            this.Output_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output_Box.Location = new System.Drawing.Point(3, 16);
            this.Output_Box.Multiline = true;
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(339, 156);
            this.Output_Box.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Fill_Full_Button);
            this.groupBox3.Controls.Add(this.Fill_Half_Button);
            this.groupBox3.Location = new System.Drawing.Point(9, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrol";
            // 
            // Fill_Full_Button
            // 
            this.Fill_Full_Button.Location = new System.Drawing.Point(87, 19);
            this.Fill_Full_Button.Name = "Fill_Full_Button";
            this.Fill_Full_Button.Size = new System.Drawing.Size(75, 23);
            this.Fill_Full_Button.TabIndex = 3;
            this.Fill_Full_Button.Text = "%100 Doldur";
            this.Fill_Full_Button.UseVisualStyleBackColor = true;
            // 
            // Fill_Half_Button
            // 
            this.Fill_Half_Button.Location = new System.Drawing.Point(6, 19);
            this.Fill_Half_Button.Name = "Fill_Half_Button";
            this.Fill_Half_Button.Size = new System.Drawing.Size(75, 23);
            this.Fill_Half_Button.TabIndex = 0;
            this.Fill_Half_Button.Text = "%50 Doldur";
            this.Fill_Half_Button.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(357, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 372);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seviye";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 353);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(224, 50);
            this.panel2.TabIndex = 0;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(258, 73);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 4;
            this.Connect_Button.Text = "Bağlan";
            this.Connect_Button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 396);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Su Seviye Kontrolü - v0.0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BaudRate_Combo;
        private System.Windows.Forms.ComboBox ComPort_Combo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Output_Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Fill_Full_Button;
        private System.Windows.Forms.Button Fill_Half_Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Connect_Button;
    }
}

