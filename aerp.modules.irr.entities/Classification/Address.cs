 
namespace aerp.modules.irr.entities.Classification
{
	using entities;
	using global::System.Text;

	/// <summary>
	/// Адрес
	/// </summary>
    public class Address : EntityBase
    {
		/// <summary>
		/// Страна
		/// </summary>
        public string Country { get; set; }
		/// <summary>
		/// Край/область
		/// </summary>
        public string State { get; set; }
		/// <summary>
		/// Регион
		/// </summary>
        public string Region { get; set; }
		/// <summary>
		/// Город
		/// </summary>
        public string City { get; set; }
		/// <summary>
		/// Улица
		/// </summary>
        public string Street { get; set; }
		/// <summary>
		/// Дом
		/// </summary>
        public string Building { get; set; }
		/// <summary>
		/// Строение/корпус
		/// </summary>
        public string Housing { get; set; }
		/// <summary>
		/// Квартира/офис/комната
		/// </summary>
        public string Room { get; set; }
		/// <summary>
		/// Почтовый индекс
		/// </summary>
        public string Zip { get; set; }
		/// <summary>
		/// Дополнительная информация по адресу
		/// </summary>
        public string Additional { get; set; }

        #region Overrides of Object

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>
        /// Строка, представляющая текущий объект.
        /// </returns>
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            if (!string.IsNullOrEmpty(Zip))
            {
                b.Append(Zip);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Country))
            { 
                b.Append(Country);         
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(State))
            {
                b.Append(State);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(City))
            {
                b.Append("г. ");
                b.Append(City);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Region))
            {
                b.Append(Region);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Street))
            {
                b.Append("ул. ");
                b.Append(Street);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Building))
            {
                b.Append("д. ");
                b.Append(Building);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Housing ))
            {
                b.Append("корп. ");
                b.Append(Housing);
                b.Append(", ");
            }
            if (!string.IsNullOrEmpty(Room))
            {
                b.Append("кв. ");
                b.Append(Room);
                b.Append(", ");
            }

            if (b.ToString().EndsWith(", "))
                b.Replace(", ", "", b.Length - 2, 2);

            return b.ToString();
        }

        #endregion
    }
}
