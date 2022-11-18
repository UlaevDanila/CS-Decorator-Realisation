class PhoneNotifier
{

    private static string message = "I'm phone notifier";
    private NotifierDecorator notifiy = new NotifierDecorator(message);

    public PhoneNotifier(NotifierDecorator notifiy)
    {
        this.notifiy = notifiy;
        this.notifiy.setMessage(message);
    }

    public void sendMessage()
    {
        notifiy.sendMessage();
    }
}
