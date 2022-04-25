using PasswordValidatorControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorControl.Services
{
     public interface ICustomValidator
    {
        ValidationResult ValidatePassword(string password);
    }
}
