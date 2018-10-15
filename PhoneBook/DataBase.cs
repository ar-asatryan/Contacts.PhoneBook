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
            string[] arr1 = new string[count];
            string[] arrNums = new string[count];


            string[] codes = { "093", "044", "055", "091", "077", "099", "060" };
            string[] initCodes = new string[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = rnd.Next(100000,999999);
                arr1[i] = arr[i].ToString();

                ShuffleInitCodes(codes);
                initCodes[i] = GetAnyInitCode(codes);
                arrNums[i] = $"{initCodes[i]}{arr1[i]}";

                Contact ct = new Contact { Name = $"A{i + 1}", SurName = $"A{i+1}yan", PhoneNum = arrNums[i]  };
                list.Add(ct);
            }
            return list;
        }

        public void ShuffleInitCodes(string[] arr)
        {
            Random rnd = new Random();
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        public string GetAnyInitCode(string[] arr)
        {
            var rnd = new Random();
            int k = rnd.Next(arr.Length);
            return arr[k];
        }
        

    }
}
