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
    }
}