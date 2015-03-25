
namespace aerp.modules.irr.entities.Organization
{
	using entities;
	using Banking;

	/// <summary>
	/// Расчетный счет организации
	/// </summary>
	public class CompanyBankAccount : EntityBase
    {
		/// <summary>
		/// Идентификатор организации
		/// </summary>
        public int CompanyId { get; set; }
		/// <summary>
		/// Организация
		/// </summary>
        public Company Company { get; set; }
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
