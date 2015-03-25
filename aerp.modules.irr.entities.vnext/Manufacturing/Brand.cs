
namespace aerp.modules.irr.entities.Manufacturing
{
	using entities;

	/// <summary>
	/// Брэнд
	/// </summary>
	public class Brand : EntityBase
    {
		/// <summary>
		/// Название бренда
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Идентификатор производителя
		/// </summary>
        public int ManufacturerId { get; set; }
		/// <summary>
		/// Производитель
		/// </summary>
        public virtual Manufacturer Owner { get; set; }

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
