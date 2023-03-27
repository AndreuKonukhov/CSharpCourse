
namespace Model
{
    /// <summary>
    /// Класс описывающий взрослого человека.
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Информация о паспортных данных.
        /// </summary>
        private int _passportInfo;

        /// <summary>
        /// Семейный статус человека.
        /// </summary>
        private Adult _familyStatus;

        /// <summary>
        /// Место работы человека.
        /// </summary>
        private string _placeWork;

        /// <summary>
        /// Минимальный возраст взрослого человека.
        /// </summary>
        private const int MinAgeAdult = 18;

        /// <summary>
        /// Нижняя граница диапазона номеров паспортов.
        /// </summary>
        private const int PassportLowNumber = 100000;

        /// <summary>
        /// Верхняя граница диапазона номеров паспортов.
        /// </summary>
        private const int PassportHighNumber = 999999;
    }
}
