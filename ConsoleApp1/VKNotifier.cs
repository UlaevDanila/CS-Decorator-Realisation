class VKNotifier
{

    private static string message = "I'm VK notifier";
    private NotifierDecorator notifiy = new NotifierDecorator(message);

    public VKNotifier(NotifierDecorator notifiy)
    {
        this.notifiy = notifiy;
        this.notifiy.setMessage(message);
    }

    public void sendMessage()
    {
        notifiy.sendMessage();
    }
}
