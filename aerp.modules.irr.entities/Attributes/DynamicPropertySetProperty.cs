
namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Свойство в наборе динамических свойств
	/// </summary>
	public class DynamicPropertySetProperty : EntityBase
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
		/// Динамическое свойство
		/// </summary>
        public DynamicProperty DynamicProperty { get; set; }
		/// <summary>
		/// Идентификатор динамического свойства
		/// </summary>
        public int DynamicPropertyId { get; set; }
    }
}
