namespace UI_diplom.FunctionAndGraphicPanels
{
    partial class FunctionPanel
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
            this.FunctionPanelTitle = new System.Windows.Forms.Label();
            this.FunctionListComboBox = new System.Windows.Forms.ComboBox();
            this.VarsCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.FunctionVarsNumberTitle = new System.Windows.Forms.Label();
            this.FunctionLowBoundTitle = new System.Windows.Forms.Label();
            this.FunctionUpBoundTitle = new System.Windows.Forms.Label();
            this.FunctionLowBoundTextBox = new System.Windows.Forms.TextBox();
            this.FunctionUpBoundTextBox = new System.Windows.Forms.TextBox();
            this.FunctionAcceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VarsCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionPanelTitle
            // 
            this.FunctionPanelTitle.AutoSize = true;
            this.FunctionPanelTitle.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionPanelTitle.Location = new System.Drawing.Point(3, 9);
            this.FunctionPanelTitle.Name = "FunctionPanelTitle";
            this.FunctionPanelTitle.Size = new System.Drawing.Size(246, 23);
            this.FunctionPanelTitle.TabIndex = 0;
            this.FunctionPanelTitle.Text = "Оптимизируемая функция";
            // 
            // FunctionListComboBox
            // 
            this.FunctionListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionListComboBox.FormattingEnabled = true;
            this.FunctionListComboBox.Location = new System.Drawing.Point(272, 10);
            this.FunctionListComboBox.Name = "FunctionListComboBox";
            this.FunctionListComboBox.Size = new System.Drawing.Size(109, 21);
            this.FunctionListComboBox.TabIndex = 1;
            // 
            // VarsCountNumeric
            // 
            this.VarsCountNumeric.Location = new System.Drawing.Point(272, 74);
            this.VarsCountNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.VarsCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VarsCountNumeric.Name = "VarsCountNumeric";
            this.VarsCountNumeric.Size = new System.Drawing.Size(109, 20);
            this.VarsCountNumeric.TabIndex = 2;
            this.VarsCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FunctionVarsNumberTitle
            // 
            this.FunctionVarsNumberTitle.AutoSize = true;
            this.FunctionVarsNumberTitle.Location = new System.Drawing.Point(272, 55);
            this.FunctionVarsNumberTitle.Name = "FunctionVarsNumberTitle";
            this.FunctionVarsNumberTitle.Size = new System.Drawing.Size(113, 13);
            this.FunctionVarsNumberTitle.TabIndex = 3;
            this.FunctionVarsNumberTitle.Text = "Кол-во переменных: ";
            // 
            // FunctionLowBoundTitle
            // 
            this.FunctionLowBoundTitle.AutoSize = true;
            this.FunctionLowBoundTitle.Location = new System.Drawing.Point(4, 116);
            this.FunctionLowBoundTitle.Name = "FunctionLowBoundTitle";
            this.FunctionLowBoundTitle.Size = new System.Drawing.Size(150, 13);
            this.FunctionLowBoundTitle.TabIndex = 4;
            this.FunctionLowBoundTitle.Text = "I вершина параллелепипеда";
            // 
            // FunctionUpBoundTitle
            // 
            this.FunctionUpBoundTitle.AutoSize = true;
            this.FunctionUpBoundTitle.Location = new System.Drawing.Point(4, 141);
            this.FunctionUpBoundTitle.Name = "FunctionUpBoundTitle";
            this.FunctionUpBoundTitle.Size = new System.Drawing.Size(150, 13);
            this.FunctionUpBoundTitle.TabIndex = 5;
            this.FunctionUpBoundTitle.Text = "I вершина параллелепипеда";
            // 
            // FunctionLowBoundTextBox
            // 
            this.FunctionLowBoundTextBox.Location = new System.Drawing.Point(161, 116);
            this.FunctionLowBoundTextBox.Name = "FunctionLowBoundTextBox";
            this.FunctionLowBoundTextBox.Size = new System.Drawing.Size(220, 20);
            this.FunctionLowBoundTextBox.TabIndex = 6;
            this.FunctionLowBoundTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FunctionLowBoundTextBox_KeyPress);
            // 
            // FunctionUpBoundTextBox
            // 
            this.FunctionUpBoundTextBox.Location = new System.Drawing.Point(161, 143);
            this.FunctionUpBoundTextBox.Name = "FunctionUpBoundTextBox";
            this.FunctionUpBoundTextBox.Size = new System.Drawing.Size(220, 20);
            this.FunctionUpBoundTextBox.TabIndex = 7;
            this.FunctionUpBoundTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FunctionUpBoundTextBox_KeyPress);
            // 
            // FunctionAcceptButton
            // 
            this.FunctionAcceptButton.Location = new System.Drawing.Point(249, 170);
            this.FunctionAcceptButton.Name = "FunctionAcceptButton";
            this.FunctionAcceptButton.Size = new System.Drawing.Size(132, 33);
            this.FunctionAcceptButton.TabIndex = 8;
            this.FunctionAcceptButton.Text = "Принять данные";
            this.FunctionAcceptButton.UseVisualStyleBackColor = true;
            this.FunctionAcceptButton.Click += new System.EventHandler(this.FunctionAcceptButton_Click);
            // 
            // FunctionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FunctionAcceptButton);
            this.Controls.Add(this.FunctionUpBoundTextBox);
            this.Controls.Add(this.FunctionLowBoundTextBox);
            this.Controls.Add(this.FunctionUpBoundTitle);
            this.Controls.Add(this.FunctionLowBoundTitle);
            this.Controls.Add(this.FunctionVarsNumberTitle);
            this.Controls.Add(this.VarsCountNumeric);
            this.Controls.Add(this.FunctionListComboBox);
            this.Controls.Add(this.FunctionPanelTitle);
            this.Name = "FunctionPanel";
            this.Size = new System.Drawing.Size(396, 213);
            ((System.ComponentModel.ISupportInitialize)(this.VarsCountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionPanelTitle;
        private System.Windows.Forms.ComboBox FunctionListComboBox;
        private System.Windows.Forms.NumericUpDown VarsCountNumeric;
        private System.Windows.Forms.Label FunctionVarsNumberTitle;
        private System.Windows.Forms.Label FunctionLowBoundTitle;
        private System.Windows.Forms.Label FunctionUpBoundTitle;
        private System.Windows.Forms.TextBox FunctionLowBoundTextBox;
        private System.Windows.Forms.TextBox FunctionUpBoundTextBox;
        private System.Windows.Forms.Button FunctionAcceptButton;
    }
}
