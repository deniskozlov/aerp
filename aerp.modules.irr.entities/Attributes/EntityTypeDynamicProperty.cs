
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Тип сущности к которому прикреплено динамческое свойство
	/// </summary>
	public class EntityTypeDynamicProperty : EntityBase
    {
		/// <summary>
		/// Динамическое свойство
		/// </summary>
        public DynamicProperty DynamicProperty { get; set; }
		/// <summary>
		/// Идентификатор динамического свойства
		/// </summary>
        public int DynamicPropertyId { get; set; }
		/// <summary>
		/// Тип сущности
		/// </summary>
        public EntityType EntityType { get; set; }
		/// <summary>
		/// Идентификатор типа сущности
		/// </summary>
        public int EntityTypeId { get; set; }
    }
}
