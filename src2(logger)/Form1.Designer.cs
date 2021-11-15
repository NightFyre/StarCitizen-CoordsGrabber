
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hotkey_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.moveSTRENGTH_trackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HotkeyTimer = new System.Windows.Forms.Timer(this.components);
            this.trackbar_checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackbarValue_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSTRENGTH_trackBar)).BeginInit();
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
            this.richTextBox.Size = new System.Drawing.Size(246, 94);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // active_Panel
            // 
            this.active_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.active_Panel.Location = new System.Drawing.Point(0, 284);
            this.active_Panel.Name = "active_Panel";
            this.active_Panel.Size = new System.Drawing.Size(437, 10);
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
            this.hotkeys_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.hotkeys_checkBox.ForeColor = System.Drawing.Color.Red;
            this.hotkeys_checkBox.Location = new System.Drawing.Point(263, 122);
            this.hotkeys_checkBox.Name = "hotkeys_checkBox";
            this.hotkeys_checkBox.Size = new System.Drawing.Size(74, 17);
            this.hotkeys_checkBox.TabIndex = 10;
            this.hotkeys_checkBox.Text = "HOTKEYS";
            this.hotkeys_checkBox.UseVisualStyleBackColor = true;
            // 
            // x_strengthBox
            // 
            this.x_strengthBox.Location = new System.Drawing.Point(6, 19);
            this.x_strengthBox.MaxLength = 5;
            this.x_strengthBox.Name = "x_strengthBox";
            this.x_strengthBox.Size = new System.Drawing.Size(62, 20);
            this.x_strengthBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(15, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CUSTOM STRENGTH";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.hotkey_button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.x_strengthBox);
            this.panel2.Location = new System.Drawing.Point(258, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 111);
            this.panel2.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label17.Location = new System.Drawing.Point(2, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "NUM7: TOGGLE HOTKEYS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(3, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "MOVEMENT CONTROLS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label12.Location = new System.Drawing.Point(2, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "ARROW KEYS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.Location = new System.Drawing.Point(3, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "NUM2: DOWN";
            // 
            // hotkey_button
            // 
            this.hotkey_button.Location = new System.Drawing.Point(71, 19);
            this.hotkey_button.Name = "hotkey_button";
            this.hotkey_button.Size = new System.Drawing.Size(62, 20);
            this.hotkey_button.TabIndex = 10;
            this.hotkey_button.Text = "SET";
            this.hotkey_button.UseVisualStyleBackColor = true;
            this.hotkey_button.Click += new System.EventHandler(this.hotkey_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(3, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "NUM1: UP";
            // 
            // moveSTRENGTH_trackBar
            // 
            this.moveSTRENGTH_trackBar.Location = new System.Drawing.Point(405, 5);
            this.moveSTRENGTH_trackBar.Maximum = 500000;
            this.moveSTRENGTH_trackBar.Name = "moveSTRENGTH_trackBar";
            this.moveSTRENGTH_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.moveSTRENGTH_trackBar.Size = new System.Drawing.Size(45, 277);
            this.moveSTRENGTH_trackBar.SmallChange = 10000;
            this.moveSTRENGTH_trackBar.TabIndex = 17;
            this.moveSTRENGTH_trackBar.TickFrequency = 10000;
            this.moveSTRENGTH_trackBar.Scroll += new System.EventHandler(this.moveSTRENGTH_trackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(261, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 44);
            this.panel3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(-3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "CoordsGrabber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "version 2.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "by NightFyre";
            // 
            // HotkeyTimer
            // 
            this.HotkeyTimer.Enabled = true;
            this.HotkeyTimer.Tick += new System.EventHandler(this.HotkeyTimer_Tick);
            // 
            // trackbar_checkBox
            // 
            this.trackbar_checkBox.AutoSize = true;
            this.trackbar_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.trackbar_checkBox.ForeColor = System.Drawing.Color.Red;
            this.trackbar_checkBox.Location = new System.Drawing.Point(263, 145);
            this.trackbar_checkBox.Name = "trackbar_checkBox";
            this.trackbar_checkBox.Size = new System.Drawing.Size(80, 17);
            this.trackbar_checkBox.TabIndex = 18;
            this.trackbar_checkBox.Text = "TRACKBAR";
            this.trackbar_checkBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(257, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "TRACKBAR STRENGTH";
            // 
            // trackbarValue_label
            // 
            this.trackbarValue_label.AutoSize = true;
            this.trackbarValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarValue_label.ForeColor = System.Drawing.Color.Black;
            this.trackbarValue_label.Location = new System.Drawing.Point(264, 187);
            this.trackbarValue_label.Name = "trackbarValue_label";
            this.trackbarValue_label.Size = new System.Drawing.Size(55, 13);
            this.trackbarValue_label.TabIndex = 28;
            this.trackbarValue_label.Text = "VALUE: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label14.Location = new System.Drawing.Point(259, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "NUM8: INCREASE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label15.Location = new System.Drawing.Point(260, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "NUM5: DECREASE";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 294);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trackbarValue_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackbar_checkBox);
            this.Controls.Add(this.moveSTRENGTH_trackBar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.summary_textBox);
            this.Controls.Add(this.output_button);
            this.Controls.Add(this.active_Panel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hotkeys_checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NightCity::dev";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSTRENGTH_trackBar)).EndInit();
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
        private System.Windows.Forms.TextBox x_strengthBox;
        private System.Windows.Forms.CheckBox hotkeys_checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hotkey_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer HotkeyTimer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar moveSTRENGTH_trackBar;
        private System.Windows.Forms.CheckBox trackbar_checkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label trackbarValue_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

