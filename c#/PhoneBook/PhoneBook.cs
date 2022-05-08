using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneBook
    {
        private List<PhoneBookModel> phoneBook;

        public PhoneBook()
        {
            phoneBook = new List<PhoneBookModel>();
        }

        public List<PhoneBookModel> Liste()
        {
            return phoneBook;
        }

        public void Add(string isim, string soyisim, string telefonno)
        {
            PhoneBookModel phoneBookModel = new PhoneBookModel();
            phoneBookModel.Isim1 = isim;
            phoneBookModel.Soyisim1 = soyisim;
            phoneBookModel.TelefonNo1 = telefonno;
            phoneBook.Add(phoneBookModel);
        }

        public void Delete(PhoneBookModel phoneBookModel)
        {
            phoneBook.Remove(phoneBookModel);
        }

        public List<PhoneBookModel> Find(string isim, string soyisim, string telefonno)
        {
            List<PhoneBookModel> result = new List<PhoneBookModel>();

            foreach (var item in phoneBook)
            {
                if(item.Isim1 == isim || item.Soyisim1 == soyisim || item.TelefonNo1 == telefonno)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}