using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Run(Idk);
        }

        public async Task Idk()
        {
            Thread.Sleep(2000);
            if (!Directory.Exists("Files"))
            { MessageBox.Show("Files are missing!"); Application.Exit(); }
            else
            { Process.Start(Directory.GetCurrentDirectory() + "/Files/Surviv.exe"); Application.Exit(); }
        }
    }
}
