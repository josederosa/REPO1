using System;
using System.Collections.Generic;
using System.Linq;

namespace MauiApp2.Models
{
    public static class ContactsRepository
    {

        private static List<Contact> _contactList = new List<Contact>()
        {new Contact(){Id = 1 ,Name="Jose",Email="jose@pepe.com"},
         new Contact(){Id = 2 ,Name="Daniel",Email="daniel@pepe.com"}};

        public static List<Contact> GetAllContacts()
        {
            return _contactList;
        }
        public static Contact? GetContactsById(int xId)
        {
            return _contactList.Where(x=>x.Id==xId).FirstOrDefault();
        }

    }
}
