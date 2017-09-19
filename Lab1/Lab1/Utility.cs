using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Utility
    {

        public static void showInformationFrom(Dictionary<int, Televisor> objectsList) {
            foreach (KeyValuePair<int, Televisor> keyValue in objectsList)
            {
                Console.WriteLine("ID: " + keyValue.Key + " - " + keyValue.Value.ToString());
            }
        }

        public static int getIdTelevisorForChanging(Dictionary<int, Televisor> objectsList) {
            int idTelevisorForChanging = 0;
            Utility.showInformationFrom(objectsList);
            String lineIdTelevisorForChanging = "idLine";
            do
            {
                Console.WriteLine("Enter id televisor for changing:");
                lineIdTelevisorForChanging = Console.ReadLine();
            } while (!Checker.checkIsInt(lineIdTelevisorForChanging));
            idTelevisorForChanging = int.Parse(lineIdTelevisorForChanging);
            return idTelevisorForChanging;
        }

        public static int showMenuForChanging() {
            string lineUserSolve = "lineUserSolve";
            do
            {
                Console.WriteLine("1 - Change production company");
                Console.WriteLine("2 - Change model");
                Console.WriteLine("3 - Change price");
                Console.WriteLine("4 - Change count");
            } while (!Checker.checkIsInt(lineUserSolve) && int.Parse(lineUserSolve) == 1 &&
                                                           int.Parse(lineUserSolve) == 2 &&
                                                           int.Parse(lineUserSolve) == 3 &&
                                                           int.Parse(lineUserSolve) == 4);
            return int.Parse(lineUserSolve);
        }

        public static Dictionary<int, Televisor> changeTelevisor(Dictionary<int, Televisor> objectsList, int idTelevisorForChnaging) {
            switch (Utility.showMenuForChanging()) {
                case 1:
                    {
                        Televisor televisor = objectsList[idTelevisorForChnaging];
                        televisor.ProducerCompany = Builder.enterNameOfProducerCompany();
                        objectsList.Remove(idTelevisorForChnaging);
                        objectsList.Add(idTelevisorForChnaging, televisor);
                    }
                    break;
                case 2:
                    {
                        Televisor televisor = objectsList[idTelevisorForChnaging];
                        televisor.Model = Builder.enterNameOfModel();
                        objectsList.Remove(idTelevisorForChnaging);
                        objectsList.Add(idTelevisorForChnaging, televisor);
                    }
                    break;
                case 3:
                    {
                        Televisor televisor = objectsList[idTelevisorForChnaging];
                        televisor.Price = Builder.enterPrice();
                        objectsList.Remove(idTelevisorForChnaging);
                        objectsList.Add(idTelevisorForChnaging, televisor);
                    }
                    break;
                case 4:
                    { 
                        Televisor televisor = objectsList[idTelevisorForChnaging];
                        televisor.Count = Builder.enterCount() ;
                        objectsList.Remove(idTelevisorForChnaging);
                        objectsList.Add(idTelevisorForChnaging, televisor);
                    }
                    break;
            }
            return objectsList;
        }

    }
}
