
namespace Selenium
{
    partial class Form
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
            this.Btsearch = new System.Windows.Forms.Button();
            this.TBvacancies = new System.Windows.Forms.RichTextBox();
            this.TBotdel = new System.Windows.Forms.TextBox();
            this.TBlanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lkolvac = new System.Windows.Forms.Label();
            this.BTclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btsearch
            // 
            this.Btsearch.Location = new System.Drawing.Point(305, 340);
            this.Btsearch.Name = "Btsearch";
            this.Btsearch.Size = new System.Drawing.Size(185, 75);
            this.Btsearch.TabIndex = 0;
            this.Btsearch.Text = " Найти вакансии";
            this.Btsearch.UseVisualStyleBackColor = true;
            this.Btsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBvacancies
            // 
            this.TBvacancies.Location = new System.Drawing.Point(133, 21);
            this.TBvacancies.Name = "TBvacancies";
            this.TBvacancies.ReadOnly = true;
            this.TBvacancies.Size = new System.Drawing.Size(526, 192);
            this.TBvacancies.TabIndex = 1;
            this.TBvacancies.Text = "";
            // 
            // TBotdel
            // 
            this.TBotdel.Location = new System.Drawing.Point(133, 276);
            this.TBotdel.Name = "TBotdel";
            this.TBotdel.Size = new System.Drawing.Size(151, 20);
            this.TBotdel.TabIndex = 2;
            // 
            // TBlanguage
            // 
            this.TBlanguage.Location = new System.Drawing.Point(508, 276);
            this.TBlanguage.Name = "TBlanguage";
            this.TBlanguage.Size = new System.Drawing.Size(151, 20);
            this.TBlanguage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите отдел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите язык";
            // 
            // Lkolvac
            // 
            this.Lkolvac.AutoSize = true;
            this.Lkolvac.Location = new System.Drawing.Point(13, 21);
            this.Lkolvac.Name = "Lkolvac";
            this.Lkolvac.Size = new System.Drawing.Size(0, 13);
            this.Lkolvac.TabIndex = 6;
            // 
            // BTclear
            // 
            this.BTclear.Location = new System.Drawing.Point(610, 380);
            this.BTclear.Name = "BTclear";
            this.BTclear.Size = new System.Drawing.Size(152, 35);
            this.BTclear.TabIndex = 7;
            this.BTclear.Text = "Очистить поле вакансий";
            this.BTclear.UseVisualStyleBackColor = true;
            this.BTclear.Click += new System.EventHandler(this.BTclear_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTclear);
            this.Controls.Add(this.Lkolvac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBlanguage);
            this.Controls.Add(this.TBotdel);
            this.Controls.Add(this.TBvacancies);
            this.Controls.Add(this.Btsearch);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btsearch;
        private System.Windows.Forms.RichTextBox TBvacancies;
        private System.Windows.Forms.TextBox TBotdel;
        private System.Windows.Forms.TextBox TBlanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lkolvac;
        private System.Windows.Forms.Button BTclear;
    }
}

