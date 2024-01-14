namespace PostgreSQL.Data
{
    public class Pokemon
    {
        /*public enum Pokemon_Type
       {
           Normal, Fire, Water, Grass, Flying, Fighting, Poison, Electric, Ground, Rock, Psychic, Ice, Bug, Ghost, Steel, Dragon, Dark, Fairy
       }
       */

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Category { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}