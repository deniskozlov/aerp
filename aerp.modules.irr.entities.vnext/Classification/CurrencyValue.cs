
namespace aerp.modules.irr.entities.Classification
{
	using entities;
	using System;

	/// <summary>
	/// Значение курса валюты относительно базовогй валюты
	/// </summary>
	public class CurrencyValue : EntityBase
    {
		/// <summary>
		/// Идентификатор валюты
		/// </summary>
        public int CurrencyId { get; set; }
		/// <summary>
		/// Валюта
		/// </summary>
        public Currency Currency { get; set; }
		/// <summary>
		/// Дата значения курса
		/// </summary>
        public DateTime ValueDate { get; set; }
		/// <summary>
		/// Значение
		/// </summary>
        public decimal Value { get; set; }
    }
}
