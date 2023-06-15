using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsManager;

namespace Test
{
    public enum EventEnum
    {
        print,
        print2,
        print3,
        print4,
        sum,
        sub
        
    }
    class test
    {
        static test instance = null;
        public static test Instance 
        {
            get
            {
                if (instance == null) instance = new test();
                return instance;
            }
        }
        private test() 
        {
            EventDispatcher.Instance.AddListener(EventEnum.print, print);
            EventDispatcher.Instance.AddListener(EventEnum.print, print2);
            EventDispatcher.Instance.AddListener(EventEnum.print, print2);
            EventDispatcher.Instance.AddListener<string>(EventEnum.print3, print3);
            EventDispatcher.Instance.AddListener<string,string,string,string,int>(EventEnum.print4, print4);
            EventDispatcher.Instance.Register<int>(EventEnum.sum, sum);
            EventDispatcher.Instance.Register<int>(EventEnum.sub, Sub);
            
            //EventDispatcher.Instance.RemoveListener(EventEnum.print, print2);
            EventDispatcher.Instance.RemoveEvent(EventEnum.sub);
        }
        public void print()
        {
            Console.WriteLine("mess 1");
        }
        public void print2()
        {
            Console.WriteLine("mess 2");
        }
        public void print3(string txt)
        {
            Console.WriteLine(txt);
        }
        public void print4(string txt1, string txt2,string txt3,string txt4,int number)
        {
            Console.WriteLine(txt1 + txt2 + txt3 + txt4 + number);
        }
        public int sum()
        {
            return 1 + 2;
        }
        public int Sub()
        {
            return 1 - 2;
        }
        public void callTest()
        {
            EventDispatcher.Instance.TriggerEvent(EventEnum.print);
            Console.WriteLine(EventDispatcher.Instance.CallEvent<int>(EventEnum.sum));
            //Console.WriteLine(EventDispatcher.Instance.CallEvent<int>(EventEnum.sub)); // không gọi được thằng này vì đã bị xóa
            EventDispatcher.Instance.TriggerEvent<string>(EventEnum.print3, "NGUYEN VAN THANH ANH");
            EventDispatcher.Instance.TriggerEvent<string, string, string, string, int>(EventEnum.print4, "NGUYEN ","van ","thanh ","anh ",18);

        }
        
    }
    
}
