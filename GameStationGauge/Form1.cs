using OpenHardwareMonitor.Hardware;
using System;
using System.Windows.Forms;

namespace GameStationGauge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ocultar Alt+Tab
        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x80;

                return Params;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();

            guna2ShadowForm1.SetShadowForm(this);
            timer1_Tick(null, null);
        }

        private void LoadConfig()
        {
            TopMost = Properties.Settings.Default.AlwaysFrom;

            if (Properties.Settings.Default.UpdateRate != 0)
                timer1.Interval = Properties.Settings.Default.UpdateRate;
            else
                timer1.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TemperatureLabel.Text = "Temperatura:\n" + GetSystemInfo() + "°c";

            #region PseudoMeter
            try
            {
                Double d = Math.Round(Double.Parse(GetSystemInfo()));
                guna2PictureBox1.Location = new System.Drawing.Point(guna2PictureBox1.Location.X, Convert.ToInt32(d));
            }
            catch { }
            #endregion

            Location = new System.Drawing.Point(5, (Screen.PrimaryScreen.WorkingArea.Height - Size.Height));
        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            { computer.Traverse(this); }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        static string GetSystemInfo()
        {
            string output = "";
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer1 = new Computer();
            computer1.Open();
            computer1.CPUEnabled = true;
            computer1.Accept(updateVisitor);
            for (int i = 0; i < computer1.Hardware.Length; i++)
            {
                if (computer1.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer1.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer1.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            output = (computer1.Hardware[i].Sensors[j].Value.ToString());
                    }
                }
            }
            computer1.Close();

            return output;
        }

        #region Save System
        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysFrom = true;
            TopMost = true;
            Properties.Settings.Default.Save();
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysFrom = false;
            TopMost = false;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TranparencyValue = 100;
            Opacity = 100;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TranparencyValue = 75;
            Opacity = 75;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TranparencyValue = 50;
            Opacity = 50;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TranparencyValue = 25;
            Opacity = 25;
            Properties.Settings.Default.Save();
        }

        private void cada1SegundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateRate = 1000;
            timer1.Interval = 1000;
            Properties.Settings.Default.Save();
        }

        private void cada3SegundosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateRate = 3000;
            timer1.Interval = 3000;
            Properties.Settings.Default.Save();
        }

        private void cada5SegundosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateRate = 5000;
            timer1.Interval = 5000;
            Properties.Settings.Default.Save();
        }

        private void cada10SegundosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateRate = 10000;
            timer1.Interval = 10000;
            Properties.Settings.Default.Save();
        }

        private void cada30SegundosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpdateRate = 30000;
            timer1.Interval = 30000;
            Properties.Settings.Default.Save();
        }
        #endregion

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que deseas salir de la aplicación?", "¡Estás saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
    }
}
