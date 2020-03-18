namespace UI_diplom
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мНПНаОсновеДихтомииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мНПМодификацияНКАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииГрафикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormSplitContainer = new System.Windows.Forms.SplitContainer();
            this.subSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormSplitContainer)).BeginInit();
            this.mainFormSplitContainer.Panel2.SuspendLayout();
            this.mainFormSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subSplitContainer)).BeginInit();
            this.subSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.методToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // методToolStripMenuItem
            // 
            this.методToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мНПНаОсновеДихтомииToolStripMenuItem,
            this.мНПМодификацияНКАToolStripMenuItem});
            this.методToolStripMenuItem.Name = "методToolStripMenuItem";
            this.методToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.методToolStripMenuItem.Text = "Метод";
            // 
            // мНПНаОсновеДихтомииToolStripMenuItem
            // 
            this.мНПНаОсновеДихтомииToolStripMenuItem.Name = "мНПНаОсновеДихтомииToolStripMenuItem";
            this.мНПНаОсновеДихтомииToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.мНПНаОсновеДихтомииToolStripMenuItem.Text = "МНП на основе дихтомии";
            // 
            // мНПМодификацияНКАToolStripMenuItem
            // 
            this.мНПМодификацияНКАToolStripMenuItem.Name = "мНПМодификацияНКАToolStripMenuItem";
            this.мНПМодификацияНКАToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.мНПМодификацияНКАToolStripMenuItem.Text = "МНП модификация Н.К.А.";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииГрафикиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // опцииГрафикиToolStripMenuItem
            // 
            this.опцииГрафикиToolStripMenuItem.Name = "опцииГрафикиToolStripMenuItem";
            this.опцииГрафикиToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.опцииГрафикиToolStripMenuItem.Text = "Настройки графики";
            this.опцииГрафикиToolStripMenuItem.Click += new System.EventHandler(this.опцииГрафикиToolStripMenuItem_Click);
            // 
            // mainFormSplitContainer
            // 
            this.mainFormSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainFormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormSplitContainer.IsSplitterFixed = true;
            this.mainFormSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainFormSplitContainer.Name = "mainFormSplitContainer";
            // 
            // mainFormSplitContainer.Panel2
            // 
            this.mainFormSplitContainer.Panel2.Controls.Add(this.subSplitContainer);
            this.mainFormSplitContainer.Size = new System.Drawing.Size(800, 426);
            this.mainFormSplitContainer.SplitterDistance = 400;
            this.mainFormSplitContainer.TabIndex = 1;
            // 
            // subSplitContainer
            // 
            this.subSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subSplitContainer.IsSplitterFixed = true;
            this.subSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.subSplitContainer.Name = "subSplitContainer";
            this.subSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.subSplitContainer.Size = new System.Drawing.Size(396, 426);
            this.subSplitContainer.SplitterDistance = 210;
            this.subSplitContainer.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFormSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Решение задач многомерной оптимизации";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainFormSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormSplitContainer)).EndInit();
            this.mainFormSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subSplitContainer)).EndInit();
            this.subSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииГрафикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мНПНаОсновеДихтомииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мНПМодификацияНКАToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainFormSplitContainer;
        private System.Windows.Forms.SplitContainer subSplitContainer;
    }
}

