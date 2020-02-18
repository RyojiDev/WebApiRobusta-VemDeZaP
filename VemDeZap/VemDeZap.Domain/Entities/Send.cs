using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Entities
{
    public class Send
    {
        public Guid Id { get; set; }
        public Campaign Campaign { get; set; }
        public Group Group { get; set; }
        public Contact Contact { get; set; }
        public bool Sent { get; set; }
    }
}
