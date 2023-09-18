using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Proj
{
  public  class MineCell
    {
        public Button cell { get; set; } = null;        
        public int Status { get; set; } = -1;
        public int CanBeAdded = 1; // 1 = chưa có mìn, 0 = có mìn
        public int rows, cols;
    }       
}
