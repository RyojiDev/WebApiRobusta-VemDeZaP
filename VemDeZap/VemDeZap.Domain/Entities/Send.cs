using System;
using VemDeZap.Domain.Entities.Base;

namespace VemDeZap.Domain.Entities
{
    public class Send : EntityBase
    {
        protected Send()
        {

        }
        
        public Campaign Campaign { get; set; }
        public Group Group { get; set; }
        public Contact Contact { get; set; }
        public bool Sent { get; set; }
    }
}
