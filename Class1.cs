using System;

namespace MyLibz
{
    public class Class1
    {
        public int Count { get; set; } = 0;
        public Class1()
        {
            Count = 137;
        }

        public Class1(int count)
        {
            Count = count;
        }

        public void  Inc()
        {
            Count++;
            if (Count > 137)
                Count = 137;
        }

        public void Dec()
        {
            Count--;
            if (Count < 0)
                Count = 0;
        }
    }
}
