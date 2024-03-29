﻿using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;


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

        public ResultDto<ContactDetailDto> GetContactDetail(int Id)
        {
            var contact = database.Contacts.Find(Id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>()
                {
                    IsSuccess=false,
                    Message="مخاطب پیدا نشد",
                    Data=null,
                };
            }

            var data = new ContactDetailDto()
            {
                Company=contact.Company,
                CreateAt=contact.CreateAt,
                Description=contact.Description,
                ID=contact.ID,
                Lastname=contact.Lastname,
                Name=contact.Name,
                PhoneNumber=contact.PhoneNumber,
            };

            return new ResultDto<ContactDetailDto>()
            {
                IsSuccess = true,
                Data = data,
                Message = null,
            };
        }

        public ResultDto AddNewContact(AddNewContactDto newContact)
        {
            if (string.IsNullOrEmpty(newContact.PhoneNumber))
            {
                return new ResultDto()
                {
                    IsSuccess=false,
                    Message="وارد کردن شماره تلفن اجباری است",
                };
            }

            if (string.IsNullOrEmpty(newContact.Name))
            {
                return new ResultDto()
                {
                    IsSuccess=false,
                    Message="وارد کردن نام اجباری است",
                };
            }

            if (string.IsNullOrEmpty(newContact.Lastname))
            {
                return new ResultDto()
                {
                    IsSuccess=false,
                    Message="وارد کردن نام خانوادگی اجباری است",
                };
            }

            Contact contact = new Contact()
            {
                Company=newContact.Company,
                CreateAt=DateTime.Now,
                Description=newContact.Description,
                Name=newContact.Name,
                Lastname=newContact.Lastname,
                PhoneNumber=newContact.PhoneNumber,
            };

            database.Contacts.Add(contact);
            database.SaveChanges();

            return new ResultDto
            {
                IsSuccess=true,
                Message=$"مخاطب {contact.Name} {contact.Lastname} با موفقیت ذخیره شد",
            };
        }

        public ResultDto EditeContact(EditeContactDto editeContactDto)
        {
            var contact = database.Contacts.Find(editeContactDto.Id);
            if (contact == null)
            {
                return new ResultDto()
                {
                    IsSuccess=false,
                    Message="مخاطب یافت نشد",
                };
            }

            contact.Company = editeContactDto.Company;
            contact.Name = editeContactDto.Name;
            contact.Lastname=editeContactDto.Lastname;
            contact.PhoneNumber = editeContactDto.PhoneNumber;
            contact.Description = editeContactDto.Description;

            database.SaveChanges();

            return new ResultDto()
            {
                IsSuccess=true,
                Message="مخاطب یافت شد",
            };
        }
    }
}
