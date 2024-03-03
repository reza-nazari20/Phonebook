using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class ContactDetailDto
    {
        public int ID { get; set; }

        public required string Name { get; set; }

        public required string Lastname { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Company { get; set; }

        public required string Description { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
