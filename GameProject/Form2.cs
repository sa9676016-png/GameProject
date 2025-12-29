using EZInput;
using GameFrameWork;

using GameProject.Core;
using GameProject.Entities;
using GameProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Form2 : Form
    {
        Game game = new Game();
        Player player = new Player
        {
            Position = new PointF(100, 200),
            Size = new Size(100, 100),
            Sprite = Image.FromFile("@C:\ Users\ User\Desktop\week4"),

            Movement = new KeyboardMovement(),

        };
        PhysicsSystem physics = new PhysicsSystem();
        CollisionSystem collisions = new CollisionSystem();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Setting();
        }
        private void Setting()
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

















           