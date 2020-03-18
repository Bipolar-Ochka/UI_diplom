using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI_diplom
{
    public partial class MainWindow : Form
    {
        OptionsGraphic optionsGraphic;
        bool isDihtomiaCurrentMethod;
        public MainWindow()
        {
            InitializeComponent();
            ModMetPanel.Visible = false;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = false;
            isDihtomiaCurrentMethod = true;
        }

        private void опцииГрафикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(optionsGraphic == null || optionsGraphic.IsDisposed)
            {
                optionsGraphic = new OptionsGraphic();
                optionsGraphic.Show();
            }
            else
            {
                optionsGraphic.Focus();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void мНПНаОсновеДихтомииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DihtomiaPanel.Visible = true;
            ModMetPanel.Visible = false;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = false;
            мНПМодификацияНКАToolStripMenuItem.Enabled = true;
            isDihtomiaCurrentMethod = true;
        }

        private void мНПМодификацияНКАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DihtomiaPanel.Visible = false;
            ModMetPanel.Visible = true;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = true;
            мНПМодификацияНКАToolStripMenuItem.Enabled = false;
            isDihtomiaCurrentMethod = false;
        }
    }
}
