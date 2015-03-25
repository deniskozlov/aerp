
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Тип сущности к которому присоединен набор динамических свойств
	/// </summary>
	public class EntityTypeAvailableDynamicPropertySet : EntityBase
    {
		/// <summary>
		/// Набор динамических свойств
		/// </summary>
        public DynamicPropertySet DynamicPropertySet { get; set; }
		/// <summary>
		/// Идентификатор набора динамических свойств
		/// </summary>
        public int DynamicPropertySetId { get; set; }
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
