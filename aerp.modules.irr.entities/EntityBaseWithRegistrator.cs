
namespace aerp.modules.irr.entities
{
	using System;

	/// <summary>
	/// Объект, у которого есть регистрирующий родительский объект (документ)
	/// </summary>
	public abstract class EntityBaseWithRegistrator : EntityBase
	{
		/// <summary>
		/// Тип регистратора
		/// </summary>
		public string RegistratorType { get; set; }

		/// <summary>
		/// Идентификатор регистратора
		/// </summary>
		public int? RegistratorId { get; set; }

		/// <summary>
		/// Дата регистрации
		/// </summary>
		public DateTime RegistrationDate { get; set; }
	}
}
