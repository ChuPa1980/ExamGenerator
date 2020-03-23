using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator
{
    public interface IExamSettings
    {
        int GetNumOfQuestions();

        int GetMaxOperand();

        string GetExamName();
    }
}
