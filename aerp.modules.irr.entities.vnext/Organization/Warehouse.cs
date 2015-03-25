
namespace aerp.modules.irr.entities.Organization
{
	using entities;
	using Classification;
	using Pricing;

	/// <summary>
	/// Склад
	/// </summary>
	public class Warehouse : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Управление балансом
		/// </summary>
        public bool BalanceControl { get; set; }
		/// <summary>
		/// Тип склада
		/// </summary>
        public WarehouseTypes WarehouseType { get; set; }
		/// <summary>
		/// Идентификатор схемы ценообразования по умолчанию
		/// </summary>
        public int? CommonPriceSchemeId { get; set; }
		/// <summary>
		/// Схема ценообразования по умолчанию
		/// </summary>
        public PriceScheme CommonPriceScheme { get; set; }
		///// <summary>
		///// Идентификатор ответственного лица
		///// </summary>
  //      public int? ResponsibleEmployeeId { get; set; }
		///// <summary>
		///// Ответственное лицо
		///// </summary>
  //      public Employee ResponsibleEmployee { get; set; }
		/// <summary>
		/// Идентификтор адреса склада
		/// </summary>
        public int? AddressId { get; set; }
		/// <summary>
		/// Адрес склада
		/// </summary>
        public Address Address { get; set; }
		/// <summary>
		/// Телефон
		/// </summary>
        public string Phone { get; set; }
    }
}
