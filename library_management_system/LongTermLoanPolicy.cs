using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    public class LongTermLoanPolicy : ILoanPolicy
    {
        public string GetPolicyType()
        {
            return "uzun";
        }

        public void ApplyLoanPolicy(Book book, Member member)
        {
        }
    }

}
