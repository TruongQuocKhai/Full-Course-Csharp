using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Course_Csharp
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken farm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
