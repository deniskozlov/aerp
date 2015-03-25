
namespace aerp.modules.irr.entities.Pricing
{
	using Classification;
	using entities;
	using Production;

	/// <summary>
	/// Цена товара, установленая в определенное время
	/// </summary>
	public class ProductPrice : EntityBaseWithRegistrator
	{
		/// <summary>
		/// Идентификатор товара
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// Товар
		/// </summary>
		public Product Product { get; set; }

		/// <summary>
		///  Идентификатор валюты
		/// </summary>
		public int CurrencyId { get; set; }

		/// <summary>
		/// Валюта
		/// </summary>
		public Currency Currency { get; set; }

		/// <summary>
		/// Идентификатор схемы ценообразования
		/// </summary>
		public int PriceSchemeId { get; set; }

		/// <summary>
		/// Схема ценообразования
		/// </summary>
		public PriceScheme PriceScheme { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Идентификатор документа, устанавливающего цену 
		/// </summary>
		public int PriceSetRegistratorId { get; set; }
	}
}
