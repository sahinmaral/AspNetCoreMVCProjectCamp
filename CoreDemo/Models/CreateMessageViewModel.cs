namespace CoreDemo.Models
{
    public class CreateMessageViewModel : BaseViewModel
    {
        public ReadUserViewModel Sender { get; set; }
        public ReadUserViewModel Receiver { get; set; }

        public string Subject { get; set; }
        public string Detail { get; set; }
    }
}
