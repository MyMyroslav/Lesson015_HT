using System;
namespace Lesson015_HT
{ 
    public struct Notebook
    {
        public string model;
        public string creator;
        public decimal price;

        public Notebook(string model, string creator, decimal price)
        {
            this.model = model;
            this.creator = creator;
            this.price = price;
        }
        public void Output()
        {
            Console.WriteLine($"Model: {model}, Creator: {creator}, Price: {price} ");
        }
    }
}
