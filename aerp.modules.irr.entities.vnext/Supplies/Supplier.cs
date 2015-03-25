
namespace aerp.modules.irr.entities.Supplies
{
	using Classification;
	using global::System;

	/// <summary>
	/// Поставщик
	/// </summary>
	public class Supplier : Contractor
    {
        public Supplier()
        {
        }

		/// <summary>
		/// Сайт поставщика
		/// </summary>
        public string Site { get; set; }

		/// <summary>
		/// (Основной государственный регистрационный номер - ОГРН)
		/// </summary>
		public string PSRN { get; set; }//Primary state registration number (Основной государственный регистрационный номер - ОГРН)
		/// <summary>
		/// (Идентификационный номер налогоплательщика - ИНН)
		/// </summary>
		public string TIN { get; set; }//Taxpayer identification number (Идентификационный номер налогоплательщика - ИНН)
		/// <summary>
		/// (Код причины постановки на учёт - КПП)
		/// </summary>
		public string RRC { get; set; }//Reason for registration code (Код причины постановки на учёт - КПП)
		/// <summary>
		///  (Общероссийский классификатор предприятий и организаций - ОКПО)
		/// </summary>
		public string NCEO { get; set; }//National Classification of enterprises and organizations (Общероссийский классификатор предприятий и организаций - ОКПО)
		/// <summary>
		/// (Общероссийский классификатор объектов административно-территориального деления - ОКАТО)
		/// </summary>
		public string NCATD { get; set; }//National Classification of administrative and territorial division (Общероссийский классификатор объектов административно-территориального деления - ОКАТО)
		/// <summary>
		/// Идентификатор фактического адреса
		/// </summary>
        public int? FactAddressId { get; set; }
		/// <summary>
		/// Идентификатор почтового адреса
		/// </summary>
        public int? PostAddressId { get; set; }
		/// <summary>
		/// Фактический адрес
		/// </summary>
        public Address FactAddress { get; set; }//Фактический адрес местонахождения
		/// <summary>
		/// Почтовый адрес
		/// </summary>
        public Address PostAddress { get; set; }//Почтовый адрес
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
		/// Свидетельство о постановке (ИП)
		/// </summary>
		public string PrivateEvidenceDocument { get; set; }
		/// <summary>
		/// Дата свидетельства о постановке (ИП)
		/// </summary>
		public DateTime PrivateEvidenceDocumentDate { get; set; }

        //Ответственные лица
		/// <summary>
		/// Руководитель
		/// </summary>
        public string Head { get; set; }
		/// <summary>
		/// Долженность руководителя
		/// </summary>
        public string HeadPosition { get; set; }
		/// <summary>
		/// Телефон руководителя
		/// </summary>
        public string HeadPhone { get; set; }
		/// <summary>
		/// Главный бухгалтер
		/// </summary>
        public string ChiefAccountant { get; set; }
		/// <summary>
		/// Телефон главного бухгалтера
		/// </summary>
        public string ChiefAccountantPhone { get; set; }
		/// <summary>
		/// Менеджер
		/// </summary>
        public string Manager { get; set; }
		/// <summary>
		/// Телефно менеджера
		/// </summary>
        public string ManagerPhone { get; set; }
		/// <summary>
		/// Дополнительная информация
		/// </summary>
        public string Description { get; set; }

    }
}
