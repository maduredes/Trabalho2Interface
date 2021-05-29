using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Models
{
   public  class AnalysisError:  Exception 
    {
        private int position { get; set; }

        public AnalysisError(String msg, int position) :base(msg)
        {
            this.position = position;
        }

     

        public AnalysisError(String msg):base(msg)
        {
            this.position = -1;
        }

        public int getPosition()
        {
            return position;
        }

        public String toString()
        {
            return base.ToString() + ", @ " + position;
        }
    }
}
