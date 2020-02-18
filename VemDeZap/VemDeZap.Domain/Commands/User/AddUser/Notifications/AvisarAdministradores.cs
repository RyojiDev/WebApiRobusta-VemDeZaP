using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands.User.AddUser.Notifications
{
    public class AvisarAdministradores : INotificationHandler<AddUserNotification>
    {
        public async Task Handle(AddUserNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Chama o webservice que avisa que novo usuario se cadastrou " + notification.User.FirstName);

            
        }
    }
}
