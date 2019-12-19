using System;
using Story_.IteractionWithDelegate;
using System.Threading;



namespace Story_.ActionM_V_T
{
    
     public class Action_with_text 
    {

        
        public static void Action()
        {

            ConsoleKeyInfo input;
            do
            {

                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    ErrorMessage error = MessageQuit;
                    error?.Invoke();

                    Environment.Exit(0);

                }

                else if (input.Key == ConsoleKey.Enter)
                {
                    ErrorMessage error = MessageSuccess;
                    error?.Invoke();
                    Thread.Sleep(600);
                }
                else 
                {
                    ErrorMessage error = MessageError;
                    error?.Invoke();
                    

                    Environment.Exit(0);
                }
            } while (input.Key != ConsoleKey.Enter);
            
            Console.Clear();
        }

        public static void MessageError() => Console.WriteLine("\t\t\tYou don't click enter ");
        public static void MessageQuit() => Console.WriteLine("\t\t\tExit");
        public static void MessageSuccess() => Console.WriteLine("\t\t\tSuccess");


    }
    
}
