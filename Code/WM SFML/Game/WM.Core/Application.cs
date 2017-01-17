using System;
using SFML.Window;
using SFML.Graphics;
using SFML.Audio;

namespace WM.Core
{
    public class Application
    {
        static void Main( string[] args )
        {
            MainGame game = new MainGame ();
            game.Run ();
        }
    }
}

