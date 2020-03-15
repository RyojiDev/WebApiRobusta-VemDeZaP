using prmToolkit.NotificationPattern;
using VemDeZap.Domain.Entities.Base;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Entities
{
    public class Group : EntityBase
    {

        public User User { get; set; }
        public string Name { get; set; }
        public EnumNiche Niche { get; set; }
        
        protected Group()
        {

        }

        public Group(User user, string name, EnumNiche niche)
        {
            User = user;
            Name = name;
            Niche = niche;

            if(user == null)
            {
                AddNotification("Usuario", "Informe o usuário");
            }

            new AddNotifications<Group>(this).IfNullOrInvalidLength(x => x.Name, 3, 150)
                .IfEnumInvalid(x => x.Niche);
        }
        
        public void AlterGroup(string name, EnumNiche niche)
        {
            Name = name;
            Niche = niche;
        }

    }
}
