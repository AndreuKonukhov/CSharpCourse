
namespace ModelView
{
    public static class Utils
    {
        /// <summary>
        /// Метод позволяющий вводить только
        /// числа, запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckAge(KeyPressEventArgs e)
        {
            int backSpace = 8;

            //цифры, знак "-" и клавиша BackSpace
            char number = e.KeyChar;
            if ((e.KeyChar <= '0' ||
                e.KeyChar >= '9') &&
                number != backSpace &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

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
