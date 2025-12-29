using GameFrameWork;
using GameProject.Core;
using GameProject.Entities;
using GameProject.Properties;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms; // Make sure this is included

namespace GameProject
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        PhysicsSystem physics = new PhysicsSystem();
        CollisionSystem collisions = new CollisionSystem();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // Explicitly use WinForms Timer

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            //this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.Bounds.Size;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            Setting();

            // Timer setup
            timer.Interval = 16; // roughly 60 FPS
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Setting()
        {
            // Background
            game.AddObject(new GameObject
            {
                Position = new PointF(0, 0),
                Size = new Size(ClientSize.Width, ClientSize.Height),
                Sprite = Image.FromFile("Assets/Forest.png")
            });

            // Player
            game.AddObject(new Player(game)
            {
                Position = new PointF(100, 120),
                Size = new Size(120, 400),
                Sprite = Image.FromFile("Assets/psprite.png"),
                Movement = new KeyboardMovement()
            });
            game.AddObject(new Enemy
            {
                Position = new PointF(900, 200),
                Size = new Size(200, 200),
                Sprite = Image.FromFile("Assets/forestgoblinrak.png"),
                Movement = new PatrolMovement(left: 50, right: 900)
            });


            game.AddObject(new Enemy
            {
                Position = new PointF(1100, 350),
                Size = new Size(200, 200),
                Sprite = Image.FromFile("Assets/forestgoblinrak.png"),
                Movement = new PatrolMovement(left: 300, right: 1000)
            });

        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            game.Update(new GameTime());
            physics.Apply(game.Objects.ToList());
            collisions.Check(game.Objects.ToList());
            game.Cleanup();




            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}