using System.ComponentModel.DataAnnotations;

namespace SierraTakeHome.Domain
{
    internal class ExistingProductSpecificationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var productRepository = (IProductRepository)validationContext.GetService(typeof(IProductRepository));
            var productId = (int)value;
            var productTask = productRepository.GetByIdAsync(productId);
            productTask.Wait();
            var product = productTask.Result;
            if (product == null)
            {
                return new ValidationResult("Product does not exist");
            }
            return ValidationResult.Success;
        }
    }
}