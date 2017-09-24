using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Lab1
{
    internal class FileWorker
    {
        private string pathToFile = "D:\\lab1.json";
        private Dictionary<int, Televisor> televisors = new Dictionary<int, Televisor>();
        private FileStream fs = null;
        private DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(string));

        public Dictionary<int, Televisor> getTelevisorsList()
        {
            return this.televisors;
        }

        public void setTelevisorsList(Dictionary<int, Televisor> televisorsList)
        {
            this.televisors = televisorsList;
        }

        public FileWorker()
        {
        }

        public Dictionary<int, Televisor> getTelevisorsFromFile()
        {
            try
            {
                using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
                {
                    string json = (string)jsonFormatter.ReadObject(fs);
                    this.televisors = JsonConvert.DeserializeObject<Dictionary<int, Televisor>>(json);
                }
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                this.televisors = null;
            }
            return this.televisors;
        }

        public void setTelevisorsToFile()
        {
            string json = JsonConvert.SerializeObject(getTelevisorsList(), Formatting.Indented);
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, json);
            }
        }

        private Boolean checkFileIsEmpty()
        {
            var file = new FileInfo(pathToFile);
            if (file.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void reCreatingFile()
        {
            File.Delete(pathToFile);
            this.fs = new FileStream(pathToFile, FileMode.OpenOrCreate);
            this.fs.Close();
        }
    }
}