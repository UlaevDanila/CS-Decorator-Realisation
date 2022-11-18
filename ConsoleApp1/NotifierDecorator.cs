using System;

class NotifierDecorator : Notifier
{
    private string message;

    public NotifierDecorator(string message)
    {
        this.message = message;
    }
    public void sendMessage()
    {
        Console.WriteLine(message);
    }

    public void setMessage(string message)
    {
        this.message = message;
    }

    public string getMessage(string message)
    {
        return this.message;
    }
}