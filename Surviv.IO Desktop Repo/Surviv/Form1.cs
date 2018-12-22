using CefSharp;
using CefSharp.WinForms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Surviv
{
    public partial class Form1 : Form
    {
        private readonly ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();

            browser = new ChromiumWebBrowser("surviv.io/")
            {
                Dock = DockStyle.Fill,
            };
            toolStripContainer1.ContentPanel.Controls.Add(browser);

            browser.AddressChanged += OnBrowserAddressChanged;

            toolStripContainer1.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

 
        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            if (!args.Address.Contains("surviv.io/"))
            {
                MessageBox.Show("Sorry but you cannot leave the surviv.io website.\nOther pages wont save!");
                Application.Exit();
            }
            if (args.Address.Contains("#"))
            {
                Clipboard.SetText(args.Address.Split('#')[1]);
                MessageBox.Show("Copied " + args.Address.Split('#')[1]);
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStripContainer1.Size = Screen.PrimaryScreen.WorkingArea.Size;
            toolStripContainer1.Height += 20;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
