using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallange.Application.ViewModels.Company
{
    public class UpdateCompany
    {
        public int Id { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderFinishTime { get; set; }
    }
}
