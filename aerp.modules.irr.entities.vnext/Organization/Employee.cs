

namespace aerp.modules.irr.entities.Organization
{
	using entities;
	using Classification;
	using System;

	/// <summary>
	/// Сотрудник
	/// </summary>
	public class Employee : EntityBase
    {
		/// <summary>
		/// Персональный номер (ПФР)
		/// </summary>
		public string PersonnelNumber { get; set; }
		/// <summary>
		/// Имя
		/// </summary>
        public string FirstName { get; set; }
		/// <summary>
		/// Отчество
		/// </summary>
        public string SecondName { get; set; }
		/// <summary>
		/// Фамилия
		/// </summary>
		public string LastName { get; set; }
		/// <summary>
		/// Дата рождения
		/// </summary>
        public DateTime DOB { get; set; }
		/// <summary>
		/// Пол
		/// </summary>
        public Genders Gender { get; set; }
		/// <summary>
		/// Адрес регистрации
		/// </summary>
        public Address RegistrationAddress { get; set; }
		/// <summary>
		/// Адрес фактического проживания
		/// </summary>
        public Address FactAddress { get; set; }
		/// <summary>
		/// Идентификатор адреса регистрации
		/// </summary>
        public int? RegistrationAddressId { get; set; }
		/// <summary>
		/// Идентификатор адреса фактического проживания
		/// </summary>
        public int? FactAddressId { get; set; }

		/// <summary>
		/// Телефон
		/// </summary>
        public string Phone { get; set; }
		/// <summary>
		/// Email
		/// </summary>
        public string Email { get; set; }
		/// <summary>
		/// Долженность
		/// </summary>
        public Position EmployeePosition { get; set; }
		/// <summary>
		/// Идентификатор долженности
		/// </summary>
        public int EmployeePositionId { get; set; }
		/// <summary>
		/// Отдел
		/// </summary>
        public Department EmployeeDepartment { get; set; }
		/// <summary>
		/// Идентификатор отдела
		/// </summary>
        public int EmployeeDepartmentId { get; set; }

		/// <summary>
		/// Торговая точка, с которой связан сотрудник
		/// </summary>
        public Store EmployeeStore { get; set; }
		/// <summary>
		/// Идентификатор торговой точки
		/// </summary>
        public int? EmployeeStoreId { get; set; }
		/// <summary>
		/// Документ, удостоверяющий личность
		/// </summary>
        public string EvidenceDocument { get; set; }
		/// <summary>
		/// ИНН
		/// </summary>
        public string TIN { get; set; }

        #region Overrides of Object

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>
        /// Строка, представляющая текущий объект.
        /// </returns>
        public override string ToString()
        {
            return FirstName + " " + SecondName + " " + LastName;
        }

        #endregion
    }
}
