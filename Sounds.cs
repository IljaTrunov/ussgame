﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WMPLib;

//namespace ussgame
//{
//    public class Sounds
//    {
//        WindowsMediaPlayer player = new WindowsMediaPlayer();
//        private string pathToMedia;

//        public Sounds(string pathToResourses)
//        {
//            pathToMedia = pathToResourses;
//        }

//        public void Play()
//        {
//            player.URL = pathToMedia + "he10min.mp3";
//            Console.WriteLine(player.URL);
//            player.settings.volume = 20;
//            player.controls.play();
//            player.settings.setMode("loop", true);
//        }

//        public void Play(string songName)
//        {
//            player.URL = pathToMedia + songName;
//            player.controls.play();
//        }
//    }
//}
