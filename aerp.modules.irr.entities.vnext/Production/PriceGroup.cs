
namespace aerp.modules.irr.entities.Production
{
	using entities;

	/// <summary>
	/// Ценовая группа товаров
	/// </summary>
	public class PriceGroup : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }

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
