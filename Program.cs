using System;

class main
{
    public static void Main(String[] args)
    {
        String getHello = checkHello.HelloWorld.getHelloWorld("Deepak");
        
        System.Console.WriteLine("Hi, i am " + getHello);
    }
}

namespace checkHello
{
    class HelloWorld
    {

        public static string getHelloWorld(string name)
        {
            return name+" kumar";
        }
    }
}