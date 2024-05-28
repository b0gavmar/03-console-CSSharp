using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Models
{
    public class SchoolClass
    {
        public SchoolClass(int year, char classIdentifier,int monthlyClassMoney, int numberOfStudents)
        {
            this.ClassYear = year;
            this.ClassIdentifier = char.ToLower(classIdentifier);
            this.MonthlyClassMoney = monthlyClassMoney;
            this.NumberOfStudents = numberOfStudents;
        }

        public SchoolClass()
        {
            ClassYear = 0;
            ClassIdentifier = 'x';
            MonthlyClassMoney = 0;
            NumberOfStudents = 0;
        }

        public int ClassYear { get; set; }
        public char ClassIdentifier { get; set; }
        public int MonthlyClassMoney { get; set; }
        public int NumberOfStudents { get; set; }


        public override string ToString()
        {
            return $"{ClassYear}.{ClassIdentifier} ({MonthlyClassMoney} Ft)";
        }
    }
}
