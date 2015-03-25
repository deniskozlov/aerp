
namespace aerp.modules.irr.entities.Production
{
	using entities;

	/// <summary>
	/// Товарная группа
	/// </summary>
	public class ProductGroup : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Идентификатор родительской группы
		/// </summary>
        public int? ParentId { get; set; }
		/// <summary>
		/// Родительская группа
		/// </summary>
        public virtual ProductGroup Parent { get; set; }

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
