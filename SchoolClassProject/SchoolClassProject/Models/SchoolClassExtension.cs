using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Models
{
    public static class SchoolClassExtension
    {

        public static void WhoPaysMoreAndByWhatAmount(this SchoolClass class1, SchoolClass class2)
        {
            if(class1.MonthlyClassMoney > class2.MonthlyClassMoney)
            {
                Console.WriteLine($"{class1.ClassYear}.{class1.ClassIdentifier} osztály diákjai havonta {class1.MonthlyClassMoney - class2.MonthlyClassMoney} forinttal többet fizetnek osztálypénzbe, mint {class2.ClassYear}.{class2.ClassIdentifier} osztály tanulói.");
            }
            else if (class1.MonthlyClassMoney < class2.MonthlyClassMoney)
            {
                Console.WriteLine($"{class2.ClassYear}.{class2.ClassIdentifier} osztály diákjai havonta {class2.MonthlyClassMoney - class1.MonthlyClassMoney} forinttal többet fizetnek osztálypénzbe, mint {class1.ClassYear}.{class1.ClassIdentifier} osztály tanulói.");
            }
            else
            {
                Console.WriteLine($"{class1.ClassYear}.{class1.ClassIdentifier} és {class2.ClassYear}.{class2.ClassIdentifier} osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.");
            }
        }

        public static void TenMonthsClassMoneyWithThirtyStudents(this SchoolClass thisClass)
        {
            
            Console.WriteLine($"{thisClass.ClassYear}.{thisClass.ClassIdentifier} osztály 10 hónap alatt összegyűlő osztálypénze 30 diák esetén: {thisClass.MonthlyClassMoney*30*10} Ft");
        }
    }
}
