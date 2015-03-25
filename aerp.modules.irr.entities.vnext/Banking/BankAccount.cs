
namespace aerp.modules.irr.entities.Banking
{
	using entities;
	using Classification;

	/// <summary>
	/// Банковский счет
	/// </summary>
	public class BankAccount : EntityBase
    {
		/// <summary>
		/// Номер счета
		/// </summary>
        public string Account { get; set; }
		/// <summary>
		/// Идентификатор банка
		/// </summary>
        public int BankId { get; set; }
		/// <summary>
		/// Банк
		/// </summary>
        public Bank Bank { get; set; }
		/// <summary>
		/// Счет по умолчанию
		/// </summary>
        public bool IsDefault { get; set; }
		/// <summary>
		/// Валюта счета
		/// </summary>
        public Currency Currency { get; set; }
		/// <summary>
		/// Идентификатор валюты счета
		/// </summary>
        public int CurrencyId { get; set; }

    }
}
