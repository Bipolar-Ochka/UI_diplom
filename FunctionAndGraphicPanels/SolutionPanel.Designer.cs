namespace UI_diplom.FunctionAndGraphicPanels
{
    partial class SolutionPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolutionLogs = new System.Windows.Forms.RichTextBox();
            this.SolutionFinalButton = new System.Windows.Forms.Button();
            this.SolutionLogLabel = new System.Windows.Forms.Label();
            this.SolutionIsGraphBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstVar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondVar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.firstVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondVar)).BeginInit();
            this.SuspendLayout();
            // 
            // SolutionLogs
            // 
            this.SolutionLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SolutionLogs.Location = new System.Drawing.Point(3, 114);
            this.SolutionLogs.Name = "SolutionLogs";
            this.SolutionLogs.ReadOnly = true;
            this.SolutionLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.SolutionLogs.Size = new System.Drawing.Size(390, 63);
            this.SolutionLogs.TabIndex = 0;
            this.SolutionLogs.Text = "";
            // 
            // SolutionFinalButton
            // 
            this.SolutionFinalButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionFinalButton.Location = new System.Drawing.Point(235, 12);
            this.SolutionFinalButton.Name = "SolutionFinalButton";
            this.SolutionFinalButton.Size = new System.Drawing.Size(148, 32);
            this.SolutionFinalButton.TabIndex = 1;
            this.SolutionFinalButton.Text = "Решение";
            this.SolutionFinalButton.UseVisualStyleBackColor = true;
            this.SolutionFinalButton.Click += new System.EventHandler(this.SolutionFinalButton_Click);
            // 
            // SolutionLogLabel
            // 
            this.SolutionLogLabel.AutoSize = true;
            this.SolutionLogLabel.Location = new System.Drawing.Point(4, 95);
            this.SolutionLogLabel.Name = "SolutionLogLabel";
            this.SolutionLogLabel.Size = new System.Drawing.Size(43, 13);
            this.SolutionLogLabel.TabIndex = 2;
            this.SolutionLogLabel.Text = "Вывод:";
            // 
            // SolutionIsGraphBox
            // 
            this.SolutionIsGraphBox.AutoSize = true;
            this.SolutionIsGraphBox.Location = new System.Drawing.Point(3, 12);
            this.SolutionIsGraphBox.Name = "SolutionIsGraphBox";
            this.SolutionIsGraphBox.Size = new System.Drawing.Size(134, 17);
            this.SolutionIsGraphBox.TabIndex = 3;
            this.SolutionIsGraphBox.Text = "Решение с графиком";
            this.SolutionIsGraphBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Переменные для графика:\r\n";
            // 
            // firstVar
            // 
            this.firstVar.Location = new System.Drawing.Point(27, 62);
            this.firstVar.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstVar.Name = "firstVar";
            this.firstVar.Size = new System.Drawing.Size(35, 20);
            this.firstVar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2)";
            // 
            // secondVar
            // 
            this.secondVar.Location = new System.Drawing.Point(98, 62);
            this.secondVar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.secondVar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondVar.Name = "secondVar";
            this.secondVar.Size = new System.Drawing.Size(35, 20);
            this.secondVar.TabIndex = 11;
            this.secondVar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SolutionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondVar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstVar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SolutionIsGraphBox);
            this.Controls.Add(this.SolutionLogLabel);
            this.Controls.Add(this.SolutionFinalButton);
            this.Controls.Add(this.SolutionLogs);
            this.Name = "SolutionPanel";
            this.Size = new System.Drawing.Size(396, 213);
            ((System.ComponentModel.ISupportInitialize)(this.firstVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondVar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SolutionLogs;
        private System.Windows.Forms.Label SolutionLogLabel;
        internal System.Windows.Forms.CheckBox SolutionIsGraphBox;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.NumericUpDown firstVar;
        internal System.Windows.Forms.NumericUpDown secondVar;
        internal System.Windows.Forms.Button SolutionFinalButton;
    }
}
