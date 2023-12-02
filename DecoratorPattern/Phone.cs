namespace DecoratorPattern
{
    public class Phone
    {
        public void Start() 
        {
            Console.WriteLine($"{GetType().Name} is starting");
        }

        public void Stop()
        {
            Console.WriteLine($"{GetType().Name} is stoping");
        }

        public void OpenLockScreen()
        {
            Console.WriteLine($"{GetType().Name} , Lock Screen opened");
        }

        public void CloseLockScreen()
        {
            Console.WriteLine($"{GetType().Name} , Lock Screen closed");
        }
    }


    public class PhoneDecorator:Phone
    {
        public virtual void OpenLockScreen()
        {
            base.OpenLockScreen();
            // so something
        }

        public virtual void CloseLockScreen()
        {
            // so something
            base.CloseLockScreen();

        }
    }

    public class SamsunPhone : PhoneDecorator
    {
        public override void CloseLockScreen()
        {
            base.CloseLockScreen();
            Console.WriteLine("SamsunPhone's screen is closed");
        }

        public override void OpenLockScreen()
        {
            Console.WriteLine("SamsunPhone's screen is opening");
            base.OpenLockScreen();
        }
    }

    public class BananaPhone : PhoneDecorator
    {
       
    }
}
