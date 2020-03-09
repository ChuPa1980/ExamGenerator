namespace ExamGenerator
{
    partial class MainForm
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
            this.btnMathExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMathExam
            // 
            this.btnMathExam.Location = new System.Drawing.Point(29, 31);
            this.btnMathExam.Name = "btnMathExam";
            this.btnMathExam.Size = new System.Drawing.Size(75, 23);
            this.btnMathExam.TabIndex = 0;
            this.btnMathExam.Text = "Math";
            this.btnMathExam.UseVisualStyleBackColor = true;
            this.btnMathExam.Click += new System.EventHandler(this.btnMathExam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMathExam);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMathExam;
    }
}