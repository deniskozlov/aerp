

namespace aerp.modules.irr.entities.Production
{
	using Classification;
	using entities;

	/// <summary>
	/// Спецификация комплекта или составного товара
	/// </summary>
	public class CompositeSpecification : EntityBase
    {
		/// <summary>
		/// Составной товар (готовый конечный товар)
		/// </summary>
		public Product CompositeProduct { get; set; }
		/// <summary>
		/// Идентификатор составного товара (готовый конечный товар)
		/// </summary>
		public int CompositeProductId { get; set; }
		/// <summary>
		/// Входящий в комплект товар (часть комплектации)
		/// </summary>
		public Product ComponentProduct { get; set; }
		/// <summary>
		/// Идентификатор входящего в комплект товара (часть комплектации)
		/// </summary>
		public int ComponentProductId { get; set; }
		/// <summary>
		/// Единица измерения входящего в комплект товара
		/// </summary>
        public MeasureUnit ComponentProductUOM { get; set; }
		/// <summary>
		/// Идентификатор единицы измерения входящего в комплект товара
		/// </summary>
		public int ComponentProductUOMId { get; set; }
		/// <summary>
		/// Количество входящих в комплектацию товаров (частей)
		/// </summary>
		public decimal ComponentProductAmount { get; set; }

    }
}
