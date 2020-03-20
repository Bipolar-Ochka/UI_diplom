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
        public delegate bool DihtomiaParamsHandler(double precision, double lipzitsParam, RuleD rule);
        public event DihtomiaParamsHandler DihtomiaGetParams;
        ToolTip tip;
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
            DihtomiaRuleValue.ValueMember = "rule";
            DihtomiaRuleValue.DisplayMember = "str";
            DihtomiaRuleValue.DataSource = Rules;
            DihtomiaRuleValue.SelectedItem = 0;
        }
        internal void getMethodParams()
        {
            if (Convert.ToDouble(DihtomiaPrecisionValue.Value) > Convert.ToDouble(DihtomiaLipzitsValue.Value))
            {
                DihtomiaGetParams?.Invoke(Convert.ToDouble(DihtomiaPrecisionValue.Value), Convert.ToDouble(DihtomiaLipzitsValue.Value), (RuleD)DihtomiaRuleValue.SelectedItem);
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
            try
            {
                getMethodParams();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DihtomiaInput.Enabled = true;
            }
        }
    }
}
