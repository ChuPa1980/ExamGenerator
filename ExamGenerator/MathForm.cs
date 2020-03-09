using ExamGenerator.Generator.Mathematics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator
{
    public partial class MathForm : Form
    {
        public MathForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            MathExamGenerator g = new MathExamGenerator();
            MathExamSettings settings = new MathExamSettings();
            settings.examName = "Test Exam";
            settings.numOfQuestions = (int)this.numQuestion.Value;
            var exam = g.Generate(settings);
            resultForm.exam = exam;
            resultForm.Show();
        }
    }
}
