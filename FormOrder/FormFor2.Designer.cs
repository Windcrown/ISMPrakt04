
namespace FormOrder
{
    partial class FormFor2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.buttonSolve1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть число";
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(72, 72);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 29);
            this.textBoxN1.TabIndex = 1;
            this.textBoxN1.TextChanged += new System.EventHandler(this.textBoxN1_TextChanged);
            // 
            // buttonSolve1
            // 
            this.buttonSolve1.Location = new System.Drawing.Point(84, 124);
            this.buttonSolve1.Name = "buttonSolve1";
            this.buttonSolve1.Size = new System.Drawing.Size(75, 26);
            this.buttonSolve1.TabIndex = 2;
            this.buttonSolve1.Text = "Solve";
            this.buttonSolve1.UseVisualStyleBackColor = true;
            this.buttonSolve1.Click += new System.EventHandler(this.buttonSolve1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Відповідь:";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(96, 170);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(53, 29);
            this.textBoxRes.TabIndex = 4;
            // 
            // FormFor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(260, 275);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSolve1);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormFor2";
            this.Text = "Form1num";
            this.Load += new System.EventHandler(this.Form1num_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Button buttonSolve1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxRes;
    }
}