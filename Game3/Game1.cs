using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Ruminate.Utils;
using System;

namespace Game3
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        int x = 400;

        

        private Texture2D background;
        private Texture2D shuttle;
        private Texture2D earth;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            background = Content.Load<Texture2D>("..\\Content\\stars"); // change these names to the names of your images
            shuttle = Content.Load<Texture2D>("..\\Content\\shuttle");  // if you are using your own images.
            earth = Content.Load<Texture2D>("..\\Content\\earth");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

            Keys[] teclas = Keyboard.GetState().GetPressedKeys();
            foreach(Keys k in teclas)
            {
                if (k.Equals(Keys.Left))
                {
                    Contexto.posicaoLocal.moverX(-1);
                }
                if (k.Equals(Keys.Right))
                {
                    Contexto.posicaoLocal.moverX(1);
                }
                if (k.Equals(Keys.Up))
                {
                    Contexto.posicaoLocal.moverY(-1);
                }
                if (k.Equals(Keys.Down))
                {
                    Contexto.posicaoLocal.moverY(1);
                }

            }


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
                GraphicsDevice.Clear(Color.CornflowerBlue);

                spriteBatch.Begin();

                spriteBatch.Draw(background, new Rectangle(0, 0, 800, 480), Color.White);
                //spriteBatch.Draw(earth, new Vector2(x, 240), Color.White);
                spriteBatch.Draw(shuttle, Contexto.posicaoLocal.getVector(), Color.White);
                spriteBatch.Draw(shuttle, Contexto.posicaoRemota.getVector(), Color.White);

                spriteBatch.End();

                base.Draw(gameTime);
        }
    }
}
