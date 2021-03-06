﻿using System.Runtime.Serialization;

namespace Lab1
{
    [DataContract]
    public class Televisor
    {
        private string nameOfproducerCompany;
        private string nameOfModel;
        private int price;
        private int count;

        [DataMember]
        public string ProducerCompany
        {
            get
            {
                return nameOfproducerCompany;
            }

            set
            {
                nameOfproducerCompany = value;
            }
        }

        [DataMember]
        public string Model
        {
            get
            {
                return nameOfModel;
            }

            set
            {
                nameOfModel = value;
            }
        }

        [DataMember]
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        [DataMember]
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public Televisor()
        {
            this.nameOfproducerCompany = "noNameOfCompany";
            this.nameOfModel = "noNameOfModel";
            this.price = 0;
            this.count = 0;
        }

        public Televisor(string producerCompany, string model, int price, int count)
        {
            this.nameOfproducerCompany = producerCompany;
            this.nameOfModel = model;
            this.price = price;
            this.count = count;
        }

        public override string ToString()
        {
            return "TELEVISOR" + "\n" +
                "producerCompany=" + this.nameOfproducerCompany + "\n" +
                "model=" + this.nameOfModel + "\n" +
                "price=" + this.price + "\n" +
                "count=" + this.count + "\n";
        }
    }
}