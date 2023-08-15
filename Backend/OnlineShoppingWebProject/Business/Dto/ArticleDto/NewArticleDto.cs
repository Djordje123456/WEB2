using Microsoft.AspNetCore.Http;

namespace Business.Dto.ArticleDto
{
	public class NewArticleDto
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public int Quantity { get; set; }

		public IFormFile ProductImage { get; set; }
	}
}
