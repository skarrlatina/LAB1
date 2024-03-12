using Lab_1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1.Resources
{
    internal class Sort
    {
        public static List<StudentVm> SortBySurname(List<StudentVm> students)
        {
            return students.OrderBy(s => s.Surname).ToList();
        }
    }
}
