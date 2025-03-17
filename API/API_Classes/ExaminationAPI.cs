using School.API.API_Interfaces;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace School.API.API_Classes
{
    class ExaminationAPI : IExaminationAPI
    {
        public static int concessionMarks = 35;

        //public double Exame(bool absentInExame = false)
        public double Exame(ExaminationModel em, bool absentInExame = false)
        {
            if (absentInExame)
            {
                em.Marks = 0;
                Console.WriteLine("You was absent in exame.");
            }

            return Exame(em);
        }

        //public double Exame(int mathsMarks, int languageMarks, int socialScienceMarks, int scienceMarks)
        public double Exame(ExaminationModel em)
        {
            if ((em.MathsMarks <= 35) && (em.LanguageMarks >= 35 && em.SocialScienceMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.MathsMarks = concessionMarks;
            }
            else if ((em.LanguageMarks <= 35) && (em.MathsMarks >= 35 && em.SocialScienceMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.LanguageMarks = concessionMarks;
            }
            else if ((em.SocialScienceMarks <= 35) && (em.LanguageMarks >= 35 && em.MathsMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.SocialScienceMarks = concessionMarks;
            }
            else if ((em.ScienceMarks <= 35) && (em.LanguageMarks >= 35 && em.SocialScienceMarks >= 35 && em.MathsMarks >= 35))
            {
                em.ScienceMarks = concessionMarks;
            }

            //Total of all subect's marks
            em.Marks = (em.MathsMarks + em.LanguageMarks + em.SocialScienceMarks + em.ScienceMarks);

            return em.Marks; 
        }

        public string ExameResultStatus(ExaminationModel em)
        {

            if ((em.MathsMarks <= 35) && (em.LanguageMarks >= 35 && em.SocialScienceMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.MathsMarks = concessionMarks;
                em.PassOrFali = "Pass with concession";
            }
            else if ((em.LanguageMarks <= 35) && (em.MathsMarks >= 35 && em.SocialScienceMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.LanguageMarks = concessionMarks;
                em.PassOrFali = "Pass with concession";
            }
            else if ((em.SocialScienceMarks <= 35) && (em.LanguageMarks >= 35 && em.MathsMarks >= 35 && em.ScienceMarks >= 35))
            {
                em.SocialScienceMarks = concessionMarks;
                em.PassOrFali = "Pass with concession";
            }
            else if ((em.ScienceMarks <= 35) && (em.LanguageMarks >= 35 && em.SocialScienceMarks >= 35 && em.MathsMarks >= 35))
            {
                em.ScienceMarks = concessionMarks;
                em.PassOrFali = "Pass with concession";
            }
            else if (em.ScienceMarks >= 35 && em.LanguageMarks >= 35 && em.SocialScienceMarks >= 35 && em.MathsMarks >= 35)
            {
                em.PassOrFali = "Pass";
            }
            else
            {
                em.PassOrFali = "Fail";
            }
            
            return em.PassOrFali;
        }

        public double PercentageCalculation(ExaminationModel em)
        {
            em.Percentage = (double)em.Marks * 100 / 400;
            return em.Percentage;
        }
    }
}
