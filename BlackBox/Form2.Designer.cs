namespace BlackBox
{
    partial class FormForAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForAnswer));
            this.panelForAnswer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForAnswer = new System.Windows.Forms.Button();
            this.textBoxForAnswers = new System.Windows.Forms.TextBox();
            this.textBoxForExamples = new System.Windows.Forms.TextBox();
            this.buttonAnotherNumbers = new System.Windows.Forms.Button();
            this.panelForAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForAnswer
            // 
            this.panelForAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelForAnswer.BackgroundImage")));
            this.panelForAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelForAnswer.Controls.Add(this.buttonAnotherNumbers);
            this.panelForAnswer.Controls.Add(this.label2);
            this.panelForAnswer.Controls.Add(this.label1);
            this.panelForAnswer.Controls.Add(this.buttonForAnswer);
            this.panelForAnswer.Controls.Add(this.textBoxForAnswers);
            this.panelForAnswer.Controls.Add(this.textBoxForExamples);
            this.panelForAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForAnswer.Location = new System.Drawing.Point(0, 0);
            this.panelForAnswer.Name = "panelForAnswer";
            this.panelForAnswer.Size = new System.Drawing.Size(584, 331);
            this.panelForAnswer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(437, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(149, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "1";
            // 
            // buttonForAnswer
            // 
            this.buttonForAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForAnswer.ForeColor = System.Drawing.Color.Navy;
            this.buttonForAnswer.Location = new System.Drawing.Point(192, 114);
            this.buttonForAnswer.Name = "buttonForAnswer";
            this.buttonForAnswer.Size = new System.Drawing.Size(186, 109);
            this.buttonForAnswer.TabIndex = 2;
            this.buttonForAnswer.Text = "Введите результат работы черного ящика  для цифр с первой колонки во вторую и наж" +
    "мите на меня.";
            this.buttonForAnswer.UseVisualStyleBackColor = true;
            this.buttonForAnswer.Click += new System.EventHandler(this.buttonForAnswer_Click);
            // 
            // textBoxForAnswers
            // 
            this.textBoxForAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.textBoxForAnswers.Location = new System.Drawing.Point(384, 59);
            this.textBoxForAnswers.Multiline = true;
            this.textBoxForAnswers.Name = "textBoxForAnswers";
            this.textBoxForAnswers.Size = new System.Drawing.Size(90, 240);
            this.textBoxForAnswers.TabIndex = 1;
            // 
            // textBoxForExamples
            // 
            this.textBoxForExamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.textBoxForExamples.Location = new System.Drawing.Point(96, 59);
            this.textBoxForExamples.Multiline = true;
            this.textBoxForExamples.Name = "textBoxForExamples";
            this.textBoxForExamples.ReadOnly = true;
            this.textBoxForExamples.Size = new System.Drawing.Size(90, 240);
            this.textBoxForExamples.TabIndex = 0;
            // 
            // buttonAnotherNumbers
            // 
            this.buttonAnotherNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAnotherNumbers.ForeColor = System.Drawing.Color.Navy;
            this.buttonAnotherNumbers.Location = new System.Drawing.Point(192, 230);
            this.buttonAnotherNumbers.Name = "buttonAnotherNumbers";
            this.buttonAnotherNumbers.Size = new System.Drawing.Size(186, 69);
            this.buttonAnotherNumbers.TabIndex = 5;
            this.buttonAnotherNumbers.Text = "Другие числа";
            this.buttonAnotherNumbers.UseVisualStyleBackColor = true;
            this.buttonAnotherNumbers.Click += new System.EventHandler(this.buttonAnotherNumbers_Click);
            // 
            // FormForAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.panelForAnswer);
            this.Name = "FormForAnswer";
            this.Text = "Ответ";
            this.Load += new System.EventHandler(this.FormForAnswer_Load);
            this.SizeChanged += new System.EventHandler(this.FormForAnswer_SizeChanged);
            this.panelForAnswer.ResumeLayout(false);
            this.panelForAnswer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForAnswer;
        private System.Windows.Forms.TextBox textBoxForExamples;
        private System.Windows.Forms.TextBox textBoxForAnswers;
        private System.Windows.Forms.Button buttonForAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnotherNumbers;
    }
}