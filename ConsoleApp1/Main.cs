class Program
{
    public static void Main()
    {
        NotifierDecorator test = new NotifierDecorator("I'm base decorator");
        Console.WriteLine("Enter notify method");
        string notifyMethod = Console.ReadLine();

        while (notifyMethod != null)
        {
            switch (notifyMethod)
            {

                case "email":
                    {
                        EmailNotifier notifier = new EmailNotifier(test);
                        notifier.sendMessage();
                        break;
                    }

                case "VK":
                    {
                        VKNotifier notifier = new VKNotifier(test);
                        notifier.sendMessage();
                        break;
                    }
                case "phone":
                    {
                        PhoneNotifier notifier= new PhoneNotifier(test);
                        notifier.sendMessage();
                        break;
                    }

                case "":
                    notifyMethod = null;
                    break;

                default:
                    {
                        Console.WriteLine("Please retry");
                        break;
                    }
            }
            if (notifyMethod != null) 
            {
                Console.WriteLine("Enter notify method");
                notifyMethod = Console.ReadLine();
            }

        }
    }
}