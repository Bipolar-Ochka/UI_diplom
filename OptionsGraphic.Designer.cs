namespace UI_diplom
{
    partial class OptionsGraphic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsGraphicLabelResolution = new System.Windows.Forms.Label();
            this.OptionsGraphicLabelFps = new System.Windows.Forms.Label();
            this.OptionsGraphicLabelAnitialising = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VSyncCheckBox = new System.Windows.Forms.CheckBox();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.FPSComboBox = new System.Windows.Forms.ComboBox();
            this.AnitialisingComboBox = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxItemCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.DefaultSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxItemCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionsGraphicLabelResolution
            // 
            this.OptionsGraphicLabelResolution.AutoSize = true;
            this.OptionsGraphicLabelResolution.Location = new System.Drawing.Point(13, 16);
            this.OptionsGraphicLabelResolution.Name = "OptionsGraphicLabelResolution";
            this.OptionsGraphicLabelResolution.Size = new System.Drawing.Size(97, 13);
            this.OptionsGraphicLabelResolution.TabIndex = 0;
            this.OptionsGraphicLabelResolution.Text = "Разрешение окна";
            // 
            // OptionsGraphicLabelFps
            // 
            this.OptionsGraphicLabelFps.AutoSize = true;
            this.OptionsGraphicLabelFps.Location = new System.Drawing.Point(13, 53);
            this.OptionsGraphicLabelFps.Name = "OptionsGraphicLabelFps";
            this.OptionsGraphicLabelFps.Size = new System.Drawing.Size(112, 13);
            this.OptionsGraphicLabelFps.TabIndex = 1;
            this.OptionsGraphicLabelFps.Text = "Частота обновления";
            // 
            // OptionsGraphicLabelAnitialising
            // 
            this.OptionsGraphicLabelAnitialising.AutoSize = true;
            this.OptionsGraphicLabelAnitialising.Location = new System.Drawing.Point(12, 87);
            this.OptionsGraphicLabelAnitialising.Name = "OptionsGraphicLabelAnitialising";
            this.OptionsGraphicLabelAnitialising.Size = new System.Drawing.Size(121, 13);
            this.OptionsGraphicLabelAnitialising.TabIndex = 2;
            this.OptionsGraphicLabelAnitialising.Text = "Уровень сглаживания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вертикальная синхронизация";
            // 
            // VSyncCheckBox
            // 
            this.VSyncCheckBox.AutoSize = true;
            this.VSyncCheckBox.Checked = true;
            this.VSyncCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VSyncCheckBox.Location = new System.Drawing.Point(209, 123);
            this.VSyncCheckBox.Name = "VSyncCheckBox";
            this.VSyncCheckBox.Size = new System.Drawing.Size(15, 14);
            this.VSyncCheckBox.TabIndex = 4;
            this.VSyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Location = new System.Drawing.Point(143, 13);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ResolutionComboBox.TabIndex = 5;
            // 
            // FPSComboBox
            // 
            this.FPSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPSComboBox.FormattingEnabled = true;
            this.FPSComboBox.Location = new System.Drawing.Point(143, 53);
            this.FPSComboBox.Name = "FPSComboBox";
            this.FPSComboBox.Size = new System.Drawing.Size(121, 21);
            this.FPSComboBox.TabIndex = 6;
            // 
            // AnitialisingComboBox
            // 
            this.AnitialisingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnitialisingComboBox.FormattingEnabled = true;
            this.AnitialisingComboBox.Location = new System.Drawing.Point(143, 87);
            this.AnitialisingComboBox.Name = "AnitialisingComboBox";
            this.AnitialisingComboBox.Size = new System.Drawing.Size(121, 21);
            this.AnitialisingComboBox.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(143, 204);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Сохранить изменения";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Макс. число элементов на экране";
            // 
            // MaxItemCountNumeric
            // 
            this.MaxItemCountNumeric.Location = new System.Drawing.Point(200, 165);
            this.MaxItemCountNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MaxItemCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxItemCountNumeric.Name = "MaxItemCountNumeric";
            this.MaxItemCountNumeric.Size = new System.Drawing.Size(93, 20);
            this.MaxItemCountNumeric.TabIndex = 10;
            this.MaxItemCountNumeric.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // DefaultSettingsButton
            // 
            this.DefaultSettingsButton.Location = new System.Drawing.Point(15, 204);
            this.DefaultSettingsButton.Name = "DefaultSettingsButton";
            this.DefaultSettingsButton.Size = new System.Drawing.Size(118, 23);
            this.DefaultSettingsButton.TabIndex = 11;
            this.DefaultSettingsButton.Text = "По умолчанию";
            this.DefaultSettingsButton.UseVisualStyleBackColor = true;
            this.DefaultSettingsButton.Click += new System.EventHandler(this.DefaultSettingsButton_Click);
            // 
            // OptionsGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 239);
            this.Controls.Add(this.DefaultSettingsButton);
            this.Controls.Add(this.MaxItemCountNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AnitialisingComboBox);
            this.Controls.Add(this.FPSComboBox);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.VSyncCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OptionsGraphicLabelAnitialising);
            this.Controls.Add(this.OptionsGraphicLabelFps);
            this.Controls.Add(this.OptionsGraphicLabelResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsGraphic";
            this.Text = "Настройки графики";
            ((System.ComponentModel.ISupportInitialize)(this.MaxItemCountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OptionsGraphicLabelResolution;
        private System.Windows.Forms.Label OptionsGraphicLabelFps;
        private System.Windows.Forms.Label OptionsGraphicLabelAnitialising;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox VSyncCheckBox;
        private System.Windows.Forms.ComboBox ResolutionComboBox;
        private System.Windows.Forms.ComboBox FPSComboBox;
        private System.Windows.Forms.ComboBox AnitialisingComboBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MaxItemCountNumeric;
        private System.Windows.Forms.Button DefaultSettingsButton;
    }
}