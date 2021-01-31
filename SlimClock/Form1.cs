using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    Invoke((Action)(() =>
                    {
                        clockLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    }));
                    await Task.Delay(1000);
                }
            });
        }
    }
}
