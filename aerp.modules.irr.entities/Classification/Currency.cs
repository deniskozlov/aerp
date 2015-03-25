
namespace aerp.modules.irr.entities.Classification
{
	using entities;

	/// <summary>
	/// Валюта
	/// </summary>
	public class Currency : EntityBase
	{
		/// <summary>
		/// Международное название валюты
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Местное название валюты
		/// </summary>
		public string LocalName { get; set; }

		/// <summary>
		/// Идентификатор базовой валюты
		/// </summary>
		public int? BaseCurrencyId { get; set; }
		/// <summary>
		/// Базовая валюта
		/// </summary>
		public Currency BaseCurrency { get; set; }
	}
}
