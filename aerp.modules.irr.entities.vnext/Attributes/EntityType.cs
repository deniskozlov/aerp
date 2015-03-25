
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Тип сущности на которую может быть ссылка в значении динамического свойства (ссылочный тип)
	/// </summary>
	public class EntityType : EntityBase
    {
		/// <summary>
		/// Название сущности
		/// </summary>
        public string EntityTypeName { get; set; }
		/// <summary>
		/// Полное название типа в среде CLR
		/// </summary>
        public string ClrTypeName { get; set; }
    }
}
