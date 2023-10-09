namespace Traveller.API.Models
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int STR { get; set; } = 2;
        public int DEX { get; set; } = 2;
        public int END { get; set; } = 2;
        public int INT { get; set; } = 2;
        public int EDU { get; set; } = 2;
        public int SOC { get; set; } = 2;

    }
}
