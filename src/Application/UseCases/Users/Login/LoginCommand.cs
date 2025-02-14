using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Application.Abstractions.Messaging;

namespace Application.UseCases.Users.Login;

internal sealed record LoginCommand(string Email, string Password) : ICommand<string>;
