
namespace aerp.modules.irr.entities.Classification
{
	using entities;

	/// <summary>
	/// Участник сделки
	/// </summary>
	public class Contractor : EntityBase
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
		/// Идентификатор адреса
		/// </summary>
        public int? AddressId { get; set; }
		/// <summary>
		/// Адрес
		/// </summary>
        public Address Address { get; set; }
		/// <summary>
		/// Телефон 1
		/// </summary>
        public string Phone1 { get; set; }
		/// <summary>
		/// Телефон 2
		/// </summary>
        public string Phone2 { get; set; }
		/// <summary>
		/// email
		/// </summary>
        public string Email { get; set; }

    }
}
