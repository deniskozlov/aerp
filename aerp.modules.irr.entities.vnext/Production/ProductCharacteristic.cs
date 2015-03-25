
namespace aerp.modules.irr.entities.Production
{
	using Attributes;
	using entities;

	/// <summary>
	/// Характеристика товара
	/// </summary>
	public class ProductCharacteristic : EntityBase
    {
		/// <summary>
		/// Набор динамических свойств
		/// </summary>
        public DynamicPropertySet DynamicPropertySet { get; set; }
		/// <summary>
		/// Идентификатор набора динамических свойств
		/// </summary>
        public int? DynamicPropertySetId { get; set; }
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
    }
}
