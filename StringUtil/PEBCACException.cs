using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtil
{
    class PEBCACException : Exception
    {

        private string errorMessage;

        public PEBCACException(string errorMessage) : base(errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        public string getErrorMessage()
        {
            return "Te nagyon hülye vagy, mert: " + errorMessage;
        }
    }
}
