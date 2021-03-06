﻿
namespace aerp.modules.irr.entities.Organization
{
	using entities;

	/// <summary>
	/// Торговая точка
	/// </summary>
    public class Store : EntityBase
    {
        public Store()
        {
        }

		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Идентификатор организации
		/// </summary>
        public int CompanyId { get; set; }
		/// <summary>
		/// Организация
		/// </summary>
        public Company Company { get; set; }

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
