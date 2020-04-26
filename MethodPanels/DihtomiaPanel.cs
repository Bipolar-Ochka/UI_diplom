using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiDimensionOptimization.MNPDihtomia;

namespace UI_diplom.MethodPanels
{
    public partial class DihtomiaPanel : UserControl
    {
        public delegate void DihtomiaParamsHandler(double precision, double lipzitsParam, RuleD rule);
        public event DihtomiaParamsHandler DihtomiaGetParams;
        ToolTip tip;
        private bool isMult;
        public DihtomiaPanel()
        {
            InitializeComponent();
            SetupRules();
        }
        void SetupRules()
        {
            var Rules = new[]
            {
                new {rule=RuleD.FIFO, str="Первый из списка"},
                new {rule=RuleD.LIFO, str="Последний из списка"},
                new {rule=RuleD.MINQ, str="С мин. значением миноранты из списка"},
            };
            DihtomiaRuleValue.DataSource = Rules;
            DihtomiaRuleValue.ValueMember = "rule";
            DihtomiaRuleValue.DisplayMember = "str";
            DihtomiaRuleValue.SelectedItem = 0;
            radioButton2.Checked = true;
            isMult = true;
            multLipz.Enabled = true;
            DihtomiaLipzitsValue.Enabled = false;
        }
        internal void ToDefault()
        {
            DihtomiaRuleValue.SelectedItem = 0;
            DihtomiaPrecisionValue.Value = 0.1m;
            DihtomiaLipzitsValue.Value = 0.01m;
            DihtomiaInput.Enabled = true;
            radioButton2.Checked = true;
            isMult = true;
            multLipz.Enabled = true;
            DihtomiaLipzitsValue.Enabled = false;
        }
        void getMethodParams()
        {
            double lipVal = Convert.ToDouble(DihtomiaLipzitsValue.Value);
            if (isMult)
            {
                lipVal = Convert.ToDouble(DihtomiaPrecisionValue.Value) * Convert.ToDouble(multLipz.Value);
            }
            if (Convert.ToDouble(DihtomiaPrecisionValue.Value) > lipVal)
            {
                DihtomiaGetParams?.Invoke(Convert.ToDouble(DihtomiaPrecisionValue.Value), lipVal,(RuleD)DihtomiaRuleValue.SelectedValue);
                DihtomiaInput.Enabled = false;
            }
            else
            {
                if (tip == null)
                {
                    tip = new ToolTip();
                }
                tip.Show("Параметр константы липшица должен быть меньше чем точность",DihtomiaLipzitsValue,DihtomiaLipzitsValue.Size.Width, DihtomiaLipzitsValue.Size.Height, 3000);
            }
        }

        private void DihtomiaInput_Click(object sender, EventArgs e)
        {
            getMethodParams();
            //try
            //{
            //    getMethodParams();  
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    DihtomiaInput.Enabled = true;
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                isMult = true;
                multLipz.Enabled = true;
                DihtomiaLipzitsValue.Enabled = false;
            }
            else
            {
                isMult = false;
                multLipz.Enabled = false;
                DihtomiaLipzitsValue.Enabled = true;
            }
        }
    }
}
