using System.ComponentModel.DataAnnotations;
//Dto nesneleri verileri tasımak amacıyla kullanilir.

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; } //init nesne olustuktan sonra degismeyecegini garanti eder
        [Required(ErrorMessage = "ProductName is required.")]
        public String? ProductName { get; init; } = String.Empty;

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; } //atama islemi dosya yuklendikten sonra olacaktır.

        public int? CategoryId { get; init; }

    }
}
