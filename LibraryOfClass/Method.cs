using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces
{
    public class Method
    {
        public static string GetParametres(Person person)
        {
            string parametres = string.Format("Фамилия: {0}\nИмя: {1}\nНациональность: {2}\nВозраст: {3}\nРост: {4}\nВес: {5}", person.GetLName(), person.GetFname(), person.GetNationality(), person.GetAge(), person.GetGrowth(), person.GetWeight());
            return parametres;
        }
    }
}
