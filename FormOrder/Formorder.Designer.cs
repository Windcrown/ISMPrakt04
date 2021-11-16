
namespace FormOrder
{
    partial class Formorder
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
            this.labeltext = new System.Windows.Forms.Label();
            this.buttonfor1 = new System.Windows.Forms.Button();
            this.buttonfor2 = new System.Windows.Forms.Button();
            this.buttonfor3 = new System.Windows.Forms.Button();
            this.buttonfor4 = new System.Windows.Forms.Button();
            this.buttonwhile1 = new System.Windows.Forms.Button();
            this.buttonwhile2 = new System.Windows.Forms.Button();
            this.buttonwhile3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.for5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(225, 58);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(158, 21);
            this.labeltext.TabIndex = 0;
            this.labeltext.Text = "Виберіть завдання";
            this.labeltext.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonfor1
            // 
            this.buttonfor1.Location = new System.Drawing.Point(48, 150);
            this.buttonfor1.Name = "buttonfor1";
            this.buttonfor1.Size = new System.Drawing.Size(72, 31);
            this.buttonfor1.TabIndex = 1;
            this.buttonfor1.Text = "For 1";
            this.buttonfor1.UseVisualStyleBackColor = true;
            this.buttonfor1.Click += new System.EventHandler(this.buttonfor1_Click);
            // 
            // buttonfor2
            // 
            this.buttonfor2.Location = new System.Drawing.Point(181, 150);
            this.buttonfor2.Name = "buttonfor2";
            this.buttonfor2.Size = new System.Drawing.Size(76, 31);
            this.buttonfor2.TabIndex = 2;
            this.buttonfor2.Text = "For 2";
            this.buttonfor2.UseVisualStyleBackColor = true;
            this.buttonfor2.Click += new System.EventHandler(this.buttonfor2_Click);
            // 
            // buttonfor3
            // 
            this.buttonfor3.Location = new System.Drawing.Point(321, 150);
            this.buttonfor3.Name = "buttonfor3";
            this.buttonfor3.Size = new System.Drawing.Size(78, 31);
            this.buttonfor3.TabIndex = 3;
            this.buttonfor3.Text = "For 3";
            this.buttonfor3.UseVisualStyleBackColor = true;
            this.buttonfor3.Click += new System.EventHandler(this.buttonfor3_Click);
            // 
            // buttonfor4
            // 
            this.buttonfor4.Location = new System.Drawing.Point(459, 150);
            this.buttonfor4.Name = "buttonfor4";
            this.buttonfor4.Size = new System.Drawing.Size(76, 31);
            this.buttonfor4.TabIndex = 4;
            this.buttonfor4.Text = "For 4";
            this.buttonfor4.UseVisualStyleBackColor = true;
            this.buttonfor4.Click += new System.EventHandler(this.buttonfor4_Click);
            // 
            // buttonwhile1
            // 
            this.buttonwhile1.Location = new System.Drawing.Point(181, 220);
            this.buttonwhile1.Name = "buttonwhile1";
            this.buttonwhile1.Size = new System.Drawing.Size(80, 31);
            this.buttonwhile1.TabIndex = 5;
            this.buttonwhile1.Text = "While 1";
            this.buttonwhile1.UseVisualStyleBackColor = true;
            this.buttonwhile1.Click += new System.EventHandler(this.buttonwhile1_Click);
            // 
            // buttonwhile2
            // 
            this.buttonwhile2.Location = new System.Drawing.Point(322, 220);
            this.buttonwhile2.Name = "buttonwhile2";
            this.buttonwhile2.Size = new System.Drawing.Size(77, 31);
            this.buttonwhile2.TabIndex = 6;
            this.buttonwhile2.Text = "While 2";
            this.buttonwhile2.UseVisualStyleBackColor = true;
            this.buttonwhile2.Click += new System.EventHandler(this.buttonwhile2_Click);
            // 
            // buttonwhile3
            // 
            this.buttonwhile3.Location = new System.Drawing.Point(460, 220);
            this.buttonwhile3.Name = "buttonwhile3";
            this.buttonwhile3.Size = new System.Drawing.Size(75, 31);
            this.buttonwhile3.TabIndex = 7;
            this.buttonwhile3.Text = "While 3";
            this.buttonwhile3.UseVisualStyleBackColor = true;
            this.buttonwhile3.Click += new System.EventHandler(this.buttonwhile3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Петренко Дмитро";
            // 
            // for5
            // 
            this.for5.Location = new System.Drawing.Point(48, 220);
            this.for5.Name = "for5";
            this.for5.Size = new System.Drawing.Size(76, 31);
            this.for5.TabIndex = 9;
            this.for5.Text = "For 5";
            this.for5.UseVisualStyleBackColor = true;
            this.for5.Click += new System.EventHandler(this.for5_Click);
            // 
            // Formorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 352);
            this.Controls.Add(this.for5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonwhile3);
            this.Controls.Add(this.buttonwhile2);
            this.Controls.Add(this.buttonwhile1);
            this.Controls.Add(this.buttonfor4);
            this.Controls.Add(this.buttonfor3);
            this.Controls.Add(this.buttonfor2);
            this.Controls.Add(this.buttonfor1);
            this.Controls.Add(this.labeltext);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Formorder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Button buttonfor1;
        private System.Windows.Forms.Button buttonfor2;
        private System.Windows.Forms.Button buttonfor3;
        private System.Windows.Forms.Button buttonfor4;
        private System.Windows.Forms.Button buttonwhile1;
        private System.Windows.Forms.Button buttonwhile2;
        private System.Windows.Forms.Button buttonwhile3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button for5;
    }
}

