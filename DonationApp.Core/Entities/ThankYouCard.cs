using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationApp.Core.Entities
{
    public class ThankYouCard
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public string DonationFor { get; set; }
        public DateTime GeneratedDate { get; set; }
        public byte[] CardImage { get; set; }

        //Fk tanımlamaları

        public int DonorId { get; set; }
        public Donor Donor { get; set; }
      
    }
}
