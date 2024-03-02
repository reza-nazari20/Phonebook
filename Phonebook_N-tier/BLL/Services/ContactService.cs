using BLL.Dto;
using DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContactService
    {
        //دریافت لیست مخاطبین

        DataBaseContext database = new DataBaseContext();

        public List<ContactListDto> GetContactLists()
        {
            var contacts = database.Contacts.Select(p => new ContactListDto()
            {
                Fullname=$"{p.Name} {p.Lastname}",
                Phonenumber=p.PhoneNumber,
                Id=p.ID,
            }).ToList();
            return contacts;
        }
    }
}
