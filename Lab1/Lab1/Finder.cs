using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab1
{
    class Finder
    {
        private Dictionary<int, Televisor> televisorsList;

        public Dictionary<int, Televisor> TelevisorsList
        {
            get
            {
                return televisorsList;
            }

            set
            {
                televisorsList = value;
            }
        }

        private Finder() { }

        public Finder(Dictionary<int, Televisor> televisorsList) {
            this.televisorsList = televisorsList;
        }

        private int showSearchingMenu() {
            string userSolve = "lineUserSolve";

            Console.WriteLine("1 - Find by production company name");
            Console.WriteLine("2 - Find by production model");
            Console.WriteLine("3 - Find by production price");
            Console.WriteLine("4 - Find by production company count");

            return int.Parse(userSolve);
        }

        public void searchingMenu() {
            switch (showSearchingMenu()) {
                case 1: 
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private Televisor getByCompanyName(string companyName) {
            //Сделать builder для Телевизора -  методы для ввода всех полей
            for (int i = 0; i < this.televisorsList.Count(); i++) {
                if (this.televisorsList[i].ProducerCompany.Equals(companyName)) {
                    return this.televisorsList[i];
                }
            }
            return null;
        }

        private Televisor getByModelName(string modelName)
        {
            for (int i = 0; i < this.televisorsList.Count(); i++)
            {
                if (this.televisorsList[i].Model.Equals(modelName))
                {
                    return this.televisorsList[i];
                }
            }
            return null;
        }

        private Televisor getByPrice(double price)
        {
            for (int i = 0; i < this.televisorsList.Count(); i++)
            {
                if (this.televisorsList[i].Price == price)
                {
                    return this.televisorsList[i];
                }
            }
            return null;
        }

        private Televisor getByCount(int count)
        {
            for (int i = 0; i < this.televisorsList.Count(); i++)
            {
                if (this.televisorsList[i].Count == count)
                {
                    return this.televisorsList[i];
                }
            }
            return null;
        }


    }
}
