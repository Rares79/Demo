using System;
namespace Telerik.OOP.Ex_01.DefineClasses

{
    public class GSM
    {
        private Battery battery = null;
        private Display display = null;

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string Owner { get; set; }

        public GSM()
        {
            battery = new Battery();
            display = new Display();
        }
        public GSM(string model, string manufacturer, float price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

    }
}
