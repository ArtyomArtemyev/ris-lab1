using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab1
{
    class FileWorker
    {
        private string pathToFile = "D:\\Lab1.dat";
        private Dictionary<int, Televisor> televisors = new Dictionary<int, Televisor>();
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream fs = null;

        public Dictionary<int, Televisor> getTelevisorsList() {
            return this.televisors;
        }

        public void setTelevisorsList(Dictionary<int, Televisor> televisorsList)
        {
            this.televisors = televisorsList;
        }

        public FileWorker() {
            this.fs = new FileStream(pathToFile, FileMode.OpenOrCreate);
        }

        public Dictionary<int, Televisor> getTelevisorsFromFile() {
            this.fs = new FileStream(pathToFile, FileMode.OpenOrCreate);
            if (checkFileIsEmpty() == false)
            {
                this.televisors = (Dictionary<int, Televisor>)formatter.Deserialize(fs);
                return televisors;
            }
            else {
                return null;
            }
        }

        public void setTelevisorsToFile() {
            this.fs = new FileStream(pathToFile, FileMode.OpenOrCreate);
            formatter.Serialize(fs, this.televisors);
        }

        private Boolean checkFileIsEmpty() {
            var file = new FileInfo(pathToFile);
            if (file.Length == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void reCreatingFile() {
            File.Delete(pathToFile);
            this.fs = new FileStream(pathToFile, FileMode.OpenOrCreate);
        }
    }
}
