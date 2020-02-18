using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entities
{
    public class Contact : EntityBase
    {
        
        public User User { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public EnumNiche Niche { get; set; }
    }
}
