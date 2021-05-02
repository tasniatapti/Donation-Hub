using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess_Layer.Entities
{
    class Donor
    {
        public int DonorId { get; set; }
        public String DonorName { get; set; }
        public String DonorAddress { get; set; }
        public long DonorPhone { get; set; }
        public String DonorEmail { get; set; }
    }
}
