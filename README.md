# CodeMixer

###Background
This is one of these projects that I put together form an idea form speaking to someone over at the coffee machine.

Where they say I wish.... 

When we encrypt our code I wish that all the public interfaces got renamed as well in all source files to make it harder for someone to understand whats going on in the code.

After a bit of thinking I cam up this as an idea and it works well for our code base.

###How It Works
The tool looks in the directory you give to find C# files, then it reads all the files to find all the methods, class names ect. The tool then generates a random name for each item and finds that name in all source files and then replaces the item with the new random name.

###Help out
If you want to help out please free, at some stage I would like to try and add VB.Net and C++

###Examples
Before

```namespace ConsoleApplication1
{
    public class SampleBefore
    {
        public SampleBefore() { }
        public string someProp { get; set; }
        public void somemethod() { }
        public void somemethod2(string t) { }
    }
    internal class sample2
    {
        private void somemothod3() { }
    }
    public interface someInterface
    {
        void testing();
    }
    public enum someEnum
    {
        SomeValue = 0,
        SomeMoreValue = 1
    }
    public class RealTest
    {
        public RealTest() { }
        private const string GreetingP1 = "hello";
        private const string GreetingP2 = "world";
        public void WriteGreeting()
        {
            Console.WriteLine("{0} {1}", GreetingP1, GetMessagePart());
        }
        public void EnumTest()
        {
            if(someEnum.SomeMoreValue == 0)
            {
                //do somthing
            }
            else if(someEnum.SomeValue == 0)
            {
                //do somthing
            }
        }
        private string GetMessagePart()
        {
            return GreetingP2;
        }
    }
}```

After

```namespace WiiDt0B2ZgToHqMgJfJZvNgpisOS73hpD3UEPnBPpQ212Y5P8bEbj3GofEOEt8J
{
    public class REhaYkXFKHRxVtSgPKwcq2HTWOmlSZ8W5qBn8eoNsl4
    {
        public REhaYkXFKHRxVtSgPKwcq2HTWOmlSZ8W5qBn8eoNsl4() { }
        public string IJgWFnpFZOskuqNGn352ZRtIQySBZyM7SRS5W9sV4YI { get; set; }
        public void IbM2SYNEM7yjZ33lhWIG5HeSCBrSfUkBZlWuFR7iSCt4() { }
        public void IbM2SYNEM7yjZ33lhWIG5HeSCBrSfUkBZlWuFR7iSCt42(string t) { }
    }
    internal class sample2
    {
        private void YT6lZffzcIIGwkLK5Zjosv679nekVAPoTybp1iFzuQ() { }
    }
    public interface someInterface
    {
        void Zyp9X0rzI3tgnXCqHrUA();
    }
    public enum A3McFLZB1AeaxIh1YRY9m9DGRFHQfm5jNIAg1WO79e0
    {
        VeOEQTi0ve8eMdeUh9QaRJrHgmfQEYvKyxlovIeojg8 = 0,
        G4Eoe9Kfh3825vltqwZ8QfYufzimRZgqp8JviPPgXKA = 1
    }
    public class Qsvv6qhZFn3nBEHGtWmy24211rPoywnsa54JsdiJimE
    {
        public Qsvv6qhZFn3nBEHGtWmy24211rPoywnsa54JsdiJimE() { }
        private const string AEegqZ82ko3NbrTv0KxnzFIYNh5PG8XND50vgbqpvo = "hello";
        private const string UEegqZ82ko3NbrTv0KxnzF1mz7HmhJjCgb5Fu6S2sYj4 = "world";
        public void PkPGBrHbsZPq6X0X6UFPJj4TAB5Bb3emZX1zp02Qfb8Y()
        {
            Console.WriteLine("{0} {1}", AEegqZ82ko3NbrTv0KxnzFIYNh5PG8XND50vgbqpvo, EQkktRdEe3wq7YQE7ls07jwLMI8xKGcDzYAXD2EGVaM());
        }
        public void WupSOfFkeHesCIYrZ7j1wlwamfuv19VX8rX45pI1I()
        {
            if (A3McFLZB1AeaxIh1YRY9m9DGRFHQfm5jNIAg1WO79e0.G4Eoe9Kfh3825vltqwZ8QfYufzimRZgqp8JviPPgXKA == 0)
            {
                //do somthing
            }
            else if (A3McFLZB1AeaxIh1YRY9m9DGRFHQfm5jNIAg1WO79e0.VeOEQTi0ve8eMdeUh9QaRJrHgmfQEYvKyxlovIeojg8 == 0)
            {
                //do somthing
            }
        }
        private string EQkktRdEe3wq7YQE7ls07jwLMI8xKGcDzYAXD2EGVaM()
        {
            return UEegqZ82ko3NbrTv0KxnzF1mz7HmhJjCgb5Fu6S2sYj4;
        }
    }
}```