using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_in_Form
{
    public class store
    {
        public store()
        { 
        
        }
        public string storeName { get; set; }
        public List<category> categories = new List<category>();
    }
}
