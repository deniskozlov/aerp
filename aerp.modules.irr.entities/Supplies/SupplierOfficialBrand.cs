
namespace aerp.modules.irr.entities.Supplies
{
	using entities;
	using Manufacturing;

	/// <summary>
	/// Официальный поставляемый бренд поставщика
	/// </summary>
	public class SupplierOfficialBrand : EntityBase
    {
		/// <summary>
		/// Идентификатор поставщика
		/// </summary>
        public int SuppilerId { get; set; }
		/// <summary>
		/// Поставщик
		/// </summary>
        public Supplier Supplier { get; set; }
		/// <summary>
		/// Идентификатор бренда
		/// </summary>
        public int BrandId { get; set; }
		/// <summary>
		/// Бренд
		/// </summary>
        public Brand Brand { get; set; }
    }
}
