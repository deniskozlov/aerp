
namespace aerp.modules.irr.entities
{
	/// <summary>
	/// Базовый объект
	/// </summary>
	public abstract class EntityBase
    {
		/// <summary>
		/// Идентификатор
		/// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Штамп уникальности
		/// </summary>
        public byte[] RowVersion { get; set; }
		/// <summary>
		/// Копирование объекта
		/// </summary>
		/// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
