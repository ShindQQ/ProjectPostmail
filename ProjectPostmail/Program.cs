using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPostmail
{
    // посмотреть оформление посылок на новой почте 
    // разделить классы на файлы 
    // закрытые с маленькой буквы или с _
    // открытые с большой буквы 
    // закрытые не имеет смысла делать свойствами

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
