using System;
using System.Collections.Generic;

namespace ToDo
{
    public class person
    {
        private List<TodoPersonModel> personn;

        public person()
        {
            personn = new List<TodoPersonModel>();
        }

        public void Add(string no, string isim, string soyisim)
        {
            TodoPersonModel personModel = new TodoPersonModel();
            personModel.No1 = no;
            personModel.İsim1 = isim;
            personModel.Soyisim1 = soyisim;
            personn.Add(personModel);
        }

        public string Find(string sayi)
        {
            string result = "";

            foreach (var item in personn)
            {
                if(item.No1 == sayi)
                {
                    result = item.İsim1 + " " + item.Soyisim1; 
                }
            }
            return result;
        }

        public bool varmı(string sayi)
        {
            bool result = false;

            foreach (var item in personn)
            {
                if(item.No1 == sayi)
                {
                    result = true; 
                }
            }
            return result;
        }
    }
}