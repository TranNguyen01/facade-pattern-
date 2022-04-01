public class NotificationService {
    public void sendEmail(String mailTo){
        Console.WriteLine("Sending an email to " + mailTo);
    }

    public void sendSmS(string smsTo){
         Console.WriteLine("Sending sms to " + smsTo);
    }
}