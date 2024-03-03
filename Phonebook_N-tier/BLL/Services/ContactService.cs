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

        /// <summary>
        /// جستوجو
        /// </summary>
        /// <param name="SearchKey"></param>
        /// <returns></returns>
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

        public ResultDto DeleteContact(int id)
        {
            var contact = database.Contacts.Find(id);
            if (contact != null)
            {
                database.Remove(contact);
                database.SaveChanges();
                return new ResultDto()
                {
                    IsSuccess=true,
                    Message="مخاطب با موفقیت حذف شد"
                };
            }
            return new ResultDto()
            {
                IsSuccess = false,
                Message="مخاطب با موفقیت حذف نشد"
            };
        }
    }
}
