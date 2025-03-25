using System.ComponentModel.DataAnnotations;
using IFluentApp.Helpers;

namespace IFluentApp.Validations.Login
{
    public class EmailValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(SystemMessage.FIELD_EMAIL_REQUIRED);
            }

            var input = value.ToString();
            if (string.IsNullOrWhiteSpace(input))
            {
                return new ValidationResult(SystemMessage.FIELD_EMAIL_REQUIRED);
            }

            if (EmailHelper.IsEmail(input))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(SystemMessage.FIELDS_EMAIL_VALID);
            }
        }
    }
}
