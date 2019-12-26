
namespace Story_.IteractionWithDelegate
{
    public delegate void ErrorMessage();
    public class ClassIteracWithDeleg 
    {
        public event ErrorMessage ErrorEvent;

        public void EventErrorMessage() 
        {
            ErrorEvent();
        }
        
    }


}
