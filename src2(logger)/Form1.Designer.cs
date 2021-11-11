
namespace StarCitizen_DevTool
{
    partial class Main
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
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.Z_textBox = new System.Windows.Forms.TextBox();
            this.tele_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.active_Panel = new System.Windows.Forms.Panel();
            this.output_button = new System.Windows.Forms.Button();
            this.summary_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.hotkeys_checkBox = new System.Windows.Forms.CheckBox();
            this.x_strengthBox = new System.Windows.Forms.TextBox();
            this.y_strengthBox = new System.Windows.Forms.TextBox();
            this.z_strengthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hotkey_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HotkeyTimer = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(39, 9);
            this.X_textBox.MaxLength = 30;
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(168, 20);
            this.X_textBox.TabIndex = 0;
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(39, 35);
            this.Y_textBox.MaxLength = 30;
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(168, 20);
            this.Y_textBox.TabIndex = 1;
            // 
            // Z_textBox
            // 
            this.Z_textBox.Location = new System.Drawing.Point(39, 61);
            this.Z_textBox.MaxLength = 30;
            this.Z_textBox.Name = "Z_textBox";
            this.Z_textBox.Size = new System.Drawing.Size(168, 20);
            this.Z_textBox.TabIndex = 2;
            // 
            // tele_button
            // 
            this.tele_button.Location = new System.Drawing.Point(39, 87);
            this.tele_button.Name = "tele_button";
            this.tele_button.Size = new System.Drawing.Size(168, 23);
            this.tele_button.TabIndex = 3;
            this.tele_button.Text = "TEST COORDINATES";
            this.tele_button.UseVisualStyleBackColor = true;
            this.tele_button.Click += new System.EventHandler(this.tele_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Z_textBox);
            this.panel1.Controls.Add(this.tele_button);
            this.panel1.Controls.Add(this.X_textBox);
            this.panel1.Controls.Add(this.Y_textBox);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 115);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "posZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "posY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "posX";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(5, 184);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(246, 88);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // active_Panel
            // 
            this.active_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.active_Panel.Location = new System.Drawing.Point(0, 271);
            this.active_Panel.Name = "active_Panel";
            this.active_Panel.Size = new System.Drawing.Size(350, 10);
            this.active_Panel.TabIndex = 5;
            // 
            // output_button
            // 
            this.output_button.Location = new System.Drawing.Point(5, 156);
            this.output_button.Name = "output_button";
            this.output_button.Size = new System.Drawing.Size(246, 23);
            this.output_button.TabIndex = 6;
            this.output_button.Text = "LOG WORKING COORDINATES";
            this.output_button.UseVisualStyleBackColor = true;
            this.output_button.Click += new System.EventHandler(this.output_button_Click);
            // 
            // summary_textBox
            // 
            this.summary_textBox.Location = new System.Drawing.Point(73, 130);
            this.summary_textBox.MaxLength = 50;
            this.summary_textBox.Name = "summary_textBox";
            this.summary_textBox.Size = new System.Drawing.Size(178, 20);
            this.summary_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUMMARY";
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Interval = 5000;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // hotkeys_checkBox
            // 
            this.hotkeys_checkBox.AutoSize = true;
            this.hotkeys_checkBox.ForeColor = System.Drawing.Color.Red;
            this.hotkeys_checkBox.Location = new System.Drawing.Point(9, 7);
            this.hotkeys_checkBox.Name = "hotkeys_checkBox";
            this.hotkeys_checkBox.Size = new System.Drawing.Size(77, 17);
            this.hotkeys_checkBox.TabIndex = 10;
            this.hotkeys_checkBox.Text = "HOTKEYS";
            this.hotkeys_checkBox.UseVisualStyleBackColor = true;
            // 
            // x_strengthBox
            // 
            this.x_strengthBox.Location = new System.Drawing.Point(14, 42);
            this.x_strengthBox.MaxLength = 3;
            this.x_strengthBox.Name = "x_strengthBox";
            this.x_strengthBox.Size = new System.Drawing.Size(58, 20);
            this.x_strengthBox.TabIndex = 11;
            // 
            // y_strengthBox
            // 
            this.y_strengthBox.Location = new System.Drawing.Point(14, 68);
            this.y_strengthBox.MaxLength = 3;
            this.y_strengthBox.Name = "y_strengthBox";
            this.y_strengthBox.Size = new System.Drawing.Size(58, 20);
            this.y_strengthBox.TabIndex = 12;
            // 
            // z_strengthBox
            // 
            this.z_strengthBox.Location = new System.Drawing.Point(14, 94);
            this.z_strengthBox.MaxLength = 3;
            this.z_strengthBox.Name = "z_strengthBox";
            this.z_strengthBox.Size = new System.Drawing.Size(58, 20);
            this.z_strengthBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "STRENGTH";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.hotkey_button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.hotkeys_checkBox);
            this.panel2.Controls.Add(this.z_strengthBox);
            this.panel2.Controls.Add(this.x_strengthBox);
            this.panel2.Controls.Add(this.y_strengthBox);
            this.panel2.Location = new System.Drawing.Point(258, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 210);
            this.panel2.TabIndex = 15;
            // 
            // hotkey_button
            // 
            this.hotkey_button.Location = new System.Drawing.Point(24, 118);
            this.hotkey_button.Name = "hotkey_button";
            this.hotkey_button.Size = new System.Drawing.Size(38, 23);
            this.hotkey_button.TabIndex = 10;
            this.hotkey_button.Text = "SET";
            this.hotkey_button.UseVisualStyleBackColor = true;
            this.hotkey_button.Click += new System.EventHandler(this.hotkey_button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(258, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 51);
            this.panel3.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "by NightFyre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "CoordsGrabber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "version 1.3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "NightCity Tool";
            // 
            // HotkeyTimer
            // 
            this.HotkeyTimer.Enabled = true;
            this.HotkeyTimer.Tick += new System.EventHandler(this.HotkeyTimer_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "NUM1: UP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "NUM2: DOWN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "ARROW KEYS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(11, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "CONTROLS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-1, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-1, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Z";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 281);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.summary_textBox);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.active_Panel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NightCity::dev";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.TextBox Z_textBox;
        private System.Windows.Forms.Button tele_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel active_Panel;
        private System.Windows.Forms.Button output_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox summary_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox z_strengthBox;
        private System.Windows.Forms.TextBox y_strengthBox;
        private System.Windows.Forms.TextBox x_strengthBox;
        private System.Windows.Forms.CheckBox hotkeys_checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hotkey_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer HotkeyTimer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

