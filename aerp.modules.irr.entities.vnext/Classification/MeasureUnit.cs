
namespace aerp.modules.irr.entities.Classification
{
	using entities;

	/// <summary>
	/// Единица измерения
	/// </summary>
	public class MeasureUnit : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Полное название
		/// </summary>
        public string FullName { get; set; }
		/// <summary>
		/// Международное название
		/// </summary>
        public string InternationalName { get; set; }
		/// <summary>
		/// Международное полное название
		/// </summary>
        public string InternationalFullName { get; set; }
		/// <summary>
		/// Идентификатор базовой единицы измерения
		/// </summary>
        public int? BaseUnitId { get; set; }
		/// <summary>
		/// Базовая единица измерения
		/// </summary>
        public MeasureUnit BaseUnit { get; set; }
		/// <summary>
		/// Коэффициент, относительно базовой единицы
		/// </summary>
        public decimal Coefficient { get; set; }
		/// <summary>
		/// Значение относительно базовой единицы
		/// </summary>
        public int Rate { get; set; }

        #region Overrides of Object

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>
        /// Строка, представляющая текущий объект.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
