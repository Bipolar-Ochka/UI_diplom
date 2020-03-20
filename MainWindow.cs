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
using static MultiDimensionOptimization.MDO;
using MultiDimensionOptimization.MNPDihtomia;
using MultiDimensionOptimization.MNPModificated;

namespace UI_diplom
{
    public partial class MainWindow : Form
    {
        OptionsGraphic optionsGraphic;
        bool isDihtomiaCurrentMethod;
        bool isMethodParams;
        bool isFuncParams;
        bool isNeedGraphic;
        bool isWorkNotStarted;
        MethodSettings currentMethodSettings;
        public MainWindow()
        {
            InitializeComponent();
            ModMetPanel.Visible = false;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = false;
            this.isDihtomiaCurrentMethod = true;
            ResetBools();
            SetupDihtomiaParams();
            SetupModMetParams();
            SetupFunctionParams();
        }
        void ResetBools()
        {
            this.isMethodParams = false;
            this.isFuncParams = false;
            this.isNeedGraphic = false;
            this.isWorkNotStarted = true;
            currentMethodSettings = null;
        }
        void SetupDihtomiaParams()
        {
            DihtomiaPanel.DihtomiaGetParams += DihtomiaPanel_DihtomiaGetParams;
            void DihtomiaPanel_DihtomiaGetParams(double precision, double lipzitsParam, RuleD rule)
            {
                if (isWorkNotStarted)
                {
                    isWorkNotStarted = false;
                    SolutionPanel.PrintTextInLogs("Метод неравномерных покрытий использующий принцип дихтомии");
                    ModMetPanel.Enabled = false;
                }                
                if(currentMethodSettings == null)
                {
                    currentMethodSettings = new DihtomiaParams();
                }
                currentMethodSettings.Precision = precision;
                currentMethodSettings.LipzitsParametr = lipzitsParam;
                ((DihtomiaParams)currentMethodSettings).Rule = rule;
                SolutionPanel.PrintTextInLogs($"Точность метода={precision} \nПараметр константы Липшица={lipzitsParam} \nПравило выбора параллелограмма={rule.ToString()}");
                this.isMethodParams = true;
            }
        }

        void SetupModMetParams()
        {
            ModMetPanel.ModificatedMethodGetParams += ModMetPanel_ModificatedMethodGetParams;
            void ModMetPanel_ModificatedMethodGetParams(double precision, double lipzitsParam, RuleM ruleMainList, RuleM ruleSubList)
            {
                if (isWorkNotStarted)
                {
                    isWorkNotStarted = false;
                    SolutionPanel.PrintTextInLogs("Метод неравномерных покрытий модификация Н.К.Арутюновой");
                    DihtomiaPanel.Enabled = false;
                }
                if (currentMethodSettings == null)
                {
                    currentMethodSettings = new ModificatedParams();
                }
                currentMethodSettings.Precision = precision;
                currentMethodSettings.LipzitsParametr = lipzitsParam;
                ((ModificatedParams)currentMethodSettings).MainRule = ruleMainList;
                ((ModificatedParams)currentMethodSettings).SubRule = ruleSubList;
                SolutionPanel.PrintTextInLogs($"Точность метода={precision} \nПараметр константы Липшица={lipzitsParam} \nПравило добавления в основной список={ruleMainList.ToString()}\nПравило добавления в подсписок={ruleSubList.ToString()}");
                this.isMethodParams = true;
            }
        }

        void SetupFunctionParams()
        {
            FunctionPanel.FunctionGetParams += FunctionPanel_FunctionGetParams;
            void FunctionPanel_FunctionGetParams(OptimizingFunction func, LipzitsFunction lipz, List<double> lowerBound, List<double> upperBound)
            {
                if (isWorkNotStarted)
                {
                    isWorkNotStarted = false;
                    if (isDihtomiaCurrentMethod)
                    {
                        SolutionPanel.PrintTextInLogs("Метод неравномерных покрытий использующий принцип дихтомии");
                        ModMetPanel.Enabled = false;
                    }
                    else
                    {
                        SolutionPanel.PrintTextInLogs("Метод неравномерных покрытий модификация Н.К.Арутюновой");
                        DihtomiaPanel.Enabled = false;
                    }
                }
                if (currentMethodSettings == null)
                {
                    if (isDihtomiaCurrentMethod)
                    {
                        currentMethodSettings = new DihtomiaParams();
                    }
                    else
                    {
                        currentMethodSettings = new ModificatedParams();
                    }
                }
                currentMethodSettings.Function = func;
                currentMethodSettings.Lipzits = lipz;
                currentMethodSettings.LowerPoint = lowerBound;
                currentMethodSettings.UpperPoint = upperBound;
                SolutionPanel.PrintTextInLogs($"Первая точка начальной области-[{string.Join(", ",lowerBound)}] \nВторая-[{string.Join(", ", upperBound)}]");
                this.isFuncParams = true;
            }
        }

        void SetupSolutionParams()
        {
            SolutionPanel.SolveButtonHandler = solution;
            void solution(bool isGraphic)
            {

            }
        }
        void SetupGraphicParams()
        {

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
        #region OPTIONS_METHOD_CHOOSE
        private void мНПНаОсновеДихтомииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DihtomiaPanel.Visible = true;
            ModMetPanel.Visible = false;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = false;
            мНПМодификацияНКАToolStripMenuItem.Enabled = true;
            this.isDihtomiaCurrentMethod = true;
        }

        private void мНПМодификацияНКАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DihtomiaPanel.Visible = false;
            ModMetPanel.Visible = true;
            мНПНаОсновеДихтомииToolStripMenuItem.Enabled = true;
            мНПМодификацияНКАToolStripMenuItem.Enabled = false;
            this.isDihtomiaCurrentMethod = false;
        }
        #endregion


    }
    abstract class MethodSettings
    {
        protected internal List<double> LowerPoint { get; set; }
        protected internal List<double> UpperPoint { get; set; }
        protected internal OptimizingFunction Function { get; set; }

        protected internal LipzitsFunction Lipzits { get; set; }
        protected internal GraphicSettings settings { get; set; }
        protected internal double Precision { get; set; }
        protected internal double LipzitsParametr { get; set; }
        
    }
    class DihtomiaParams: MethodSettings
    {
        internal RuleD Rule { get; set; }
    }
    class ModificatedParams: MethodSettings
    {
        internal RuleM MainRule { get; set; }
        internal RuleM SubRule { get; set; }
    }
}
