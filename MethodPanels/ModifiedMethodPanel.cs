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
        public delegate bool ModificatedMethodParamsHandler(double precision, double lipzitsParam, RuleM ruleMainList, RuleM ruleSubList);
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
            ModMetRuleMainListValue.ValueMember = "rule";
            ModMetRuleMainListValue.DisplayMember = "str";
            ModMetRuleMainListValue.DataSource = Rules;
            ModMetRuleMainListValue.SelectedIndex = 1;
            ModMetRuleSubListValue.ValueMember = "rule";
            ModMetRuleSubListValue.DisplayMember = "str";
            ModMetRuleSubListValue.DataSource = Rules;
            ModMetRuleSubListValue.SelectedIndex = 0;
        }
        internal void getMethodParams()
        {
            if (Convert.ToDouble(ModMetPrecisionValue.Value) > Convert.ToDouble(ModMetLipzitsValue.Value))
            {
                ModificatedMethodGetParams?.Invoke(Convert.ToDouble(ModMetPrecisionValue.Value), Convert.ToDouble(ModMetLipzitsValue.Value), (RuleM)ModMetRuleMainListValue.SelectedItem,(RuleM)ModMetRuleSubListValue.SelectedItem);
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
