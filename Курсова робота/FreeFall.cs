using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_робота
{
    public partial class FreeFall : Form
    {
        private Audio player = new Audio();
        private const double gravity = 9.8;
        private const double time = 1;
        private const double airResistanceCoefficient = 0.4;
        private const double crossSectionalArea = 0.01;
        private double positionY;
        private double speed;
        private double mass;
        private double wind;
        private bool hasCollided = false;

        private const double MaxPositionY = 500;
        private const double MaxSpeed = 50;
        private const double MaxMass = 10;
        private const double MaxWind = 5;

        public double PositionY
        {
            get { return positionY; }
            set { positionY = Math.Max(0, Math.Min(MaxPositionY, value)); }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = Math.Max(0, Math.Min(MaxSpeed, value)); }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = Math.Max(0, Math.Min(MaxMass, value)); }
        }

        public double Wind
        {
            get { return wind; }
            set { wind = Math.Max(0, Math.Min(MaxWind, value)); }
        }

        public FreeFall()
        {
            PositionY = 300;
            Speed = 1;
            Mass = 1;
            Wind = 1;

            InitializeUi();
        }

        public FreeFall(double positionY, double speed, double mass, double wind)
        {
            PositionY = positionY;
            Speed = speed;
            Mass = mass;
            Wind = wind;

            InitializeUi();
        }

        public void InitializeUi()
        {
            try
            {
                Text = "Курсова робота";
                InitializeComponent();
                this.timer.Interval = 40;
                this.timer.Tick += Timer_Tick;

            }
            catch (FileNotFoundException)
            {
                Dispose(false);
                this.Close();
            }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            double airResistance = 0.5 * Math.Pow(speed - wind, 2) * airResistanceCoefficient * crossSectionalArea + wind;
            double netForce = mass * (gravity - airResistance);
            double speedUp = netForce / mass;

            speed += speedUp * time;

            positionY -= speed * time;

            if (positionY <= 0)
            {
                if (!hasCollided)
                {
                    await Task.Run(() => player.Play("fall.wav"));
                    hasCollided = true;
                }

                speed = -(speed * 0.8);
                positionY = 0;
            }
            else
            {
                hasCollided = false;
            }

            UpdateGraphics();
        }

        private void UpdateGraphics()
        {
            using (Graphics g = CreateGraphics())
            {
                g.Clear(Color.White);
                g.FillEllipse(Brushes.Black, (int)(ClientSize.Width - 500) - 70, (int)(ClientSize.Height - positionY) - 70, 70, 70);
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetNewValue_Click(object sender, EventArgs e)
        {
            Dispose(false);
            this.Close();
        }
    }
}