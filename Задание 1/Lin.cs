using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public struct Lin
    {
        
        double k;
        double b;

        public  Lin (double k, double b)
            
        {  
           this.k = k;
           this.b = b;
      
        }
        public string Root()
        {
            double x= -b / k;
            return $"Решение уравнения = {x}";
        }
    }
    
}
