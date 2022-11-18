class EmailNotifier
{

    private static string message = "I'm email notifier";
    private NotifierDecorator notifiy = new NotifierDecorator(message);

    public EmailNotifier(NotifierDecorator notifiy)
    {
        this.notifiy = notifiy;
        this.notifiy.setMessage(message);
    }

    public void sendMessage()
    {
        notifiy.sendMessage();
    }
}