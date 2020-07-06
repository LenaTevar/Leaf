namespace Leaf.Models
{
    public class recipe
    {
        public recipe()
        {

        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int VegetalProtein { get; set; }
        public int AnimalProtein { get; set; }
        public int Carbohydrates { get; set; }
        public int Fat { get; set; }

        public bool Launch { get; set; }
        public bool Dinner { get; set; }
        public bool Breakfast { get; set; }

        public bool Vegetable { get; set; }
        public bool Fish { get; set; }
        public bool WhiteMeat { get; set; }
        public bool RedMeat { get; set; }

    }
}