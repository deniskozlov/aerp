
namespace aerp.modules.irr.entities.Production
{
	using Classification;
	using entities;
	using Manufacturing;

	/// <summary>
	/// Товар или услуга
	/// </summary>
	public class Product : EntityBase
    {
        public Product()
        {
        }

		/// <summary>
		/// Уникальный складской код
		/// </summary>
        public string SKU { get; set; }
		/// <summary>
		/// Артикул
		/// </summary>
		public string Articul { get; set; }
		/// <summary>
		/// Название
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Название для печати
		/// </summary>
		public string PrintableName { get; set; }
		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Идентификатор бренда
		/// </summary>
        public int BrandId { get; set; }
		/// <summary>
		/// Идентификатор базовой единицы измерения
		/// </summary>
        public int? DefaultMeasureUnitId { get; set; }
		/// <summary>
		/// Бренд
		/// </summary>
        public Brand Brand { get; set; }
		/// <summary>
		/// Базовая единица измерения
		/// </summary>
        public MeasureUnit DefaultMeasureUnit { get; set; }
		/// <summary>
		/// Идентификатор ценовой группы
		/// </summary>
        public int? PriceGroupId { get; set; }
		/// <summary>
		/// Идентификатор товарной группы
		/// </summary>
        public int? ProductGroupId { get; set; }
		/// <summary>
		/// Ценовая группа
		/// </summary>
        public PriceGroup PriceGroup { get; set; }
		/// <summary>
		/// Товарная группа
		/// </summary>
        public ProductGroup ProductGroup { get; set; }
		/// <summary>
		/// Страна
		/// </summary>
        public string Country { get; set; }
		/// <summary>
		/// ГТД
		/// </summary>
        public string Gtd { get; set; }
		/// <summary>
		/// Весовой
		/// </summary>
        public bool IsWeightable { get; set; }
		/// <summary>
		/// Вес
		/// </summary>
        public decimal? Weight { get; set; }
		/// <summary>
		/// Вид товара
		/// </summary>
        public ProductKind ProductKind { get; set; }
		/// <summary>
		/// Идентификатор вида товара
		/// </summary>
        public int? ProductKindId { get; set; }
		/// <summary>
		/// НДС
		/// </summary>
		public VatRate VAT { get; set; }
		/// <summary>
		/// Тип товара
		/// </summary>
		public ProductType ProductType { get; set; }

		#region Overrides of Object

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>
        /// Строка, представляющая текущий объект.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} - {1}", Articul, Name);
        }

        #endregion
    }
}
