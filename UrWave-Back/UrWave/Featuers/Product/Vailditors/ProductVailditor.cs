using FluentValidation;
using UrWave.Featuers.Product.DTO.ProductDTO;

namespace UrWave.Featuers.Product.Vailditors
{
    public class ProductVailditor : AbstractValidator<AddOrUpdateProductDto>
    {
        public ProductVailditor()
        {
            RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("Product Name is Requierd")
            .MaximumLength(100)
            .WithMessage("Product name cannot exceed 100 characters");

            RuleFor(p => p.Description)
           .NotEmpty()
           .WithMessage("Description is required.")
           .MaximumLength(500)
           .WithMessage("Description cannot exceed 500 characters.");

            RuleFor(p => p.Price)
           .GreaterThan(0)
           .WithMessage("Price must be greater than 0.");
        }
    }
}
