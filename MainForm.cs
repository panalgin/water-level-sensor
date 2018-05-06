using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterLevelController
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetComPorts();

            if (this.ComPort_Combo.Items != null)
                this.ComPort_Combo.SelectedIndex = 0;
            if (this.BaudRate_Combo.Items != null)
                this.BaudRate_Combo.SelectedIndex = 2;
        }

        void GetComPorts()
        {
            var ports = SerialPort.GetPortNames();
            ports.All(delegate (string port)
            {
                this.ComPort_Combo.Items.Add(port);

                return true;
            });
        }

        void Assert(string message)
        {
            message = message + Environment.NewLine + this.Output_Box.Text;

            if (message.Length > 1000)
                message = message.Substring(0, 1000);

            this.Output_Box.Text = message;
        }
    }
}
