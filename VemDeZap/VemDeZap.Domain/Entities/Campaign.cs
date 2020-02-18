using System;
using VemDeZap.Domain.Entities.Base;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Entities
{
    public class Campaign : EntityBase
    {
        

        public string Name { get; set; }

        public User User { get; set; }

    }
}
