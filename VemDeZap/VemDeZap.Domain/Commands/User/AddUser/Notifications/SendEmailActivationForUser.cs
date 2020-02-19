using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands.User.AddUser.Notifications
{
     public class SendEmailActivationForUser : INotificationHandler<AddUserNotification>
    {
        public async Task Handle(AddUserNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Enviar email de ativação para o usuario" + notification.User.FirstName);
        }
    }
}
