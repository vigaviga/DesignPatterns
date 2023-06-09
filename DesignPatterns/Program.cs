

//Non thread safe singleton
public class Singleton
{
    private static Singleton uniqueInstance = null;
    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (uniqueInstance  == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }
}

//Tread safe singleton using lock
public class SingletonWithLock
{
    private static Object lockObj = new Object();
    private volatile static SingletonWithLock uniqueInstance = null;
    private SingletonWithLock() { }

    public static SingletonWithLock GetInstance()
    {
        if (uniqueInstance == null)
        {
            lock(lockObj)
            {
                if(uniqueInstance == null)
                {
                    uniqueInstance = new SingletonWithLock();
                }
            }
        }
        return uniqueInstance;
    }
}

//Thread safe singleton without lock
public class SingletonNoLock
{
    private static readonly SingletonNoLock uniqueInstance = new SingletonNoLock();

    private SingletonNoLock() { }

    public static SingletonNoLock GetInstance => uniqueInstance;
}