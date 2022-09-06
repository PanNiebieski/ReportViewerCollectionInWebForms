using System.Collections.Generic;

namespace ClassLibrary1
{
    public class MyDataSource
    {
        private static List<Person> _lstPeople = null;
        public static List<Person> GetAllPeople()
        {
            if (_lstPeople == null)
            {
                _lstPeople = new List<Person>();
                _lstPeople.Add(new Person()
                {
                    ID = 1,
                    Name = "Cezary",
                    Age = 30
                });

                _lstPeople.Add(new Person()
                {
                    ID = 2,
                    Name = "Darej",
                    Age = 30
                });

                _lstPeople.Add(new Person()
                {
                    ID = 3,
                    Name = "Krzytsof",
                    Age = 30
                });

                _lstPeople.Add(new Person()
                {
                    ID = 4,
                    Name = "Kamil",
                    Age = 31
                });

            }



            return _lstPeople;
        }


    }
}
