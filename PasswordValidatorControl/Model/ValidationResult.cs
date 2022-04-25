using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorControl.Model
{
    public class ValidationResult
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
