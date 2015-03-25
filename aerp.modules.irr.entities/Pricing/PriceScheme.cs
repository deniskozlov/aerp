
namespace aerp.modules.irr.entities.Pricing
{
	using entities;

	/// <summary>
	/// Схема ценообразования
	/// </summary>
	public class PriceScheme : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Авторассчитываемая
		/// </summary>
        public bool IsAutoApplied { get; set; }
		/// <summary>
		/// Вид ценообразования
		/// </summary>
        public PriceShcemeKinds PricesKind { get; set; }
    }
}
