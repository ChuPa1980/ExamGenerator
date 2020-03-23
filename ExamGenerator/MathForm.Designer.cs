namespace ExamGenerator
{
    partial class MathForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numMaxOperand = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuestion = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxOperand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numMaxOperand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numQuestion);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 133);
            this.panel1.TabIndex = 0;
            // 
            // numMaxOperand
            // 
            this.numMaxOperand.Location = new System.Drawing.Point(127, 44);
            this.numMaxOperand.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMaxOperand.Name = "numMaxOperand";
            this.numMaxOperand.Size = new System.Drawing.Size(120, 20);
            this.numMaxOperand.TabIndex = 6;
            this.numMaxOperand.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Operand";
            // 
            // numQuestion
            // 
            this.numQuestion.Location = new System.Drawing.Point(127, 9);
            this.numQuestion.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numQuestion.Name = "numQuestion";
            this.numQuestion.Size = new System.Drawing.Size(120, 20);
            this.numQuestion.TabIndex = 4;
            this.numQuestion.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Questions";
            // 
            // MathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 155);
            this.Controls.Add(this.panel1);
            this.Name = "MathForm";
            this.Text = "MathExamGenerator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxOperand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQuestion;
        private System.Windows.Forms.NumericUpDown numMaxOperand;
        private System.Windows.Forms.Label label2;
    }
}