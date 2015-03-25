

namespace aerp.modules.irr.entities.Production
{
	using Classification;
	using entities;

	/// <summary>
	/// Упаковка
	/// </summary>
	public class Package : EntityBase
    {
		/// <summary>
		/// Название в упаковке
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Идентификатор товара, который упакован
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// Товара, который упакован
		/// </summary>
		public Product Product { get; set; }
		/// <summary>
		/// Вес
		/// </summary>
        public decimal Weight { get; set; }
		/// <summary>
		/// Вместимость упаковки (количество товара, которое может быть упаковано)
		/// </summary>
		public decimal Capacity { get; set; }
		/// <summary>
		/// Идентификатор единицы измерения товара в упаковке
		/// </summary>
        public int UnitOfMeasureId { get; set; }
		/// <summary>
		/// Единица измерения товара в упаковке
		/// </summary>
        public MeasureUnit UnitOfMeasure { get; set; }
    }
}
