using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.API.API_Interfaces
{
    interface IExaminationAPI
    {
        public double Exame(ExaminationModel em);
        public double Exame(ExaminationModel em, bool absentInExame = false);

        //public double Exame(ExaminationModel em);
        public double PercentageCalculation(ExaminationModel em);
        public string ExameResultStatus(ExaminationModel em);
    }
}
