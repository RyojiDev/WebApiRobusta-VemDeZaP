﻿using MediatR;

namespace VemDeZap.Domain.Commands.User.AddUser
{
    class AddUserNotification : INotification
    {
        public Entities.User User { get; set; }

        public AddUserNotification(Entities.User user)
        {
            User = user;
        }
    }
}
