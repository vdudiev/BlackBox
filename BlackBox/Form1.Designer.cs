namespace BlackBox
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelForClues = new System.Windows.Forms.Label();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonToAnswer = new System.Windows.Forms.Button();
            this.toolStripButtonLvl1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLvl10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForAnswer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLevels = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.toolStripLevels.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.labelForClues);
            this.panelMain.Controls.Add(this.buttonRemoveAll);
            this.panelMain.Controls.Add(this.textBoxInput);
            this.panelMain.Controls.Add(this.textBoxOutput);
            this.panelMain.Controls.Add(this.buttonToAnswer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(834, 448);
            this.panelMain.TabIndex = 5;
            // 
            // labelForClues
            // 
            this.labelForClues.BackColor = System.Drawing.Color.Transparent;
            this.labelForClues.ForeColor = System.Drawing.Color.Transparent;
            this.labelForClues.Location = new System.Drawing.Point(731, 339);
            this.labelForClues.Name = "labelForClues";
            this.labelForClues.Size = new System.Drawing.Size(100, 100);
            this.labelForClues.TabIndex = 9;
            this.labelForClues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelForClues_MouseDoubleClick);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.BackColor = System.Drawing.Color.Gray;
            this.buttonRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemoveAll.Location = new System.Drawing.Point(330, 347);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(150, 57);
            this.buttonRemoveAll.TabIndex = 8;
            this.buttonRemoveAll.Text = "Очистить все";
            this.buttonRemoveAll.UseVisualStyleBackColor = false;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.ForeColor = System.Drawing.Color.Black;
            this.textBoxInput.Location = new System.Drawing.Point(234, 150);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(90, 190);
            this.textBoxInput.TabIndex = 6;
            this.textBoxInput.Text = "\r\n";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.Location = new System.Drawing.Point(486, 150);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(90, 190);
            this.textBoxOutput.TabIndex = 7;
            // 
            // buttonToAnswer
            // 
            this.buttonToAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonToAnswer.BackgroundImage")));
            this.buttonToAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToAnswer.CausesValidation = false;
            this.buttonToAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToAnswer.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonToAnswer.Location = new System.Drawing.Point(330, 150);
            this.buttonToAnswer.Name = "buttonToAnswer";
            this.buttonToAnswer.Size = new System.Drawing.Size(150, 190);
            this.buttonToAnswer.TabIndex = 0;
            this.buttonToAnswer.Text = "Считать";
            this.buttonToAnswer.UseVisualStyleBackColor = true;
            this.buttonToAnswer.Click += new System.EventHandler(this.buttonToAnswer_Click);
            // 
            // toolStripButtonLvl1
            // 
            this.toolStripButtonLvl1.AutoSize = false;
            this.toolStripButtonLvl1.Checked = true;
            this.toolStripButtonLvl1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonLvl1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl1.Image")));
            this.toolStripButtonLvl1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl1.Name = "toolStripButtonLvl1";
            this.toolStripButtonLvl1.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl1.Text = "1";
            this.toolStripButtonLvl1.Click += new System.EventHandler(this.toolStripButtonLvl1_Click);
            // 
            // toolStripButtonLvl2
            // 
            this.toolStripButtonLvl2.AutoSize = false;
            this.toolStripButtonLvl2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl2.Enabled = false;
            this.toolStripButtonLvl2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl2.Image")));
            this.toolStripButtonLvl2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl2.Name = "toolStripButtonLvl2";
            this.toolStripButtonLvl2.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl2.Text = "2";
            this.toolStripButtonLvl2.Click += new System.EventHandler(this.toolStripButtonLvl2_Click);
            // 
            // toolStripButtonLvl3
            // 
            this.toolStripButtonLvl3.AutoSize = false;
            this.toolStripButtonLvl3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl3.Enabled = false;
            this.toolStripButtonLvl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl3.Image")));
            this.toolStripButtonLvl3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl3.Name = "toolStripButtonLvl3";
            this.toolStripButtonLvl3.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl3.Text = "3";
            this.toolStripButtonLvl3.Click += new System.EventHandler(this.toolStripButtonLvl3_Click);
            // 
            // toolStripButtonLvl4
            // 
            this.toolStripButtonLvl4.AutoSize = false;
            this.toolStripButtonLvl4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl4.Enabled = false;
            this.toolStripButtonLvl4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl4.Image")));
            this.toolStripButtonLvl4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl4.Name = "toolStripButtonLvl4";
            this.toolStripButtonLvl4.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl4.Text = "4";
            this.toolStripButtonLvl4.Click += new System.EventHandler(this.toolStripButtonLvl4_Click);
            // 
            // toolStripButtonLvl5
            // 
            this.toolStripButtonLvl5.AutoSize = false;
            this.toolStripButtonLvl5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl5.Enabled = false;
            this.toolStripButtonLvl5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl5.Image")));
            this.toolStripButtonLvl5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl5.Name = "toolStripButtonLvl5";
            this.toolStripButtonLvl5.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl5.Text = "5";
            this.toolStripButtonLvl5.Click += new System.EventHandler(this.toolStripButtonLvl5_Click);
            // 
            // toolStripButtonLvl6
            // 
            this.toolStripButtonLvl6.AutoSize = false;
            this.toolStripButtonLvl6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl6.Enabled = false;
            this.toolStripButtonLvl6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl6.Image")));
            this.toolStripButtonLvl6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl6.Name = "toolStripButtonLvl6";
            this.toolStripButtonLvl6.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl6.Text = "6";
            this.toolStripButtonLvl6.Click += new System.EventHandler(this.toolStripButtonLvl6_Click);
            // 
            // toolStripButtonLvl7
            // 
            this.toolStripButtonLvl7.AutoSize = false;
            this.toolStripButtonLvl7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl7.Enabled = false;
            this.toolStripButtonLvl7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl7.Image")));
            this.toolStripButtonLvl7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl7.Name = "toolStripButtonLvl7";
            this.toolStripButtonLvl7.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl7.Text = "7";
            this.toolStripButtonLvl7.Click += new System.EventHandler(this.toolStripButtonLvl7_Click);
            // 
            // toolStripButtonLvl8
            // 
            this.toolStripButtonLvl8.AutoSize = false;
            this.toolStripButtonLvl8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl8.Enabled = false;
            this.toolStripButtonLvl8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl8.Image")));
            this.toolStripButtonLvl8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl8.Name = "toolStripButtonLvl8";
            this.toolStripButtonLvl8.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl8.Text = "8";
            this.toolStripButtonLvl8.Click += new System.EventHandler(this.toolStripButtonLvl8_Click);
            // 
            // toolStripButtonLvl9
            // 
            this.toolStripButtonLvl9.AutoSize = false;
            this.toolStripButtonLvl9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl9.Enabled = false;
            this.toolStripButtonLvl9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl9.Image")));
            this.toolStripButtonLvl9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl9.Name = "toolStripButtonLvl9";
            this.toolStripButtonLvl9.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl9.Text = "9";
            this.toolStripButtonLvl9.Click += new System.EventHandler(this.toolStripButtonLvl9_Click);
            // 
            // toolStripButtonLvl10
            // 
            this.toolStripButtonLvl10.AutoSize = false;
            this.toolStripButtonLvl10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLvl10.Enabled = false;
            this.toolStripButtonLvl10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLvl10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLvl10.Image")));
            this.toolStripButtonLvl10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLvl10.Name = "toolStripButtonLvl10";
            this.toolStripButtonLvl10.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonLvl10.Text = "10";
            this.toolStripButtonLvl10.Click += new System.EventHandler(this.toolStripButtonLvl10_Click);
            // 
            // toolStripButtonForAnswer
            // 
            this.toolStripButtonForAnswer.AutoSize = false;
            this.toolStripButtonForAnswer.BackColor = System.Drawing.Color.Aqua;
            this.toolStripButtonForAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonForAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonForAnswer.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButtonForAnswer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForAnswer.Image")));
            this.toolStripButtonForAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForAnswer.Name = "toolStripButtonForAnswer";
            this.toolStripButtonForAnswer.Size = new System.Drawing.Size(50, 50);
            this.toolStripButtonForAnswer.Text = "!";
            this.toolStripButtonForAnswer.ToolTipText = "Ответить";
            this.toolStripButtonForAnswer.Click += new System.EventHandler(this.toolStripButtonForAnswer_Click);
            // 
            // toolStripLevels
            // 
            this.toolStripLevels.AutoSize = false;
            this.toolStripLevels.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripLevels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLvl1,
            this.toolStripButtonLvl2,
            this.toolStripButtonLvl3,
            this.toolStripButtonLvl4,
            this.toolStripButtonLvl5,
            this.toolStripButtonLvl6,
            this.toolStripButtonLvl7,
            this.toolStripButtonLvl8,
            this.toolStripButtonLvl9,
            this.toolStripButtonLvl10,
            this.toolStripButtonForAnswer});
            this.toolStripLevels.Location = new System.Drawing.Point(0, 24);
            this.toolStripLevels.Name = "toolStripLevels";
            this.toolStripLevels.Size = new System.Drawing.Size(834, 50);
            this.toolStripLevels.Stretch = true;
            this.toolStripLevels.TabIndex = 2;
            this.toolStripLevels.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьЗановоToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.начатьЗановоToolStripMenuItem.Text = "Начать заново";
            this.начатьЗановоToolStripMenuItem.Click += new System.EventHandler(this.начатьЗановоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 522);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStripLevels);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "BlackBox";
            this.SizeChanged += new System.EventHandler(this.mainForm_SizeChanged);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.toolStripLevels.ResumeLayout(false);
            this.toolStripLevels.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonToAnswer;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl2;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl3;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl4;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl5;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl6;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl7;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl8;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl9;
        private System.Windows.Forms.ToolStripButton toolStripButtonLvl10;
        private System.Windows.Forms.ToolStripButton toolStripButtonForAnswer;
        private System.Windows.Forms.ToolStrip toolStripLevels;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Label labelForClues;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
    }
}

