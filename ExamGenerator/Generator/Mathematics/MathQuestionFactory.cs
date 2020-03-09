using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public static class MathQuestionFactory
    {
        public static MathQuestion Create()
        {
            MathQuestion question = new MathQuestion();

            int a = Utils.RandomInt(1, 10);
            int b = Utils.RandomInt(1, 10);

            question.text = $"{a}+{b}=";
            question.answer = (a + b).ToString();

            return question;
        }
    }
}
