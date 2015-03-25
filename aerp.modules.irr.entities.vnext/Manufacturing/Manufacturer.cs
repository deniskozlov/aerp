
namespace aerp.modules.irr.entities.Manufacturing
{
	using Classification;

	/// <summary>
	/// Производитель товаров
	/// </summary>
    public class Manufacturer : Contractor
    {
		///// <summary>
		///// Список брендов производителя
		///// </summary>
  //      public IList<Brand> ManufacturingBrands { get; set; }

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
