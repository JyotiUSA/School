//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace School
//{
//    class SportsDepartment
//    {
//        public static int sportMarks = 5;

//        public static int sportParticipantMarks = 5;

//        private int winnerSportMarks;

//        public int marks;

//        public int sportMarks;

//        public int WinnerSportMarks
//        {
//            get { return winnerSportMarks; }
//            set { winnerSportMarks = value; }
//        }

//        public double calculateSportsMarks(int marks)
//        {
//            sportMarks = marks + sportParticipantMarks;
//            Console.WriteLine($"\nAfter adding\t{sportParticipantMarks}\tas a standard Sport's participant marks, your total marks are:\t{sportMarks}");
//            return sportMarks;
//        }

//        public int calculateSportsMarksForWinners(ref int winnerSportsMarks)
//        {
//            winnerSportsMarks = 50;
//            sportMarks = 0;
//            WinnerSportMarks = winnerSportMarks + winnerSportsMarks;
//            Console.WriteLine($"\nAs your a winner, you will get extra 50 marks of sports. Now your total marks will be\t{marks}\t");
//            return marks;
//        }
//    }
//}
