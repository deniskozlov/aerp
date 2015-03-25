
namespace aerp.modules.irr.entities.Organization
{
	using entities;

	/// <summary>
	/// Кассовый аппарат
	/// </summary>
	public class CashRegister : EntityBase
    {
		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Торговая точка
		/// </summary>
        public Store Store { get; set; }
		/// <summary>
		/// Идентификатор торговой точки
		/// </summary>
		public int? StoreId { get; set; }

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
