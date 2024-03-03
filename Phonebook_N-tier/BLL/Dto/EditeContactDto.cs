using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class EditeContactDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Lastname { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Company { get; set; }

        public required string Description { get; set; }
    }
}
