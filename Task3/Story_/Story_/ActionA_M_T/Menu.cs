using System;
using Story_.IteractionWithDelegate;


namespace Story_.ActionM_V_T
{
    class Menu
    {
        
        public static void Title()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t _______________________");
            Console.WriteLine("\t\t\t\t\t|                       |");
            Console.WriteLine("\t\t\t\t\t|       Мойдодыр        |");
            Console.WriteLine("\t\t\t\t\t|_______________________|");
            Console.WriteLine();
            Deleg_Iter_With_Menu deleg_Iter_With_Menu = new Deleg_Iter_With_Menu();
            
            deleg_Iter_With_Menu.Action_Menu();
            
        }
    }
}
