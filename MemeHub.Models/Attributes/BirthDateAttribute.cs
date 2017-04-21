using System;
using System.ComponentModel.DataAnnotations;

namespace MemeHub.Models.Attributes
{
    public class BirthDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!= null)
            {
                DateTime birthday = (DateTime)value;
                if (DateTime.Now.Year - birthday.Year >= 18)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("You should be at least 18.");
            }
            else
            {
                return ValidationResult.Success;
            }
           

        }
    }
}
