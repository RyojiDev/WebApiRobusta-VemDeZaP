using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Entities
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Niche { get; set; }

    }
}
