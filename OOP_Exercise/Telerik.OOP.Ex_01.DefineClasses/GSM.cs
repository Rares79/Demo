namespace Telerik.OOP.Ex_01.DefineClasses
{
    private class GSM
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

    }
}
