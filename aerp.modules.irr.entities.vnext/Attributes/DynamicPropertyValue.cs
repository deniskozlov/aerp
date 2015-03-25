
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Значение динамического свойства
	/// </summary>
	public class DynamicPropertyValue : EntityBase
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
		/// Значение динамического свойства (если простой тип, не ссылка)
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Тип сущности (Ссылка, на которую, явзяется значением динамического свойства
		/// </summary>
        public EntityType EntityType { get; set; }
		/// <summary>
		/// Идентификатор Типа сущности
		/// </summary>
        public int EntityTypeId { get; set; }
		/// <summary>
		/// Идентификатор сущности
		/// </summary>
        public int EntityId { get; set; }
    }
}
