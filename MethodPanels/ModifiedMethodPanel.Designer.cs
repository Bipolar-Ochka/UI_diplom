namespace UI_diplom.MethodPanels
{
    partial class ModifiedMethodPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModifiedMethodTitle = new System.Windows.Forms.Label();
            this.ModMetLipzitsValue = new System.Windows.Forms.NumericUpDown();
            this.ModMetLipzits = new System.Windows.Forms.Label();
            this.ModMetPrecisionValue = new System.Windows.Forms.NumericUpDown();
            this.ModMetPrecision = new System.Windows.Forms.Label();
            this.ModMetRuleMainListValue = new System.Windows.Forms.ComboBox();
            this.ModMetRuleMainList = new System.Windows.Forms.Label();
            this.ModMetRuleSubListValue = new System.Windows.Forms.ComboBox();
            this.ModMetRuleSubList = new System.Windows.Forms.Label();
            this.ModMetInput = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.multLipz = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ModMetLipzitsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModMetPrecisionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multLipz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "модификация Арутюновой Н.К.";
            // 
            // ModifiedMethodTitle
            // 
            this.ModifiedMethodTitle.AutoSize = true;
            this.ModifiedMethodTitle.Font = new System.Drawing.Font("Times New Roman", 18.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifiedMethodTitle.Location = new System.Drawing.Point(3, 9);
            this.ModifiedMethodTitle.Name = "ModifiedMethodTitle";
            this.ModifiedMethodTitle.Size = new System.Drawing.Size(400, 30);
            this.ModifiedMethodTitle.TabIndex = 2;
            this.ModifiedMethodTitle.Text = "Метод неравномерных покрытий ";
            // 
            // ModMetLipzitsValue
            // 
            this.ModMetLipzitsValue.DecimalPlaces = 10;
            this.ModMetLipzitsValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ModMetLipzitsValue.Location = new System.Drawing.Point(280, 144);
            this.ModMetLipzitsValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ModMetLipzitsValue.Name = "ModMetLipzitsValue";
            this.ModMetLipzitsValue.Size = new System.Drawing.Size(105, 20);
            this.ModMetLipzitsValue.TabIndex = 9;
            this.ModMetLipzitsValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // ModMetLipzits
            // 
            this.ModMetLipzits.AutoSize = true;
            this.ModMetLipzits.Location = new System.Drawing.Point(5, 148);
            this.ModMetLipzits.Name = "ModMetLipzits";
            this.ModMetLipzits.Size = new System.Drawing.Size(164, 13);
            this.ModMetLipzits.TabIndex = 8;
            this.ModMetLipzits.Text = "Параметр константы Липшица";
            // 
            // ModMetPrecisionValue
            // 
            this.ModMetPrecisionValue.DecimalPlaces = 10;
            this.ModMetPrecisionValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.ModMetPrecisionValue.Location = new System.Drawing.Point(265, 106);
            this.ModMetPrecisionValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ModMetPrecisionValue.Name = "ModMetPrecisionValue";
            this.ModMetPrecisionValue.Size = new System.Drawing.Size(120, 20);
            this.ModMetPrecisionValue.TabIndex = 7;
            this.ModMetPrecisionValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // ModMetPrecision
            // 
            this.ModMetPrecision.AutoSize = true;
            this.ModMetPrecision.Location = new System.Drawing.Point(5, 108);
            this.ModMetPrecision.Name = "ModMetPrecision";
            this.ModMetPrecision.Size = new System.Drawing.Size(97, 13);
            this.ModMetPrecision.TabIndex = 6;
            this.ModMetPrecision.Text = "Точность метода:";
            // 
            // ModMetRuleMainListValue
            // 
            this.ModMetRuleMainListValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModMetRuleMainListValue.FormattingEnabled = true;
            this.ModMetRuleMainListValue.Location = new System.Drawing.Point(59, 222);
            this.ModMetRuleMainListValue.Name = "ModMetRuleMainListValue";
            this.ModMetRuleMainListValue.Size = new System.Drawing.Size(277, 21);
            this.ModMetRuleMainListValue.TabIndex = 11;
            // 
            // ModMetRuleMainList
            // 
            this.ModMetRuleMainList.AutoSize = true;
            this.ModMetRuleMainList.Location = new System.Drawing.Point(34, 206);
            this.ModMetRuleMainList.Name = "ModMetRuleMainList";
            this.ModMetRuleMainList.Size = new System.Drawing.Size(330, 13);
            this.ModMetRuleMainList.TabIndex = 10;
            this.ModMetRuleMainList.Text = "Правило добавления подсписка параллелепипедов в основной";
            // 
            // ModMetRuleSubListValue
            // 
            this.ModMetRuleSubListValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModMetRuleSubListValue.FormattingEnabled = true;
            this.ModMetRuleSubListValue.Location = new System.Drawing.Point(59, 275);
            this.ModMetRuleSubListValue.Name = "ModMetRuleSubListValue";
            this.ModMetRuleSubListValue.Size = new System.Drawing.Size(277, 21);
            this.ModMetRuleSubListValue.TabIndex = 13;
            // 
            // ModMetRuleSubList
            // 
            this.ModMetRuleSubList.AutoSize = true;
            this.ModMetRuleSubList.Location = new System.Drawing.Point(63, 259);
            this.ModMetRuleSubList.Name = "ModMetRuleSubList";
            this.ModMetRuleSubList.Size = new System.Drawing.Size(273, 13);
            this.ModMetRuleSubList.TabIndex = 12;
            this.ModMetRuleSubList.Text = "Правило добавления параллелепипеда в подсписок";
            // 
            // ModMetInput
            // 
            this.ModMetInput.Location = new System.Drawing.Point(8, 336);
            this.ModMetInput.Name = "ModMetInput";
            this.ModMetInput.Size = new System.Drawing.Size(377, 56);
            this.ModMetInput.TabIndex = 14;
            this.ModMetInput.Text = "Принять параметры";
            this.ModMetInput.UseVisualStyleBackColor = true;
            this.ModMetInput.Click += new System.EventHandler(this.ModMetInput_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(192, 144);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вручную";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 168);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Множ. точн.";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // multLipz
            // 
            this.multLipz.DecimalPlaces = 10;
            this.multLipz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.multLipz.Location = new System.Drawing.Point(280, 170);
            this.multLipz.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.multLipz.Name = "multLipz";
            this.multLipz.Size = new System.Drawing.Size(105, 20);
            this.multLipz.TabIndex = 17;
            this.multLipz.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // ModifiedMethodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.multLipz);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ModMetInput);
            this.Controls.Add(this.ModMetRuleSubListValue);
            this.Controls.Add(this.ModMetRuleSubList);
            this.Controls.Add(this.ModMetRuleMainListValue);
            this.Controls.Add(this.ModMetRuleMainList);
            this.Controls.Add(this.ModMetLipzitsValue);
            this.Controls.Add(this.ModMetLipzits);
            this.Controls.Add(this.ModMetPrecisionValue);
            this.Controls.Add(this.ModMetPrecision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModifiedMethodTitle);
            this.Name = "ModifiedMethodPanel";
            this.Size = new System.Drawing.Size(400, 426);
            ((System.ComponentModel.ISupportInitialize)(this.ModMetLipzitsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModMetPrecisionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multLipz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModifiedMethodTitle;
        private System.Windows.Forms.NumericUpDown ModMetLipzitsValue;
        private System.Windows.Forms.Label ModMetLipzits;
        private System.Windows.Forms.NumericUpDown ModMetPrecisionValue;
        private System.Windows.Forms.Label ModMetPrecision;
        private System.Windows.Forms.ComboBox ModMetRuleMainListValue;
        private System.Windows.Forms.Label ModMetRuleMainList;
        private System.Windows.Forms.ComboBox ModMetRuleSubListValue;
        private System.Windows.Forms.Label ModMetRuleSubList;
        internal System.Windows.Forms.Button ModMetInput;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown multLipz;
    }
}
