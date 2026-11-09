using System.ComponentModel.DataAnnotations;

namespace aula0311.Components.Models
{
	public class Produto
	{
		[Required(ErrorMessage = "O nome do produto é obrigatório.")]
		public string Nome { get; set; } = "";

		[Range(typeof(decimal), "0.01", "999999999",
			ErrorMessage = "O preço deve ser maior que zero.",
			ParseLimitsInInvariantCulture = true,
			ConvertValueInInvariantCulture = true)]
		public decimal Preco { get; set; }

		[Range(0, 100000, ErrorMessage = "A quantidade deve estar entre 0 e 100000.")]
		public int Quantidade { get; set; }
	}
}
