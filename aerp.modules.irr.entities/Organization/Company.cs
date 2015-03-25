
namespace aerp.modules.irr.entities.Organization
{
	using entities;
	using Classification;
	using System;

	/// <summary>
	/// Организация
	/// </summary>
	public class Company : EntityBase
    {
        public Company()
        {
        }

		/// <summary>
		/// Название
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Полное название
		/// </summary>
        public string FullName { get; set; }
		/// <summary>
		/// Префикс (для распределения данных)
		/// </summary>
		public string Prefix { get; set; }

		//Реквизиты
		/// <summary>
		/// ОГРН (Основной государственный регистрационный номер)
		/// </summary>
		public string PSRN { get; set; }//Primary state registration number (Основной государственный регистрационный номер - ОГРН)
		/// <summary>
		/// ИНН (Идентификационный номер налогоплательщика)
		/// </summary>
		public string TIN { get; set; }//Taxpayer identification number (Идентификационный номер налогоплательщика - ИНН)
		/// <summary>
		/// КПП (Код причины постановки на учёт)
		/// </summary>
		public string RRC { get; set; }//Reason for registration code (Код причины постановки на учёт - КПП)
		/// <summary>
		/// ОКПО (Общероссийский классификатор предприятий и организаций)
		/// </summary>
		public string NCEO { get; set; }//National Classification of enterprises and organizations (Общероссийский классификатор предприятий и организаций - ОКПО)
		/// <summary>
		/// ОКАТО (Общероссийский классификатор объектов административно-территориального деления)
		/// </summary>
		public string NCATD { get; set; }//National Classification of administrative and territorial division (Общероссийский классификатор объектов административно-территориального деления - ОКАТО)
		/// <summary>
		/// ЕНВД (Единый налог на вменённый доход)
		/// </summary>
		public bool IsSTII { get; set; }//Single tax on imputed income (Единый налог на вменённый доход - ЕНВД)


		/// <summary>
		/// Адрес регистрации
		/// </summary>
        public Address RegistrationAddress { get; set; }
		/// <summary>
		/// Фактический адрес
		/// </summary>
        public Address FactAddress { get; set; }
		/// <summary>
		/// Почтовый адрес
		/// </summary>
        public Address PostAddress { get; set; }
		/// <summary>
		/// Идентификатор адреса регистрации
		/// </summary>
        public int? RegistrationAddressId { get; set; }
		/// <summary>
		/// Идентификатор фактического адреса
		/// </summary>
        public int? FactAddressId { get; set; }
		/// <summary>
		/// Идентификатор почтового адреса
		/// </summary>
        public int? PostAddressId { get; set; }

        //Контакты
		/// <summary>
		/// Сайт
		/// </summary>
        public string Site { get; set; }
		/// <summary>
		/// Email
		/// </summary>
        public string Email { get; set; }
		/// <summary>
		/// Телефон 1
		/// </summary>
        public string Phone1 { get; set; }
		/// <summary>
		/// Телефон 2
		/// </summary>
        public string Phone2 { get; set; }
		/// <summary>
		/// Форма собственности
		/// </summary>
        public BusinessTypes BusinessType { get; set; }

		//Для ИП
		/// <summary>
		/// Имя (ИП)
		/// </summary>
		public string PrivateFirstName { get; set; }
		/// <summary>
		/// Отчество (ИП)
		/// </summary>
		public string PrivateSecondName { get; set; }
		/// <summary>
		/// Фамилия (ИП)
		/// </summary>
		public string PrivateLastName { get; set; }
		/// <summary>
		/// Документ, удостоверяющий личность (ИП)
		/// </summary>
		public string PrivateEvidenceDocument { get; set; }
		/// <summary>
		/// Дата документа (ИП)
		/// </summary>
		public DateTime PrivateEvidenceDocumentDate { get; set; }

  //      //Ответственные лица
		///// <summary>
		///// Руководитель
		///// </summary>
  //      public Employee Head { get; set; }
		///// <summary>
		///// Главный бухгалтер
		///// </summary>
  //      public Employee ChiefAccountant { get; set; }
		///// <summary>
		///// 
		///// </summary>
  //      public Employee Cashier { get; set; }
		///// <summary>
		///// 
		///// </summary>
  //      public int? HeadId { get; set; }
		///// <summary>
		///// 
		///// </summary>
  //      public int? ChiefAccountantId { get; set; }
		///// <summary>
		///// 
		///// </summary>
  //      public int? CashierId { get; set; }

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
