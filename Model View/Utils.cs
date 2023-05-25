
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
        public static void CheckInput(KeyPressEventArgs e)
        {
            int backSpace = 8;

            //цифры, знак "-" и клавиша BackSpace
            char number = e.KeyChar;
            if ((number <= '0' ||
                number >= '9') &&
                number != backSpace &&
                number != '-')
            {
                e.Handled = true;
            }
        }

        //TODO: duplication
        /// <summary>
        /// Метод позволяющий вводить только
        /// числа, запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckPage(KeyPressEventArgs e)
        {
            int backSpace = 8;


            //цифры, клавиша BackSpace и запятая а ASCII
            char number = e.KeyChar;
            if ((e.KeyChar <= '0' || e.KeyChar >= '9')
                && number != backSpace)
            {
                e.Handled = true;
            }
        }
    }
}
