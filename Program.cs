﻿using System;

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
            Console.WriteLine("Hello World!");
        }
    }
}
