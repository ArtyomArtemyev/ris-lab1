using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Sorter
    {
        private Dictionary<int, Televisor> televisorsList;

        public Sorter() { }

        public Sorter(Dictionary<int, Televisor> televisorsList) {
            this.televisorsList = televisorsList;
        }

        public void sortByCompanyName() {
            if (this.televisorsList == null && this.televisorsList.Count() == 0)
            {
                Console.WriteLine("No find object for sorting");
            }
            else
            {
                var items = from pair in this.televisorsList
                            orderby pair.Value.ProducerCompany ascending
                            select pair;
                foreach (KeyValuePair<int, Televisor> pair in items)
                {
                    Console.WriteLine(pair.Value.ToString());
                }
            }
        }

        public void sortByModel()
        {
            if (this.televisorsList == null && this.televisorsList.Count() == 0)
            {
                Console.WriteLine("No find object for sorting");
            }
            else
            {
                var items = from pair in this.televisorsList
                            orderby pair.Value.Model ascending
                            select pair;
                foreach (KeyValuePair<int, Televisor> pair in items)
                {
                    Console.WriteLine(pair.Value.ToString());
                }
            }
        }

        public void sortByPrice() {
            if (this.televisorsList == null && this.televisorsList.Count() == 0)
            {
                Console.WriteLine("No find object for sorting");
            }
            else
            {
                var items = from pair in this.televisorsList
                            orderby pair.Value.Price ascending
                            select pair;
                foreach (KeyValuePair<int, Televisor> pair in items)
                {
                    Console.WriteLine(pair.Value.ToString());
                }
            }
        }

        public void sortByCount()
        {
            if (this.televisorsList == null && this.televisorsList.Count() == 0)
            {
                Console.WriteLine("No find object for sorting");
            }
            else
            {
                var items = from pair in this.televisorsList
                            orderby pair.Value.Count ascending
                            select pair;
                foreach (KeyValuePair<int, Televisor> pair in items)
                {
                    Console.WriteLine(pair.Value.ToString());
                }
            }
        }

        private int showSortingMenu()
        {
            int userSolve = 0;

            Console.WriteLine("1 - Sort by production company name");
            Console.WriteLine("2 - Sort by production model");
            Console.WriteLine("3 - Sort by production price");
            Console.WriteLine("4 - Sort by count");
            Console.Write("Enter:");
            try
            {
                userSolve = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter number!");
                return showSortingMenu();
            }
            if (userSolve == 1 || userSolve == 2 ||
               userSolve == 3 || userSolve == 4)
            {
                return userSolve;
            }
            else { return showSortingMenu(); }
        }

        public void sortingMenu()
        {
            switch (showSortingMenu())
            {
                case 1:
                    {
                        this.sortByCompanyName();
                    }
                    break;

                case 2:
                    {
                        this.sortByModel();
                    }
                    break;

                case 3:
                    {
                        this.sortByPrice();
                    }
                    break;

                case 4:
                    {
                        this.sortByCount();
                    }
                    break;
            }
        }

    }

    public class SpecialComparerByPrice : IComparer<KeyValuePair<int , Televisor>>
    {
        public int Compare(KeyValuePair<int, Televisor> a, KeyValuePair<int, Televisor> b)
        {
            return a.Value.Price == b.Value.Price ? 0 : a.Value.Price > b.Value.Price ? 1 : -1;
        }
    }

    public class SpecialComparerByCount : IComparer<KeyValuePair<int, Televisor>>
    {
        public int Compare(KeyValuePair<int, Televisor> a, KeyValuePair<int, Televisor> b)
        {
            return a.Value.Count == b.Value.Count ? 0 : a.Value.Count > b.Value.Count ? 1 : -1;
        }
    }

    public class SpecialComparerByCompanyname : IComparer<KeyValuePair<int, Televisor>>
    {
        public int Compare(KeyValuePair<int, Televisor> a, KeyValuePair<int, Televisor> b)
        {
            return a.Value.ProducerCompany.Equals(b.Value.ProducerCompany) ? 0 : 1;
        }
    }

    public class SpecialComparerByModel : IComparer<KeyValuePair<int, Televisor>>
    {
        public int Compare(KeyValuePair<int, Televisor> a, KeyValuePair<int, Televisor> b)
        {
            return a.Value.Model.Equals(b.Value.Model) ? 0 : 1;
        }
    }

}
