
namespace aerp.modules.irr.entities.Production
{
	using Attributes;
	using entities;

	/// <summary>
	/// Вид товара
	/// </summary>
    public class ProductKind : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Набор динамических свойств
		/// </summary>
        public DynamicPropertySet DynamicPropertySet { get; set; }
		/// <summary>
		/// Идентификатор набора динамических свойств
		/// </summary>
        public int? DynamicPropertySetId { get; set; }
		/// <summary>
		/// Изпользовать характеристики
		/// </summary>
        public bool UseCharacteristic { get; set; }


		#region Overrides of Object

		/// <summary>
		/// Возвращает строку, представляющую текущий объект.
		/// </summary>
		/// <returns>
		/// Строка, представляющая текущий объект.
		/// </returns>
		public override string ToString()
		{
			return string.Format("{0}", Name);
		}

		#endregion
	}
}
