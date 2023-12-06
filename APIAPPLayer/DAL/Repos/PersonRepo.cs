using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PersonRepo
    {
        public static string GetName(int id) {
            //
            //
            //
            return id == 110 ? "Tanvir" : "Not found";
        }
    }
}
