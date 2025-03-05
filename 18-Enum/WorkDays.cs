using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Enum
{
    //[Flags] 
    public enum WorkDays
    {
        None =0,
        Monday=5,
        Tuesday=2,
        Wednesday=65,           //sadece numara alır. numarayı kafana göre belirleyebilirsin.Boş olan değer bir onceki değere kaç   verildiyse ordan devam eder.
        Thursday,
        Friday,
        Saturday,
        Sunday


    }

}
