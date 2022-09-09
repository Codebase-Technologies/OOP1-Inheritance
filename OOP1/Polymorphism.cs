using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class NPower
    {

        string RegisterApplicant(string firstname, string lastname, string gsmNo)
        {

            return System.Guid.NewGuid().ToString();
            //return "A-009344/NGN/KEB/0093";
        }

        string RegisterApplicant(string votersID)
        {
            // code to contact INEC
            return System.Guid.NewGuid().ToString();
        }

        string RegisterApplicant(BankDetails bankDetails)
        {
            // code to contact CBN
            string bvn = bankDetails.BVN;
            return System.Guid.NewGuid().ToString();
        }

        string RegisterApplicant(string nPowerId, int stateCode)
        {
            // code to contact database to check for her details
            return System.Guid.NewGuid().ToString();
        }
    }

    class BankDetails  //model,
    {
        public string BVN { get; set; }
    }
}
