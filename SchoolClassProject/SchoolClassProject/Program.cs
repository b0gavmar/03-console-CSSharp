using SchoolClassProject.Models;
using SchoolClassProject.Repos;

SchoolClass kilencA = new SchoolClass(9,'A',7000,30);
SchoolClass kilencB = new SchoolClass(9, 'b', 6000,28);

SchoolClassRepo schoolClassRepo = new();
schoolClassRepo.AddClass(kilencA);
schoolClassRepo.AddClass(kilencB);

Console.WriteLine(kilencA);

Console.WriteLine("\n");

kilencA.WhoPaysMoreAndByWhatAmount(kilencB);

Console.WriteLine("\n");

/*
kilencA.TenMonthsClassMoneyWithThirtyStudents();
kilencB.TenMonthsClassMoneyWithThirtyStudents();
*/
foreach (SchoolClass schoolClass in schoolClassRepo.SchoolClasses)
{
    schoolClass.TenMonthsClassMoneyWithThirtyStudents();
}

Console.WriteLine("\n");

Console.WriteLine(schoolClassRepo.MostPaidSchoolClass());
