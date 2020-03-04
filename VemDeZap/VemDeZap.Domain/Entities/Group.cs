using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entities
{
    public class Group : EntityBase
    {
        protected Group()
        {

        }
        
        public User User { get; set; }
        public string Name { get; set; }
        public EnumNiche Niche { get; set; }

    }
}
