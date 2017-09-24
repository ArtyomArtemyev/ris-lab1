using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    internal class Finder
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

        private Finder()
        {
        }

        public Finder(Dictionary<int, Televisor> televisorsList)
        {
            this.televisorsList = televisorsList;
        }

        private int showSearchingMenu()
        {
            int userSolve = 0;

            Console.WriteLine("1 - Find by production company name");
            Console.WriteLine("2 - Find by production model");
            Console.WriteLine("3 - Find by production price");
            Console.WriteLine("4 - Find by production company count");
            Console.Write("Enter:");
            try
            {
                userSolve = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter number!");
                return showSearchingMenu();
            }
            if (userSolve == 1 || userSolve == 2 ||
               userSolve == 3 || userSolve == 4)
            {
                return userSolve;
            }
            else { return showSearchingMenu(); }
        }

        public void searchingMenu()
        {
            switch (showSearchingMenu())
            {
                case 1:
                    {
                        this.checkAndShowResult(this.getByCompanyName());
                    }
                    break;

                case 2:
                    {
                        this.checkAndShowResult(this.getByModelName());
                    }
                    break;

                case 3:
                    {
                       this.checkAndShowResult(this.getByPrice());
                    }
                    break;

                case 4:
                    {
                        this.checkAndShowResult(this.getByCount());
                    }
                    break;
            }
        }

        private Televisor getByCompanyName()
        {
            if (!this.collectionIsEmpty())
            {
                string findParameter = Builder.enterNameOfProducerCompany();
                for (int i = 1; i <= this.televisorsList.Count(); i++)
                {
                    if (this.televisorsList[i].ProducerCompany.Equals(findParameter))
                    {
                        return this.televisorsList[i];
                    }
                }
            }
            return null;
        }

        private Televisor getByModelName()
        {
            if (!this.collectionIsEmpty())
            {
                string findParameter = Builder.enterNameOfModel();
                for (int i = 1; i <= this.televisorsList.Count(); i++)
                {
                    if (this.televisorsList[i].Model.Equals(findParameter))
                    {
                        return this.televisorsList[i];
                    }
                }
            }
            return null;
        }

        private Televisor getByPrice()
        {
            if (!this.collectionIsEmpty())
            {
                int findParameter = Builder.enterPrice();
                for (int i = 1; i <= this.televisorsList.Count(); i++)
                {
                    if (this.televisorsList[i].Price == Builder.enterPrice())
                    {
                        return this.televisorsList[i];
                    }
                }
            }
            return null;
        }

        private Televisor getByCount()
        {
            if (!this.collectionIsEmpty())
            {
                int findParameter = Builder.enterCount();
                for (int i = 1; i <= this.televisorsList.Count(); i++)
                {
                    if (this.televisorsList[i].Count == findParameter)
                    {
                        return this.televisorsList[i];
                    }
                }
            }
            return null;
        }

        private Boolean collectionIsEmpty() {
            if (this.televisorsList.Count() == 0 || this.televisorsList == null)
            {
                return true;
            }
            return false;
        }

        private void checkAndShowResult(Televisor televisor) {
            if (televisor == null)
            {
                Console.WriteLine("No find object");
            }
            else {
                Console.WriteLine("Find object:\n" + televisor.ToString());
            }
        }
    }
}