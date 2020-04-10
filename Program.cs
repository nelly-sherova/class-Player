using System;

namespace dz10Player
{
    interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
