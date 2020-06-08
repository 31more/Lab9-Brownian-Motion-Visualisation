using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_brownianMotion.Forms
{
    public partial class Particle : UserControl
    {
        private static int Temperature = 0;
        public static int BaseMoveSpeed = 1;
        private static int ParticleSize = 40;

        public static Particle[] Particles { get; private set; } = new Particle[0];
        private static int CurrentIndex;
        public int moveSpeedX = MoveSpeed, moveSpeedY = MoveSpeed;
        

        public Particle(int startPosX = 0, int startPosY = 0)
        {
            InitializeComponent();
      
            this.ClientSize = new Size(new Point(ParticleSize, ParticleSize));
            this.Location = new Point(startPosX, startPosY);

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(this.ClientRectangle);
            Region rgn = new Region(path);
            this.Region = rgn;
            this.BorderStyle = BorderStyle.None;

            try
            {
                Particles[CurrentIndex++] = this;
            }
            catch(IndexOutOfRangeException)
            {
                throw new ArgumentException("You must use Particle.SetUp method with proper number of particles before creating particles.");
            }
        }

        private static int MoveSpeed => BaseMoveSpeed * Temperature / 10;
        private static Color ParticleColor => Color.Red; 
        protected override void OnPaint(PaintEventArgs e) => PaintParticle(this, e);

        private void PaintParticle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.BackColor = ParticleColor;

        }

        public static void SetUp(int numOfMolecules)
        {
            Particles = new Particle[numOfMolecules]; 
            CurrentIndex = 0;
        }

        public static void Clear() => Particles = new Particle[0];

        public static void AdjustTemp(int temp)
        {
            Temperature = temp;
            var newColor = ParticleColor;
            foreach (Particle mol in Particles)
            {
                if (mol == null) continue;
                mol.moveSpeedX = mol.moveSpeedX > 0 ? MoveSpeed : -MoveSpeed;
                mol.moveSpeedY = mol.moveSpeedY > 0 ? MoveSpeed : -MoveSpeed;
                mol.BackColor = newColor;
            }
        }

        public void Collide(Particle other)
        {
            if (this.Location.X - other.Location.X < 0) moveSpeedX = -MoveSpeed;
            else moveSpeedX = MoveSpeed;
            if (this.Location.Y - other.Location.Y < 0) moveSpeedY = -MoveSpeed;
            else moveSpeedY = MoveSpeed;
        }

        private void Particle_Load(object sender, EventArgs e)
        {

        }

        public void MoveParticle()
        {
            int x = this.Location.X, y = this.Location.Y;

            foreach(Particle other in Particles)
            {
                if (other != null && this != other 
                    && Math.Abs(this.Location.X - other.Location.X) < ParticleSize 
                    && Math.Abs(this.Location.Y - other.Location.Y) < ParticleSize)
                {
                    this.Collide(other);
                    other.Collide(this);
                }
            }

            if (x < 0)
            {
                x = 0;
                moveSpeedX = MoveSpeed;
            }
            else if (x > this.Parent.ClientRectangle.Width - ParticleSize)
            {
                x = this.Parent.ClientRectangle.Width - ParticleSize;
                moveSpeedX = -MoveSpeed;
            }

            if (y < 0)
            {
                y = 0;
                moveSpeedY = MoveSpeed;
            }
            else if (y > this.Parent.ClientRectangle.Height - ParticleSize)
            {
                y = this.Parent.ClientRectangle.Height - ParticleSize;
                moveSpeedY = -MoveSpeed;
            }


            this.Location = new Point(x + moveSpeedX, y + moveSpeedY);
        }
    }
}
