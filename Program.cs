using System;

namespace dz10Player
{
    interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop();

    }
    interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop();
    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Playing");
        }
        public void Record()
        {
            Console.WriteLine("Recording");
        }
        public void Pause()
        {
            Console.WriteLine("Paused");
        }
        public void Stop()
        {
            Console.WriteLine("Stoped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player play = new Player();
            System.Console.WriteLine("Action of program");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа Playable:");
            play.Play();
            play.Pause();
            play.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Программа Recordable");
            play.Record();
            play.Pause();
            play.Stop();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
