
namespace aerp.modules.irr.entities.Classification
{
	using entities;

	/// <summary>
	/// Значение абстрактного свойства
	/// </summary>
	public class SubjectAttributeValue : EntityBase
    {
		/// <summary>
		/// Идентификатор абстрактоного свойства
		/// </summary>
        public int SubjectAttributeId { get; set; }
		/// <summary>
		/// Абстрактное свойство
		/// </summary>
        public SubjectAttribute SubjectAttribute { get; set; }
		/// <summary>
		/// Пользовательское представление значения
		/// </summary>
        public string ValueRepresentation { get; set; }
		/// <summary>
		/// Возвращает значение абстрактного свойства строго заданного типа
		/// </summary>
		/// <typeparam name="T">Тип параметр</typeparam>
		/// <param name="subjectAttributeType">Тип абстрактного свойства</param>
		/// <returns>Строго типизированное значение абстрактного свойства</returns>
        public T GetValue<T>(SubjectAttributeType subjectAttributeType)
        {
            return default(T);
        }
		/// <summary>
		/// Идентификатор связи
		/// </summary>
        public int? LinkedId { get; set; }
    }
}
