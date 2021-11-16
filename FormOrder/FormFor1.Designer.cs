
namespace FormOrder
{
    partial class FormFor1
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
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSolve1 = new System.Windows.Forms.Button();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(104, 166);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(53, 29);
            this.textBoxRes.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Відповідь:";
            // 
            // buttonSolve1
            // 
            this.buttonSolve1.Location = new System.Drawing.Point(124, 120);
            this.buttonSolve1.Name = "buttonSolve1";
            this.buttonSolve1.Size = new System.Drawing.Size(75, 26);
            this.buttonSolve1.TabIndex = 7;
            this.buttonSolve1.Text = "Solve";
            this.buttonSolve1.UseVisualStyleBackColor = true;
            this.buttonSolve1.Click += new System.EventHandler(this.buttonSolve1_Click);
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(32, 66);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 29);
            this.textBoxN1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть числа від якого до якого рахувати";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(186, 66);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 29);
            this.textBoxN2.TabIndex = 10;
            // 
            // FormFor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 326);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSolve1);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormFor1";
            this.Text = "FormFor1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSolve1;
        public System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxN2;
    }
}