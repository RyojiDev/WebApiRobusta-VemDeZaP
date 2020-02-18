using VemDeZap.Domain.Entities.Base;


namespace VemDeZap.Domain.Entities
{
    public class Contact : EntityBase
    {
        
        public User User { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Niche { get; set; }
    }
}
