using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDDD.Domain.Commands.Sample
{
    public class LoginAccountCommand
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
