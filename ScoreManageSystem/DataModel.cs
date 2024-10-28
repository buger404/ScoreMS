using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManageSystem
{
    internal class DataModel
    {
        public enum AccountType
        {
            Administrator, Teacher, Student
        }
        public enum Sex
        {
            Male, Female
        }

        public static double GetScorePoint(int score)
        {
            return Math.Floor(score switch
            {
                >= 90 => 4.0,
                < 60 => 0.0,
                _ => (score - 60) / 30f * 3.0 + 1.0
            } * 10) / 10.0;
        }
    }
}
