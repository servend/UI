namespace UI
{
    class tur
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Tur1 { get; set; }
        public int Tur2 { get; set; }
        public int Tur3 { get; set; }
        public int Tur4 { get; set; }
        public int Final { get; set; }
        public int Itog { get; set; }
        public tur(int id,string name, int tur1, int tur2, int tur3, int tur4, int final, int itog)
        {
            ID = id;
            Name = name;
            Tur1 = tur1;
            Tur2 = tur2;
            Tur3 = tur3;
            Tur4 = tur4;
            Final = final;
            Itog = itog;



        }
        }
}
