using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Builder
    {
        public static Televisor buildTelevisor() {
            Televisor televisor = new Televisor();
            televisor.ProducerCompany = Builder.enterNameOfProducerCompany();
            televisor.Model = Builder.enterNameOfModel();
            televisor.Price = Builder.enterPrice();
            televisor.Count = Builder.enterCount();
            return televisor;
        }

        public static string enterNameOfProducerCompany() {
            string nameOfProducerCompany = "noName";
            Console.WriteLine("Enter name of producer company?");
            nameOfProducerCompany = Console.ReadLine();
            return nameOfProducerCompany;
        }

        public static string enterNameOfModel()
        {
            string nameOfModel = "noName";
            Console.WriteLine("Enter model?");
            nameOfModel = Console.ReadLine();
            return nameOfModel;
        }

        public static int enterPrice() {
            string priceLine = "priceLine";
            do
            {
                Console.WriteLine("Enter price?");
                priceLine = Console.ReadLine();
            } while (!Checker.checkIsInt(priceLine));
            return int.Parse(priceLine);
        }

        public static int enterCount()
        {
            string countLine = "countLine";
            do
            {
                Console.WriteLine("Enter count?");
                countLine = Console.ReadLine();
            } while (!Checker.checkIsInt(countLine));
            return int.Parse(countLine);
        }
    }
}
