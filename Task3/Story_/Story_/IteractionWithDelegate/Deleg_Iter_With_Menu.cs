using Story;



namespace Story_.IteractionWithDelegate
{
     class Deleg_Iter_With_Menu
    {
        public delegate void DelIterWithWashbasin(string message);
        public DelIterWithWashbasin Notife;
        public void Action_Menu() 
        {
            Notife += DisplayMessage;
            Notife?.Invoke("\t\t\tIf you want to start reading click or exit(enter / esc): ");
        }
        private void DisplayMessage(string message) 
        {
            System.Console.WriteLine(message);        
        }
    }
}
