﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UI_diplom.FunctionAndGraphicPanels
{
    public partial class SolutionPanel : UserControl
    {
        public delegate void openGraphic();
        public delegate void getSolution(bool isGraphicNeeded);
        public getSolution SolveButtonHandler;
        public openGraphic GraphicButtonHandler;
        public SolutionPanel()
        {
            InitializeComponent();
            ToDefault();
        }
        internal void ToDefault()
        {
            firstVar.Enabled = false;
            secondVar.Enabled = false;
            SolutionFinalButton.Enabled = false;
        }
        internal void PrintTextInLogs(string text)
        {
            if (!string.IsNullOrWhiteSpace(SolutionLogs.Text))
            {
                SolutionLogs.AppendText("\r\n" + text);
            }
            else
            {
                SolutionLogs.AppendText(text);
            }
            SolutionLogs.ScrollToCaret();
        }
        internal void PrintTextInFile(string text)
        {
            using(StreamWriter sw = File.AppendText("logs.txt"))
            {
                sw.WriteLine(text);
            }
        }

        private void SolutionFinalButton_Click(object sender, EventArgs e)
        {
            SolveButtonHandler?.Invoke(SolutionIsGraphBox.Checked);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicButtonHandler?.Invoke();
            GC.Collect();
        }

        private void SolutionIsGraphBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
