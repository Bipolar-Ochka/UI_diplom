using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MultiDimensionOptimization.MDO;

namespace UI_diplom.FunctionAndGraphicPanels
{
    internal class FunctionItem
    {
        internal OptimizingFunction Function { get; private set; }
        
        internal LipzitsFunction LipzitsFunction { get; private set; }
        internal uint MinVarCount { get; private set; }
        internal uint MaxVarCount { get; private set; }
        internal FunctionItem(OptimizingFunction func, LipzitsFunction lip, uint minVarCount, uint maxVarCount)
        {

        }
    }
    public partial class FunctionPanel : UserControl
    {
        public delegate void FunctionParamsHandler(OptimizingFunction func,LipzitsFunction lipz, List<double> lowerBound, List<double> upperBound);
        public event FunctionParamsHandler FunctionGetParams;
        public FunctionPanel()
        {
            InitializeComponent();
        }

        void SetupFunctions()
        {
            OptimizingFunction firstFunc = (List<double> vars) =>
            {
                double pow = vars.Select(x => Math.Abs(x)).Sum();
                return -10 * Math.Exp(-Math.Sqrt(pow / vars.Count));
            };
            OptimizingFunction secondFunc = (List<double> vars) => {
                double pow = vars.Select(x => Math.Abs(x)).Sum();
                double pow2 = vars.Select(x => Math.Cos(2*Math.PI*x)).Sum();
                return -10 * Math.Exp(-Math.Sqrt(pow / vars.Count))-Math.Exp(pow2/vars.Count);
            };
            LipzitsFunction first = (double epsilon) => 25 / epsilon;
            LipzitsFunction second = (double epsilon) => 25 / epsilon - 2 * Math.PI * Math.E;
            
        }

        private void FunctionLowBoundTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !((((TextBox)sender).Text.Length > 0) && !Char.IsWhiteSpace(((TextBox)sender).Text.Last()));
            }
            else
            if (e.KeyChar != 22 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == '-')
                {
                    e.Handled = !(((tb.Text.Length != 0) && Char.IsWhiteSpace(tb.Text.Last())) || (tb.Text.Length == 0));
                }else if (e.KeyChar == ',')
                {
                    e.Handled = !((tb.Text.Length != 0) && Char.IsNumber(tb.Text.Last()));
                }else if (!Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void FunctionUpBoundTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !((((TextBox)sender).Text.Length > 0) && !Char.IsWhiteSpace(((TextBox)sender).Text.Last()));
            }
            else
            if (e.KeyChar != 22 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == '-')
                {
                    e.Handled = !(((tb.Text.Length != 0) && Char.IsWhiteSpace(tb.Text.Last())) || (tb.Text.Length == 0));
                }
                else if (e.KeyChar == ',')
                {
                    e.Handled = !((tb.Text.Length != 0) && Char.IsNumber(tb.Text.Last()));
                }
                else if (!Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        void getFunctionParams()
        {
            int variablesCount = Convert.ToInt32(VarsCountNumeric.Value);
            var rawLowBound = FunctionLowBoundTextBox.Text.Split(' ');
            if(rawLowBound.Length < variablesCount)
            {
                throw new Exception("Не хватает параметров для I-ой вершины параллелепипеда");
            }
            var rawUpBound = FunctionLowBoundTextBox.Text.Split(' ');
            if (rawLowBound.Length < variablesCount)
            {
                throw new Exception("Не хватает параметров для II-ой вершины параллелепипеда");
            }
            double temp=0;
            List<double> lowBound = rawLowBound.Take(variablesCount).Where(item => Double.TryParse(item, out temp)).Select(item => temp).ToList();
            if(lowBound.Count < variablesCount)
            {
                throw new Exception("Не все параметры I-ой вершины были корректны");
            }
            List<double> upBound = rawUpBound.Take(variablesCount).Where(item => Double.TryParse(item, out temp)).Select(item => temp).ToList();
            if (upBound.Count < variablesCount)
            {
                throw new Exception("Не все параметры II-ой вершины были корректны");
            }
        }

        private void FunctionAcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
