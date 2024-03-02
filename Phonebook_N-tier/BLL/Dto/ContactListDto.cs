using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class ContactListDto
    {
        public int Id { get; set; }

        public required string Fullname { get; set; }

        public required string Phonenumber { get; set; }
    }
}
