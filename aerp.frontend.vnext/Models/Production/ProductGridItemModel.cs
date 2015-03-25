namespace aerp.frontend.vnext.Models.Production
{
	using System.ComponentModel.DataAnnotations;

	public class ProductGridItemModel
    {
		/// <summary>
		/// ID
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "ID")]
		public string Id { get; set; }

		/// <summary>
		/// Артикул
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Артикул")]
		public string Articul { get; set; }

		/// <summary>
		/// Название
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Название")]
		public string Name { get; set; }

		/// <summary>
		/// Бренд
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Бренд")]
		public string Brand { get; set; }

		/// <summary>
		/// Товарная группа
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Товарная группа")]
		public string ProductGroup { get; set; }

		/// <summary>
		/// Вид товара
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Вид товара")]
		public string ProductKind { get; set; }

		/// <summary>
		/// Тип товара
		/// </summary>
		[Required]
		[DataType(DataType.Text)]
		[Display(Name = "Тип товара")]
		public string ProductType { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		[Required]
		[DataType(DataType.Currency)]
		[Display(Name = "Цена")]
		public double Price { get; set; }

	}
}