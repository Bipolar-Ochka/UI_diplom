namespace UI_diplom.MethodPanels
{
    partial class DihtomiaPanel
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
            this.DihtomiaTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DihtomiaPrecision = new System.Windows.Forms.Label();
            this.DihtomiaPrecisionValue = new System.Windows.Forms.NumericUpDown();
            this.DihtomiaLipzits = new System.Windows.Forms.Label();
            this.DihtomiaLipzitsValue = new System.Windows.Forms.NumericUpDown();
            this.DihtomiaRule = new System.Windows.Forms.Label();
            this.DihtomiaRuleValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DihtomiaPrecisionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DihtomiaLipzitsValue)).BeginInit();
            this.SuspendLayout();
            // 
            // DihtomiaTitle
            // 
            this.DihtomiaTitle.AutoSize = true;
            this.DihtomiaTitle.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DihtomiaTitle.Location = new System.Drawing.Point(3, 10);
            this.DihtomiaTitle.Name = "DihtomiaTitle";
            this.DihtomiaTitle.Size = new System.Drawing.Size(400, 30);
            this.DihtomiaTitle.TabIndex = 0;
            this.DihtomiaTitle.Text = "Метод неравномерных покрытий ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "использующий принцип дихтомии";
            // 
            // DihtomiaPrecision
            // 
            this.DihtomiaPrecision.AutoSize = true;
            this.DihtomiaPrecision.Location = new System.Drawing.Point(8, 106);
            this.DihtomiaPrecision.Name = "DihtomiaPrecision";
            this.DihtomiaPrecision.Size = new System.Drawing.Size(97, 13);
            this.DihtomiaPrecision.TabIndex = 2;
            this.DihtomiaPrecision.Text = "Точность метода:";
            // 
            // DihtomiaPrecisionValue
            // 
            this.DihtomiaPrecisionValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.DihtomiaPrecisionValue.Location = new System.Drawing.Point(268, 104);
            this.DihtomiaPrecisionValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DihtomiaPrecisionValue.Name = "DihtomiaPrecisionValue";
            this.DihtomiaPrecisionValue.Size = new System.Drawing.Size(120, 20);
            this.DihtomiaPrecisionValue.TabIndex = 3;
            this.DihtomiaPrecisionValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // DihtomiaLipzits
            // 
            this.DihtomiaLipzits.AutoSize = true;
            this.DihtomiaLipzits.Location = new System.Drawing.Point(8, 141);
            this.DihtomiaLipzits.Name = "DihtomiaLipzits";
            this.DihtomiaLipzits.Size = new System.Drawing.Size(164, 13);
            this.DihtomiaLipzits.TabIndex = 4;
            this.DihtomiaLipzits.Text = "Параметр константы Липшица";
            // 
            // DihtomiaLipzitsValue
            // 
            this.DihtomiaLipzitsValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.DihtomiaLipzitsValue.Location = new System.Drawing.Point(268, 139);
            this.DihtomiaLipzitsValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DihtomiaLipzitsValue.Name = "DihtomiaLipzitsValue";
            this.DihtomiaLipzitsValue.Size = new System.Drawing.Size(120, 20);
            this.DihtomiaLipzitsValue.TabIndex = 5;
            this.DihtomiaLipzitsValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // DihtomiaRule
            // 
            this.DihtomiaRule.AutoSize = true;
            this.DihtomiaRule.Location = new System.Drawing.Point(8, 182);
            this.DihtomiaRule.Name = "DihtomiaRule";
            this.DihtomiaRule.Size = new System.Drawing.Size(280, 13);
            this.DihtomiaRule.TabIndex = 6;
            this.DihtomiaRule.Text = "Правило выбора обрабатываемого параллелепипеда";
            // 
            // DihtomiaRuleValue
            // 
            this.DihtomiaRuleValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DihtomiaRuleValue.FormattingEnabled = true;
            this.DihtomiaRuleValue.Location = new System.Drawing.Point(302, 179);
            this.DihtomiaRuleValue.Name = "DihtomiaRuleValue";
            this.DihtomiaRuleValue.Size = new System.Drawing.Size(86, 21);
            this.DihtomiaRuleValue.TabIndex = 7;
            // 
            // DihtomiaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DihtomiaRuleValue);
            this.Controls.Add(this.DihtomiaRule);
            this.Controls.Add(this.DihtomiaLipzitsValue);
            this.Controls.Add(this.DihtomiaLipzits);
            this.Controls.Add(this.DihtomiaPrecisionValue);
            this.Controls.Add(this.DihtomiaPrecision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DihtomiaTitle);
            this.Name = "DihtomiaPanel";
            this.Size = new System.Drawing.Size(400, 426);
            ((System.ComponentModel.ISupportInitialize)(this.DihtomiaPrecisionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DihtomiaLipzitsValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DihtomiaTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DihtomiaPrecision;
        private System.Windows.Forms.NumericUpDown DihtomiaPrecisionValue;
        private System.Windows.Forms.Label DihtomiaLipzits;
        private System.Windows.Forms.NumericUpDown DihtomiaLipzitsValue;
        private System.Windows.Forms.Label DihtomiaRule;
        private System.Windows.Forms.ComboBox DihtomiaRuleValue;
    }
}
