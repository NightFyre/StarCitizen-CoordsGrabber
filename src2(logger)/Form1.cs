using System;
using System.Drawing;
using System.Windows.Forms;
using helpers.StarCitizen_DevTool;
using Memory;

namespace StarCitizen_DevTool
{
    public partial class Main : Form
    {
        bool GameRunning;
        Mem m = new Mem();

        Double varX;
        Double varY;
        Double varZ;


        public static class Offsets
        {
            ///Patch 3.14 (notes)
            //public const string X = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1C0";
            //public const string Y = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1C8";
            //public const string Z = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1D0";

            public const string X = "0x0CEA9928,0x150,0xB0,0x268,0x0,0x1C0";
            public const string Y = "0x0CEA9928,0x150,0xB0,0x268,0x0,0x1C8";
            public const string Z = "0x0CEA9928,0x150,0xB0,0x268,0x0,0x1D0";
        }

        public Main()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tele_button_Click(object sender, EventArgs e)
        {
            if (!GameRunning) return;
            string writeX = X_textBox.Text;
            string writeY = Y_textBox.Text;
            string writeZ = Z_textBox.Text;
            m.WriteMemory($"StarCitizen.exe+{Offsets.X}", "double", writeX);
            m.WriteMemory($"StarCitizen.exe+{Offsets.Y}", "double", writeY);
            m.WriteMemory($"StarCitizen.exe+{Offsets.Z}", "double", writeZ);
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            if (!GameRunning) return;
            if (summary_textBox.Text == null)
            {
                MessageBox.Show("INCLUDE A SUMMARY");
                return;
            }
            richTextBox.Text = "//" + summary_textBox.Text + "\n"
                    + "coords[0] = " + X_textBox.Text + ";" + "\n"
                    + "coords[1] = " + Y_textBox.Text + ";" + "\n"
                    + "coords[2] = " + Z_textBox.Text + ";";
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("StarCitizen");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                GameRunning = true;
                active_Panel.BackColor = Color.FromArgb(0, 169, 0);
                return;
            }
            GameRunning = false;
            active_Panel.BackColor = Color.FromArgb(169, 0, 0);
        }

        //Set Hotkey NoClip Movement Strength
        private void hotkey_button_Click(object sender, EventArgs e)
        {
            varX = Double.Parse(x_strengthBox.Text);
            varY = Double.Parse(y_strengthBox.Text);
            varZ = Double.Parse(z_strengthBox.Text);
        }

        private void HotkeyTimer_Tick(object sender, EventArgs e)
        {
            if (func.GetAsyncKeyState(func.VK_NUMPAD7) != 0) hotkeys_checkBox.Checked = !hotkeys_checkBox.Checked;
            if (!GameRunning) return;
            if (!hotkeys_checkBox.Checked) return;
            if (varX == 0 || varY == 0 || varZ == 0) return;

            
            // ASCEND
            if (func.GetAsyncKeyState(func.VK_NUMPAD1) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.Z}");
                Double newVALUE = origin + varZ;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.Z}", "double", parseVALUE);
            }
            
            // DESCEND
            if (func.GetAsyncKeyState(func.VK_NUMPAD0) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.Z}");
                Double newVALUE = origin - varZ;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.Z}", "double", parseVALUE);
            }

            //+
            if (func.GetAsyncKeyState(func.VK_UP) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.X}");
                Double newVALUE = origin + varX;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.X}", "double", parseVALUE);
            }

            //-
            if (func.GetAsyncKeyState(func.VK_DOWN) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.X}");
                Double newVALUE = origin - varX;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.X}", "double", parseVALUE);
            }

            //-
            if (func.GetAsyncKeyState(func.VK_LEFT) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.Y}");
                Double newVALUE = origin - varY;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.Y}", "double", parseVALUE);
            }

            //+
            if (func.GetAsyncKeyState(func.VK_RIGHT) != 0)
            {
                Double origin = m.ReadDouble($"StarCitizen.exe+{Offsets.Y}");
                Double newVALUE = origin + varY;
                string parseVALUE = newVALUE.ToString();
                m.WriteMemory($"StarCitizen.exe+{Offsets.Y}", "double", parseVALUE);
            }
        }
    }
}

