using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_diplom
{
    public partial class MainWindow : Form
    {
        OptionsGraphic optionsGraphic;
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
