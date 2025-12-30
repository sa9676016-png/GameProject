using EZInput;
using GameFrameWork;
using GameProject.Core;
using GameProject.Entities;   // ✅ Player fix
using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Form2 : Form
    {
        Game game;


        Player player;

        PhysicsSystem physics = new PhysicsSystem();
        CollisionSystem collisions = new CollisionSystem();

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // ✅ Timer fix

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;

            game = new Game();

            Setting();

            timer.Interval = 16;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Setting()
        {
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
