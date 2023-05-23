using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5Laba
{
    class Ball
    {
        private int _size = 50;
        public bool _stop = false;
        private static Size _containerSize;

        private float speed_x, speed_y, impulse;
        private Color color;
        public bool onPause = false;
        public float x { get; set; }
        public float y { get; set; }

        public int Size
        {
            get => _size;
        }
        public Point Location { get; set; }
        public static Size ContainerSize
        {
            get => _containerSize;
            set => _containerSize = value;
        }

        public Ball(float x, float y, float impulse, Color color, Size containerSize)
        {
            Location = new Point((int)x, (int)y);
            this.x = x;
            this.y = y;
            Random random = new Random();
            int sign = random.Next(0, 1);
            if (sign == 0) this.impulse = impulse;
            else if (sign == 1) this.impulse = -impulse;
            speed_x = speed_y = impulse;
            this.color = color;
            ContainerSize = containerSize;
        }

        public void Update(float dt)
        {
            // Обновляем скорость и положение шара
            speed_x -= speed_x * dt;
            speed_y -= speed_y * dt;
            x += speed_x;
            y += speed_y;
        }
        public bool checkStop()
        {
            return Math.Abs(speed_y) < 1 && Math.Abs(speed_x) < 1;
            
        }
        public void checkCollision()
        {
            if (x <= 0 || x >= _containerSize.Width - 50) speed_x = -speed_x;
            if (y <= 0 || y >= _containerSize.Height - 50) speed_y = -speed_y;
        }
        public void Paint(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), x, y, 50, 50);
        }
        public void Start()
        {
            _stop = false;
            var t = new Thread(() =>
            {
                while (!_stop)
                {
                    if (!onPause) Update(0.01f); //пока мяч не остановился, и если он не на паузе, происходит апдейт
                    checkCollision(); //проверяется столкновение
                    if (checkStop()) _stop = true;
                    Location = new Point((int)x, (int)y); 
                    Thread.Sleep(30);
                }
            });
            t.Start();
        }
    }
}
