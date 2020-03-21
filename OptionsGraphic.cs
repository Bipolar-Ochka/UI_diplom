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
    public partial class OptionsGraphic : Form
    {
        public delegate void GraphicSettingsHandler(int width, int height, int fps, int anitlvl, bool vsync, int maxItemCount);
        public event GraphicSettingsHandler ApplySettings;
        public OptionsGraphic()
        {
            InitializeComponent();
            SetupResolutions();
            SetupFPS();
            SetupAnitialising();
        }
        void setSettings()
        {
            int[] resol = ResolutionComboBox.SelectedValue as int[];
            ApplySettings?.Invoke(resol[0], resol[1], (int)FPSComboBox.SelectedValue, (int)AnitialisingComboBox.SelectedValue, VSyncCheckBox.Checked,Convert.ToInt32(MaxItemCountNumeric.Value));
        }
        
        internal void getDefault()
        {
            ResolutionComboBox.SelectedIndex = 0;
            FPSComboBox.SelectedIndex = 1;
            AnitialisingComboBox.SelectedIndex = 3;
            VSyncCheckBox.Checked = true;
            MaxItemCountNumeric.Value = 20000;
        }

        void SetupResolutions()
        {
            var Resolutions = new[]
            {
                new {resolution = new[]{800,600},str="800x600"},
                new {resolution = new[]{1024,768},str="1024x768"},
                new {resolution = new[]{1280,1024},str="1280x1024"},
            };
            ResolutionComboBox.ValueMember = "resolution";
            ResolutionComboBox.DisplayMember = "str";
            ResolutionComboBox.DataSource = Resolutions;
            ResolutionComboBox.SelectedIndex = 0;
        }
        void SetupFPS()
        {
            var Fps = new[]
            {
                new {frames=15,str="15 кадров в сек." },
                new {frames=25,str="25 кадров в сек." },
                new {frames=30,str="30 кадров в сек." },
                new {frames=60,str="60 кадров в сек." },
            };
            FPSComboBox.ValueMember = "frames";
            FPSComboBox.DisplayMember = "str";
            FPSComboBox.DataSource = Fps;
            FPSComboBox.SelectedIndex = 1;
        }
        void SetupAnitialising()
        {
            var Anit = new[]
            {
                new {lvl=0,str="Нет" },
                new {lvl=1,str="1x" },
                new {lvl=2,str="2x" },
                new {lvl=4,str="4x" },
                new {lvl=8,str="8x" },
            };
            AnitialisingComboBox.ValueMember = "lvl";
            AnitialisingComboBox.DisplayMember = "str";
            AnitialisingComboBox.DataSource = Anit;
            AnitialisingComboBox.SelectedIndex = 3;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            setSettings();
            this.Close();
        }

        private void DefaultSettingsButton_Click(object sender, EventArgs e)
        {
            getDefault();
        }
    }
}
