
namespace aerp.modules.irr.entities.Attributes
{
	/// <summary>
	/// Тип значения динамического свойства
	/// </summary>
	public enum DynamicPropertyType
    {
		/// <summary>
		/// Строка
		/// </summary>
        String,
		/// <summary>
		/// Вещественное число
		/// </summary>
        Double,
        /// <summary>
		/// Большое вещественное число
		/// </summary>
        Decimal,
        /// <summary>
		/// Целое число
		/// </summary>
        Integer,
        /// <summary>
		/// Большое целое число
		/// </summary>
        Long,
        /// <summary>
		/// Дата/время
		/// </summary>
        DateTime,
        /// <summary>
		/// Да/нет
		/// </summary>
        Boolean,
        /// <summary>
		/// Из списка значений
		/// </summary>
        Enum
    }
}
