using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro_to_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D backGround;
        Texture2D corn_flakes;
        Texture2D corn_pops;
        Texture2D rice_krispies;
        Texture2D vector;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 550;
            _graphics.PreferredBackBufferHeight = 650;
            _graphics.ApplyChanges();
            this.Window.Title = "cfgnceerduhc";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            backGround = Content.Load<Texture2D>("gla.png");
            corn_flakes = Content.Load<Texture2D>("corn_flakes");
            corn_pops = Content.Load<Texture2D>("corn_pops");
            rice_krispies = Content.Load<Texture2D>("rice_krispies");
            vector = Content.Load<Texture2D>("vector");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Aquamarine);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(backGround, new Vector2 (-10, -10), Color.White);
            _spriteBatch.Draw(corn_flakes, new Vector2(10, 10), Color.White);
            _spriteBatch.Draw(corn_pops, new Vector2(230, 10), Color.White);
            _spriteBatch.Draw(rice_krispies, new Vector2(10, 330), Color.White);
            _spriteBatch.Draw(vector, new Vector2(230, 330), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}