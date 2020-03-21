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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SolutionLogs
            // 
            this.SolutionLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SolutionLogs.Location = new System.Drawing.Point(3, 139);
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
            this.SolutionFinalButton.Location = new System.Drawing.Point(233, 40);
            this.SolutionFinalButton.Name = "SolutionFinalButton";
            this.SolutionFinalButton.Size = new System.Drawing.Size(148, 68);
            this.SolutionFinalButton.TabIndex = 1;
            this.SolutionFinalButton.Text = "Решение";
            this.SolutionFinalButton.UseVisualStyleBackColor = true;
            this.SolutionFinalButton.Click += new System.EventHandler(this.SolutionFinalButton_Click);
            // 
            // SolutionLogLabel
            // 
            this.SolutionLogLabel.AutoSize = true;
            this.SolutionLogLabel.Location = new System.Drawing.Point(4, 120);
            this.SolutionLogLabel.Name = "SolutionLogLabel";
            this.SolutionLogLabel.Size = new System.Drawing.Size(43, 13);
            this.SolutionLogLabel.TabIndex = 2;
            this.SolutionLogLabel.Text = "Вывод:";
            // 
            // SolutionIsGraphBox
            // 
            this.SolutionIsGraphBox.AutoSize = true;
            this.SolutionIsGraphBox.Location = new System.Drawing.Point(3, 40);
            this.SolutionIsGraphBox.Name = "SolutionIsGraphBox";
            this.SolutionIsGraphBox.Size = new System.Drawing.Size(134, 17);
            this.SolutionIsGraphBox.TabIndex = 3;
            this.SolutionIsGraphBox.Text = "Решение с графиком";
            this.SolutionIsGraphBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Перед запуском убедитесь, что все данные введены корректно";
            // 
            // SolutionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SolutionIsGraphBox);
            this.Controls.Add(this.SolutionLogLabel);
            this.Controls.Add(this.SolutionFinalButton);
            this.Controls.Add(this.SolutionLogs);
            this.Name = "SolutionPanel";
            this.Size = new System.Drawing.Size(396, 213);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SolutionLogs;
        private System.Windows.Forms.Button SolutionFinalButton;
        private System.Windows.Forms.Label SolutionLogLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox SolutionIsGraphBox;
    }
}
