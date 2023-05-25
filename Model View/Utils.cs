
namespace ModelView
{
    //TODO(+): XML
    /// <summary>
    /// Класс Utils
    /// </summary>
    public static class Utils
    {
        //TODO: duplication
        /// <summary>
        /// Метод позволяющий вводить только
        /// числа, запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckInput(KeyPressEventArgs e,
            List<char> dopSimvol = null)
        {
            dopSimvol ??= new List<char>();
            int backSpace = 8;

            //цифры, знак "-" и клавиша BackSpace
            var number = e.KeyChar;
            if ((number <= '0' ||
                number >= '9') &&
                number != backSpace &&
                dopSimvol.Contains(number))
            {
                e.Handled = true;
            }
        }
    }
}
