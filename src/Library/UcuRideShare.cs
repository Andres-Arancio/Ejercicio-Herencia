using System;
using System.Collections.Generic;
using TwitterUCU;
namespace Herencia
{
    public class UcuRideShare
    {
        public static List<Usuario> pool = new List<Usuario>();
        public UcuRideShare()
        {

        }
        public void Add(Usuario u)
        {
            pool.Add(u);
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("text", @"PathToImage.png"));
        }
    }

}
