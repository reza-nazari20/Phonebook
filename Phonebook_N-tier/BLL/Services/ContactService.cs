using BLL.Dto;
using DAL.DataBase;


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
                Fullname = $"{p.Name} {p.Lastname}",
                Phonenumber = p.PhoneNumber,
                Id = p.ID,
            }).ToList();
            return contacts;
        }

        public List<ContactListDto> SearchContact(string SearchKey)
        {
            var ContactQuery = database.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                    p.Name.Contains(SearchKey)
                    ||
                    p.Lastname.Contains(SearchKey)
                    ||
                    p.PhoneNumber.Contains(SearchKey)
                    ||
                    p.Company.Contains(SearchKey)
                    );

            }

            var daata = ContactQuery.Select(p => new ContactListDto
            {
                Fullname = $"{p.Name} {p.Lastname}",
                Phonenumber = p.PhoneNumber,
                Id = p.ID,
            }).ToList();
            return daata;
        }
    }
}
