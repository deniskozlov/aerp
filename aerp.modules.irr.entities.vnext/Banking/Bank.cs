
namespace aerp.modules.irr.entities.Banking
{
	using entities;
	using Classification;

	/// <summary>
	/// Банк
	/// </summary>
	public class Bank : EntityBase
    {
		/// <summary>
		/// Название банка
		/// </summary>
        public string BankName { get; set; }
		/// <summary>
		/// БИК
		/// </summary>
        public string BIC { get; set; }
		/// <summary>
		/// ИНН
		/// </summary>
        public string TIN { get; set; }
		/// <summary>
		/// Корреспондирующий счет
		/// </summary>
        public string CrossAccount { get; set; }
		/// <summary>
		/// Идентификатор адреса банка
		/// </summary>
        public int? BankAddressId { get; set; }
		/// <summary>
		/// Адрес банка
		/// </summary>
        public Address BankAddress { get; set; }
		/// <summary>
		/// Телефон
		/// </summary>
        public string Phone { get; set; }
    }
}
