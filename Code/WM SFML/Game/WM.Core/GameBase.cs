using System;
using SFML.Window;
using SFML.Graphics;

namespace WM.Core
{
    public abstract class GameBase:Drawable
    {
        #region Fields

        protected RenderWindow window;
        protected Color clearColor;

        #endregion

        #region Properties

        #endregion

        #region Construct

        public GameBase ( uint width, uint height, string title, Color clearColor )
        {
            this.window = new RenderWindow ( new VideoMode ( width, height ), title );
            this.clearColor = clearColor;
            window.Closed += OnClosed;
        }


        #endregion

        #region Abstract Logic

        public void Run()
        {
            LoadContent ();
            Initialize ();
            while ( window.IsOpen )
            {
                window.DispatchEvents ();
                Update ();
                window.Clear ();
                Draw ();
                window.Display ();
            }
            UnLoadContent ();
        }

        /// <summary>
        /// Loads the content.
        /// </summary>
        protected abstract void LoadContent();

        /// <summary>
        /// Initialize this instance.
        /// </summary>
        protected abstract void Initialize();

        /// <summary>
        /// Tick this instance.
        /// </summary>
        protected abstract void Update();

        /// <summary>
        /// Render this instance.
        /// </summary>
        protected abstract void Draw();

        /// <summary>
        /// Unloads all the game content that has been loaded
        /// </summary>
        protected abstract void UnLoadContent();

        #endregion

        #region Events

        void OnClosed( object sender, EventArgs e )
        {
            window.Close ();
        }

        #endregion
    }
}

