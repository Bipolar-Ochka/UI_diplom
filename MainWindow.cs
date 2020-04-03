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
using GraphicAddon;
using System.Diagnostics;

namespace UI_diplom
{
    public partial class MainWindow : Form
    {
        OptionsGraphic optionsGraphic;
        bool isDihtomiaCurrentMethod;
        bool isMethodParams;
        bool isFuncParams;
        bool isCalculating;
        bool isLogsNeed;
        bool isWorkNotStarted;
        MethodSettings currentMethodSettings;
        GraphicWindow graphic;
        Stopwatch watch;
        uint graphicWindowHeight;
        uint graphicWindowWidth;
        uint graphicWindowFPS;
        bool graphicWindowVsync;
        uint graphicWindowAnit;
        uint rectangleLimit;
        int graphicFirstDimension=0;
        int graphicSecondDimension=1;
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
            SetupDefaultSettingsGraphic();
            Logging();
            SetupReset();
            SetupSolutionParams();
            watch = new Stopwatch();
        }
        void ResetBools()
        {
            this.isMethodParams = false;
            this.isFuncParams = false;
            this.isCalculating = false;
            this.isLogsNeed = true;
            this.isWorkNotStarted = true;
            currentMethodSettings = null;
            graphic = null;
            DihtomiaPanel.Enabled = true;
            ModMetPanel.Enabled = true;
        }
        void SetupDihtomiaParams()
        {
            DihtomiaPanel.DihtomiaGetParams += DihtomiaPanel_DihtomiaGetParams;
            void DihtomiaPanel_DihtomiaGetParams(double precision, double lipzitsParam, RuleD rule)
            {
                if (isWorkNotStarted)
                {
                    isWorkNotStarted = false;
                    Logs("Метод неравномерных покрытий использующий принцип дихтомии");
                    ModMetPanel.Enabled = false;
                }                
                if(currentMethodSettings == null)
                {
                    currentMethodSettings = new DihtomiaParams();
                }
                currentMethodSettings.Precision = precision;
                currentMethodSettings.LipzitsParametr = lipzitsParam;
                ((DihtomiaParams)currentMethodSettings).Rule = rule;
                Logs($"Точность метода={precision} \nПараметр константы Липшица={lipzitsParam} \nПравило выбора параллелограмма={rule.ToString()}");
                this.isMethodParams = true;
                AllReady();
            }
        }
        void AllReady()
        {
            if (isMethodParams && isFuncParams)
            {
                SolutionPanel.SolutionFinalButton.Enabled = true;
                SolutionPanel.firstVar.Enabled = true;
                SolutionPanel.secondVar.Enabled = true;
                int vars = currentMethodSettings.LowerPoint.Count-1;
                SolutionPanel.firstVar.Maximum = vars;
                SolutionPanel.secondVar.Maximum = vars;
                SolutionPanel.firstVar.Value = 0;
                SolutionPanel.secondVar.Value = Math.Min((int)SolutionPanel.firstVar.Value + 1,(int) SolutionPanel.secondVar.Maximum);
            }
        }
        void Logging()
        {
            SolutionPanel.LogsBox.CheckedChanged += LogsBox_CheckedChanged;
            void LogsBox_CheckedChanged(object sender, EventArgs e)
            {
                this.isLogsNeed = ((CheckBox)sender).Checked;
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
                    Logs("Метод неравномерных покрытий модификация Н.К.Арутюновой");
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
                Logs($"Точность метода={precision} \nПараметр константы Липшица={lipzitsParam} \nПравило добавления в основной список={ruleMainList.ToString()}\nПравило добавления в подсписок={ruleSubList.ToString()}");
                this.isMethodParams = true;
                AllReady();
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
                Logs($"Первая точка начальной области-[{string.Join(", ",lowerBound)}] \nВторая-[{string.Join(", ", upperBound)}]");
                this.isFuncParams = true;
                AllReady();
            }
        }       

