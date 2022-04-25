using PasswordValidatorControl.Model;
using PasswordValidatorControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidatorControl
{
    public class CustomValidator : ICustomValidator
    {
        public ValidationResult ValidatePassword(string password)
        {
            int lower = 0;
            int upper = 0;
            int num = 0;
            int validletter = 0;
            int validcount = 0;
            int a;

            int length = password.Length;
            ValidationResult validationResult = new ValidationResult();
            validationResult.Errors = new List<string>();


            if (string.IsNullOrEmpty(password))
            {
                validationResult.Success = false;
                validationResult.Errors.Add("Password cannot be null or empty");
            }

            //set 1 validation
            if (length >= 10)
            {
                

                foreach (char p in password)
                {
                    
                    if ((p >= 'A' && p <= 'Z') || (p >= 'a' && p <= 'z'))
                    {
                        validletter++;
                    }
                    if (p >= '0' && p <= '9')
                    {
                        validcount++;
                    }
                }
                if (validcount == 0|| validletter==0)
                {
                    validationResult.Success = false;
                    validationResult.Errors.Add("Passwords with minimum length of 10 characters should be a mixture of letters and numbers");
                }
                else
                {
                    validationResult.Success = true;

                }



            }
            else if (length >= 8 && length <= 10)
            {
               
                foreach (char p in password)
                {
                    if (p >= 'A' && p <= 'Z')
                    {
                        upper++;

                    }

                    if (p >= 'a' && p <= 'z')
                    {
                        lower++;

                    }

                    if (p >= '0' && p <= '9')
                    {
                        num++;

                    }



                }
                if (upper == 0)
                {
                    validationResult.Errors.Add("Password with minimum length of 8 characters must contain atleast one upper case letter");
                }
                if (lower == 0)
                {

                    validationResult.Errors.Add("Password with minimum length of 8 characters must contain atleast one lower case letter");
                }
                if (num == 0)
                {

                    validationResult.Errors.Add("Password with minimum length of 8 characters must contain atleast one number");
                }
                
                if ((int.TryParse(password[length - 1].ToString(), out a)) || (int.TryParse(password[0].ToString(), out a)))
                {
                    validationResult.Errors.Add("Password with minimum length of 8 characters must not start or end with a number");

                }
                if (validationResult.Errors.Count > 0)
                {
                    validationResult.Success = false;
                }
                else
                {
                    validationResult.Success = true;
                }


            }
            else
            {
                validationResult.Errors.Add("Password should have minimum length of 8 characters");
                validationResult.Success = false;
            }

            return validationResult;


        }
    }
}
