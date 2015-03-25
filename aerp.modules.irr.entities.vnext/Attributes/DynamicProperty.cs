

namespace aerp.modules.irr.entities.Attributes
{
	using entities;

	/// <summary>
	/// Динамическое свойство
	/// </summary>
	public class DynamicProperty : EntityBase
    {
		/// <summary>
		/// Название свойства
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Тип динамического свойства
		/// </summary>
        public DynamicPropertyType PropertyType { get; set; }
		/// <summary>
		/// Ссылочные тип значения (ссылка на другой объекта)
		/// </summary>
		public bool IsReference { get; set; }
		/// <summary>
		/// Ссылка на объект
		/// </summary>
        public string ReferenceTypeName { get; set; }
    }
}
