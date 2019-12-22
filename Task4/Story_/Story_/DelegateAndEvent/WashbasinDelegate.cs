
namespace Story_.DelegateAndEvent
{
    public delegate string WashbasinDelegate_();
    public class ClassWashbasinDelegate
    {
        public event WashbasinDelegate_ WashbasinEvent_;

        public virtual void InfoEventWashbasin() 
        {
            WashbasinEvent_();
        }
    }
}
