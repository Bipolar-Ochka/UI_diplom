using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiDimensionOptimization.MNPModificated;

namespace UI_diplom.MethodPanels
{
    public partial class ModifiedMethodPanel : UserControl
    {
        public delegate void ModificatedMethodParamsHandler(double precision, double lipzitsParam, RuleM ruleMainList, RuleM ruleSubList);
        public event ModificatedMethodParamsHandler ModificatedMethodGetParams;
        ToolTip tip;
        public ModifiedMethodPanel()
        {
            InitializeComponent();
            SetupRules();
        }
        void SetupRules()
        {
            var Rules = new[]
            {
                new {rule = RuleM.FIFO, str="Добавление в начало"},
                new {rule = RuleM.LIFO, str="Добавление в конец"},
            };
            var Rules2 = new[]
            {
                new {rule = RuleM.FIFO, str="Добавление в начало"},
                new {rule = RuleM.LIFO, str="Добавление в конец"},
            };
            ModMetRuleMainListValue.ValueMember = "rule";
            ModMetRuleMainListValue.DisplayMember = "str";
            ModMetRuleMainListValue.DataSource = Rules;
            ModMetRuleMainListValue.SelectedIndex = 0;
            ModMetRuleSubListValue.ValueMember = "rule";
            ModMetRuleSubListValue.DisplayMember = "str";
            ModMetRuleSubListValue.DataSource = Rules2;
            ModMetRuleSubListValue.SelectedIndex = 0;
        }
         void getMethodParams()
        {
            if (Convert.ToDouble(ModMetPrecisionValue.Value) > Convert.ToDouble(ModMetLipzitsValue.Value))
            {
                ModificatedMethodGetParams?.Invoke(Convert.ToDouble(ModMetPrecisionValue.Value), Convert.ToDouble(ModMetLipzitsValue.Value), (RuleM)ModMetRuleMainListValue.SelectedValue,(RuleM)ModMetRuleSubListValue.SelectedValue);
                ModMetInput.Enabled = false;
            }
            else
            {
                if (tip == null)
                {
                    tip = new ToolTip();
                }
                tip.Show("Параметр константы липшица должен быть меньше чем точность", ModMetLipzitsValue, ModMetLipzitsValue.Size.Width, ModMetLipzitsValue.Size.Height, 3000);
            }
        }
        internal void ToDefault()
        {
            ModMetPrecisionValue.Value = 0.1m;
            ModMetLipzitsValue.Value = 0.01m;
            ModMetRuleMainListValue.SelectedIndex = 1;
            ModMetRuleSubListValue.SelectedIndex = 0;
            ModMetInput.Enabled = true;
        }

        private void ModMetInput_Click(object sender, EventArgs e)
        {
            try
            {
                getMethodParams();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ModMetInput.Enabled = true;
            }
        }
    }
}
