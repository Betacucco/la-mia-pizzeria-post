namespace LaMiaPizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Prezzo { get; set; }

        public Pizza()
        {

        }

        public Pizza(int id, string name, string ingredienti, string image, double prezzo)
        {
            this.Id = id;
            this.Name = name;
            this.Description = ingredienti;
            this.Image = image;
            this.Prezzo = prezzo;
        }
    }
}
