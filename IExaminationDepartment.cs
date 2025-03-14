using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface IExaminationDepartment
    {

        double Exame(bool absentInExame = false);
        double Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks);
        double PercentageCalculation();
        string ExameResultStatus();
        string[] getSubjects();
    }
}
