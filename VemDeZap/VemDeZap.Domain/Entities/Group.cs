using System;
using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Group : EntityBase
    {
        
        public User User { get; set; }
        public string Name { get; set; }
        public int Niche { get; set; }

    }
}
