
namespace aerp.modules.irr.entities.Production
{
	using Classification;
	using entities;

	/// <summary>
	/// Значение динамического свойства товара
	/// </summary>
	public class ProductAttributeValue : EntityBase
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
		/// Идентификатор динамического свойства товара
		/// </summary>
        public int ProductAttributeId { get; set; }
		/// <summary>
		/// Динамическое свойство товара
		/// </summary>
        public ProductAttribute ProductAttribute { get; set; }
		/// <summary>
		/// Идентификатор значения универсального динамического свойства
		/// </summary>
        public int? SubjectAttributeValueId { get; set; }
		/// <summary>
		/// Значение универсального динамического свойства
		/// </summary>
		public SubjectAttributeValue SubjectAttributeValue { get; set; }

    }
}
