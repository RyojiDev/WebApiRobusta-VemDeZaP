using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Entities
{
    public class Campaign
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

    }
}
