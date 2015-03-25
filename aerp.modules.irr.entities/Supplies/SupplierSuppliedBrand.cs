
namespace aerp.modules.irr.entities.Supplies
{
	using entities;
	using Manufacturing;

	/// <summary>
	/// Поставляемый поставщиком бренд
	/// </summary>
	public class SupplierSuppliedBrand : EntityBase
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
		/// Идентифкатор бренда
		/// </summary>
        public int BrandId { get; set; }
		/// <summary>
		/// Бренд
		/// </summary>
        public Brand Brand { get; set; }
    }
}
