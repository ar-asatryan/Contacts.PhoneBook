using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class DataBase
    {
        public List<Contact> GetContact(int count)
        {            
            var list = new List<Contact>(count);
            var rnd = new Random();
            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = rnd.Next(100000,999999);
                Contact ct = new Contact { Name = $"A{i + 1}", SurName = $"A{i+1}yan", PhoneNum = arr[i]  };
                list.Add(ct);
            }
            return list;
        }
    }
}
