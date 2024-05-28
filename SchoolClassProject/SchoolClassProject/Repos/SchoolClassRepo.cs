using SchoolClassProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Repos
{
    public class SchoolClassRepo
    {
        public List<SchoolClass> SchoolClasses = new List<SchoolClass>
        {
            new SchoolClass
            {
                ClassYear = 10,
                ClassIdentifier = 'c',
                MonthlyClassMoney = 3000,
                NumberOfStudents = 32,
            },
            new SchoolClass
            {
                ClassYear = 11,
                ClassIdentifier = 'a',
                MonthlyClassMoney = 6500,
                NumberOfStudents = 27,
            },
            new SchoolClass
            {
                ClassYear = 12,
                ClassIdentifier = 'b',
                MonthlyClassMoney = 2000,
                NumberOfStudents = 22,
            },
        };

        public SchoolClassRepo(List<SchoolClass> schoolClasses)
        {
            SchoolClasses = schoolClasses;
        }

        public SchoolClassRepo()
        {
            SchoolClasses = new List<SchoolClass>();
        }

        public List<SchoolClass> FindAll()
        {
            return SchoolClasses;
        }

        public void AddClass(SchoolClass class1)
        {
            SchoolClasses.Add(class1);
        }

        public string MostPaidSchoolClass()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            else
            {
                int equals = 0;
                SchoolClass maximum = SchoolClasses.First();
                List<SchoolClass> maximumList = new List<SchoolClass>();
                foreach (SchoolClass schoolClass in SchoolClasses) 
                {
                    if (maximum.MonthlyClassMoney == schoolClass.MonthlyClassMoney)
                    {
                        equals++;
                        maximumList.Add(schoolClass);
                    }
                    if (maximum.MonthlyClassMoney < schoolClass.MonthlyClassMoney)
                    {
                        maximum = schoolClass;
                        equals = 0;
                        maximumList.Clear();
                    }
                    
                }

                if (equals == SchoolClasses.Count)
                {
                    return $"Az összes osztály ugyan annyit fizet!";
                }
                else if (equals >=1 )
                {
                    string text = "";
                    for(int i=0; i < maximumList.Count;i++)
                    {
                        text += maximumList[i].ClassYear.ToString()+"."+maximumList[i].ClassIdentifier.ToString()+",";
                    }
                    return $"{text}";
                }
                else
                {
                    /*SchoolClasses
                    .OrderByDescending(schoolClass => schoolClass.MonthlyClassMoney * schoolClass.NumberOfStudents);*/

                    return $"{maximum.ClassYear}.{maximum.ClassIdentifier}";

                }


            }
        }
    }
}
