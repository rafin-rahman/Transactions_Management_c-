using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enterpriseDevelopment
{
    static class Instance
    {
        // Creating reference to main form to use in other forms(windows)
        public static Form MainForm;
         
        public static UserAccount StaticUserAccount = null;
    }
}
