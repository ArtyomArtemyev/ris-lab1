using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker = new FileWorker();
            Dictionary<int, Televisor> televisorsList = fileWorker.getTelevisorsFromFile();
            if (televisorsList == null) {
                televisorsList = new Dictionary<int, Televisor>();
            }
            while (true)
            {
                switch (new Switcher().getUserSolve())
                {
                    case 1:
                        {
                            if (televisorsList.Count() == 0)
                            {
                                Console.WriteLine("No objects in file");
                            }
                            else
                            {
                                Utility.showInformationFrom(fileWorker.getTelevisorsFromFile());
                            }
                        }
                        break;
                    case 2:
                        {
                            Televisor televisor = Builder.buildTelevisor();
                            int key = 1;
                            if (televisorsList.Count() == 0)
                            {
                                key = fileWorker.getTelevisorsList().Count() + 1;
                            }
                            televisorsList.Add(key, televisor);
                            fileWorker.setTelevisorsList(televisorsList);
                            fileWorker.setTelevisorsToFile();

                            Console.WriteLine("Successfull add new televisor");
                        }
                        break;
                    case 3:
                        {
                            if (televisorsList.Count() == 0)
                            {
                                Console.WriteLine("No objects in file");
                            }
                            else
                            {
                                Utility.showInformationFrom(fileWorker.getTelevisorsFromFile());
                            }
                            string idForDeleteing = "lineIdForDeleting";
                            do
                            {
                                Console.WriteLine("Enter id for deleting");
                                idForDeleteing = Console.ReadLine();
                            } while (!Checker.checkIsInt(idForDeleteing));
                            televisorsList.Remove(int.Parse(idForDeleteing));
                            fileWorker.reCreatingFile();
                            fileWorker.setTelevisorsList(televisorsList);
                            fileWorker.setTelevisorsToFile();

                            Console.WriteLine("Successfull delete televisor");
                        }
                        break;
                    case 4:
                        {
                            if (televisorsList.Count() == 0)
                            {
                                Console.WriteLine("No objects in file");
                            }
                            else
                            {
                                Utility.showInformationFrom(fileWorker.getTelevisorsFromFile());
                            }                          
                            fileWorker.setTelevisorsList(Utility.changeTelevisor(televisorsList, Utility.getIdTelevisorForChanging(televisorsList)));
                            fileWorker.reCreatingFile();
                            fileWorker.setTelevisorsToFile();

                            Console.WriteLine("Successfull editing televisor");
                        }
                        break;
                    case 5:
                        { }
                        break;
                    case 6:
                        { }
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
