
namespace UI
{
     class uchaniki
    {
        public string Name { get; set;}
        public string Surname { get; set; }
        public int Reit { get; set; }
        public string Zvan { get; set; }
        public string Type { get; set; }
        public string Stat { get; set; }
        public uchaniki(string name, string surname, int reit, string zvan, string type, string stat)
        {
            Name = name;
            Surname = surname;
            Reit= reit;
            Zvan = zvan;
            Type = type;
            Stat = stat; 
        }
    }
}
