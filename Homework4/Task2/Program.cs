using System;
using System.Timers;
namespace Task2
{
    public delegate void ClockHander(Object obj, String info);

    class Clock
    {
        public event ClockHander Tick;
        public event ClockHander Alarm;

        private int hour, minute, second;
        private int Ahour, Aminute, Asecond;

        public Clock(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public Clock()
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }
        public void SetCurTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public void setAlarm(int h, int m, int s)
        {
            Ahour = h;
            Aminute = m;
            Asecond = s;
        }
        public String GetCurTime()
        {
            return "" + hour+ ":"+ minute+":" + second;
        }
        public void tick()
        {
            Tick(this, GetCurTime());
            second++;
            if (second >= 60)
            {
                second %= 60;
                minute++;
                if(minute >= 60)
                {
                    minute %= 60;
                    hour = (hour + 1 >= 24) ? ((hour + 1) % 24) : hour + 1; 
                }
            }
            if (IsAlramTime())
                this.alarm();

        }
        public void alarm()
        {
            Alarm(this, GetCurTime());
        }
        public bool IsAlramTime()
        {
            return hour == Ahour && minute == Aminute && second == Asecond;
        }
    }
    class Program
    {
        Clock C = new Clock();
        Program()
        {
            //订阅事件
            C.Tick += Clock_Tick;
            C.Alarm += Clock_Alarm;
            C.setAlarm(10, 50, 30);
        }
        //定时器事件，启动闹钟事件
        public void After1sec(object obj, ElapsedEventArgs args)
        {
            C.tick();
            
        }
        //为闹钟事件添加方法
        public void Clock_Tick(object obj, String s)
        {
            Console.WriteLine("一秒过去了，闹钟走时，现在时间" + s);
        }
        public void Clock_Alarm(object obj, String s)
        {
            Console.WriteLine("闹钟响铃,现在时间" + s);
        }
        static void Main(string[] args)
        {
            
            Program Proj = new Program();
            //创建定时器，添加定时器响应事件
            Timer Time = new Timer(1000);
            Time.Elapsed += Proj.After1sec;
            Time.Enabled = true;
            Time.AutoReset = true;
            Time.Start();
            //确保主线程不结束，定时器线程保持运行
            while (true){}
        }
    }
}
