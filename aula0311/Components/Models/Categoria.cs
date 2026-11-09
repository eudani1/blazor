using System.ComponentModel.DataAnnotations;

namespace aula0311.Components.Models
{
	public class Categoria
	{
		[Required(ErrorMessage = "O nome da categoria é obrigatório.")]
		[MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 letras.")]
		// Regra extra: limita o tamanho para o nome caber na tabela e no menu sem quebrar o layout.
		[MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 letras.")]
		public string Nome { get; set; } = "";

		[Range(0, 100000, ErrorMessage = "A quantidade deve estar entre 0 e 100000.")]
		public int Quantidade { get; set; }
	}
}
