//A thread-safe double checking singleton class java program
class Singleton {
    private volatile static Singleton _instance;
    public String s;
    private Singleton() {
        // preventing Singleton object instantiation from outside
        s="string set in the class";
    }
    //double locking
    public static Singleton getInstance() { if (_instance == null) {
        synchronized (Singleton.class) {
            if (_instance == null) {
                _instance = new Singleton(); }
        }
    }
    return _instance;
    }
}

public class Main
{
    public static void main(String args[])
    {

        Singleton obj1 = Singleton.getInstance();
        Singleton obj2 = Singleton.getInstance();
        Singleton obj3 = Singleton.getInstance();

        obj1.s = (obj1.s).toUpperCase();

        System.out.println("String from obj1 is " + obj1.s);
        System.out.println("String from obj2 is " + obj2.s);
        System.out.println("String from obj3 is " + obj3.s);
        System.out.println("\n");

        obj3.s = (obj3.s).toLowerCase();

        System.out.println("String from obj1 is " + obj1.s);
        System.out.println("String from obj2 is " + obj2.s);
        System.out.println("String from obj3 is " + obj3.s);
        System.out.println("\n");
    }
}



