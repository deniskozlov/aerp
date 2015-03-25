
namespace aerp.modules.irr.entities.Supplies
{
	using entities;
	using Banking;

	/// <summary>
	/// Рассчетный счет поставщика
	/// </summary>
	public class SupplierBankAccount : EntityBase
    {
		/// <summary>
		/// Идентификатор поставщика
		/// </summary>
        public int SupplierId { get; set; }
		/// <summary>
		/// Поставщик
		/// </summary>
        public Supplier Supplier { get; set; }
		/// <summary>
		/// Идентификатор рассчетного счета
		/// </summary>
        public int BankAccountId { get; set; }
		/// <summary>
		/// Рассчетный счет
		/// </summary>
        public BankAccount BankAccount { get; set; }
    }
}
