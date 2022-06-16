using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_in_Form
{
    public class category
    {
        
        
        public string CategoryName { get; set; }
        public string CategoryDescription{ get; set; }
        public int ID { get; set; }
        public List<product> products=new List<product>();

        public category()
        {   
           ID =1 ;
        }
    }

}
