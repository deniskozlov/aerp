
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Значение из списка значений для динамическогог свойства
	/// </summary>
	public class DynamicPropertyEnumValue : EntityBase
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
		/// Значение свойства
		/// </summary>
        public string Value { get; set; }

    }
}
