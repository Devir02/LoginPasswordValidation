using PasswordValidatorControl.Model;
using PasswordValidatorControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPasswordValidation
{
    public partial class LoginHome : System.Web.UI.Page
    {
        private readonly ICustomValidator _validator;

        public LoginHome(ICustomValidator validator)
        {
            this._validator = validator;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            ValidationResult result = _validator.ValidatePassword(password);
            if (result.Success == true)
            {
                Response.Redirect("");
            }
            else
            {
                lstValidationErrors.DataSource = result.Errors;
                lstValidationErrors.DataBind();
                lstValidationErrors.Visible = true;
            }
        }
    }
}