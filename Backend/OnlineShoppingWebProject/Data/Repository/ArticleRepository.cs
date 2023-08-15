using Data.Context;
using Data.Models;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
=======
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f

namespace Data.Repository
{
	public class ArticleRepository : GenericRepository<Article>, IArticleRepository
	{
		public ArticleRepository(OnlineShopDbContext context) : base(context)
		{
		}
<<<<<<< HEAD

		public List<Article> GetAllArticlesFromSeller(long id)
		{
			List<Article> articles = _context.Articles.Where(x => x.SellerId == id).ToList();

			return articles;
		} 
=======
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
	}
}