         void SetupSolutionParams()
        {
            SolutionPanel.SolveButtonHandler = solution;
            void solution(bool isGraphic)
            {
                GraphicSettings settings = null;
                if(isMethodParams && isFuncParams)
                {
                    if (isGraphic)
                    {
                        this.graphicFirstDimension = (int)SolutionPanel.firstVar.Value;
                        this.graphicSecondDimension = ((int)SolutionPanel.secondVar.Value != graphicFirstDimension) ? (int)SolutionPanel.secondVar.Value : ((int)SolutionPanel.secondVar.Value != (int)SolutionPanel.secondVar.Maximum) ? Math.Min(this.graphicFirstDimension + 1, (int)SolutionPanel.secondVar.Maximum): this.graphicFirstDimension-1;
                        graphic = new GraphicWindow(graphicWindowHeight, graphicWindowWidth, graphicWindowFPS, graphicWindowVsync, graphicWindowAnit);
                        graphic.SetRectangleLimit(rectangleLimit);
                        RectangleHandler handler = new RectangleHandler(graphic.GetRectangleFromMethod);
                        settings = new GraphicSettings(handler,graphicFirstDimension,graphicSecondDimension);
                        graphic?.Window.SetActive(false);
                    }
                    if (isDihtomiaCurrentMethod)
                    {
                        var method = currentMethodSettings as DihtomiaParams;
                        double funcMin = 0;
                        int counter = 0;
                        int optimal = 0;
                        FormTimer.Start();
                        watch.Restart();
                        Task.Run(() =>
                        {                            
                            this.isCalculating = true;
                            var solve = MNPD.Solve(method.Function, method.Lipzits, method.Precision, method.LipzitsParametr, method.LowerPoint, method.UpperPoint, method.Rule, settings);
                            funcMin = solve.FunctionMinimum;
                            counter = solve.counter;
                            optimal = solve.optimal;
                            this.Invoke(new Action(() =>
                            {
                                Logs($"Мин. значение функции={funcMin}\nЧисло итерации={counter}\nИтерация оптимального значения={optimal}");
                                graphic?.ShowWindow();
                                SolutionPanel.button1.Enabled = false;
                                
                            }
                            ));
                            Trace.WriteLine("end of task");
                        }).ContinueWith((taskRes) =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                SolutionPanel.button1.Enabled = true;
                                FormTimer.Stop();
                                watch.Stop();
                            }));
                            //TODO: NORMAL RESET
                            this.isCalculating = false;
                        });
                    }
                    else
                    {
                        var method = currentMethodSettings as ModificatedParams;
                        double funcMin = 0;
                        int counter = 0;
                        int optimal = 0;
                        FormTimer.Start();
                        watch.Restart();
                        Task.Run(() =>
                        {
                            var solve = MNPANK.Solve(method.Function, method.Lipzits, method.Precision, method.LipzitsParametr, method.LowerPoint, method.UpperPoint, method.SubRule, method.MainRule, settings);
                            funcMin = solve.FunctionMinimum;
                            counter = solve.counter;
                            optimal = solve.optimal;
                            this.Invoke(new Action(() =>
                            {
                                Logs($"Мин. значение функции={funcMin}\nЧисло итерации={counter}\nИтерация оптимального значения={optimal}");
                            }
                            ));
                            graphic?.Window.SetActive(true);
                            graphic?.ShowWindow();
                            Trace.WriteLine("end of task");
                        }).ContinueWith((taskRes) =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                SolutionPanel.button1.Enabled = true;
                                FormTimer.Stop();
                                watch.Stop();
                            }));
                        });
                    }
                }
                GC.Collect();
            }
        }
        void Logs(string text)
        {
            SolutionPanel.PrintTextInLogs(text);
            if (isLogsNeed)
            {
                SolutionPanel.PrintTextInFile(text);
            }
        }
        void SetupGraphicParams()
        {
            this.optionsGraphic.ApplySettings += OptionsGraphic_ApplySettings;
            void OptionsGraphic_ApplySettings(int width, int height, int fps, int anitlvl, bool vsync, int maxItemCount)
            {
                this.graphicWindowWidth = (uint)width;
                this.graphicWindowHeight = (uint)height;
                this.graphicWindowFPS = (uint)fps;
                this.graphicWindowAnit = (uint)anitlvl;
                this.graphicWindowVsync = vsync;
                this.rectangleLimit = (uint)maxItemCount;
                graphic?.ChangeWindowSettings(graphicWindowWidth, graphicWindowHeight, graphicWindowAnit, graphicWindowFPS, graphicWindowVsync, (int)rectangleLimit);
            }
        }

        void SetupReset()
        {
            SolutionPanel.GraphicButtonHandler = resetdelegate;
            void resetdelegate()
            {
                ResetBools();
                DihtomiaPanel.ToDefault();
                ModMetPanel.ToDefault();
                FunctionPanel.ToDefault();
                SolutionPanel.ToDefault();
            }
        }

        void SetupDefaultSettingsGraphic()
        {
            this.graphicWindowWidth = 800;
            this.graphicWindowHeight = 600;
            this.graphicWindowFPS = 25;
            this.graphicWindowVsync = true;
            this.graphicWindowAnit = 4;
            this.rectangleLimit = 50000;
        }

        private void опцииГрафикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(optionsGraphic == null || optionsGraphic.IsDisposed)
            {
                optionsGraphic = new OptionsGraphic();
                SetupGraphicParams();
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

        private void FormTimer_Tick(object sender, EventArgs e)
        {
            if (watch.IsRunning)
            {
                this.Text = $"Выполняется {watch.ElapsedMilliseconds} мс";
            }
        }
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
