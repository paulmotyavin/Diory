
namespace DATE
{
    public class DATE
    {
        DateTime date;
        public DATE()
        {
            DateTime date = DateTime.Now;
            date.ToString();
            date = date.Date;
            date.ToString();

        }
        public DateTime Date() { return date; }
    }
}

   
