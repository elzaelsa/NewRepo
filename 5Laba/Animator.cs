using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Laba
{
    class Animator
    {
        private List<Ball> balls;
        private Graphics _mainGraphics;
        public bool _stop = false;
        public List<Ball> Balls { get { return balls; } }
        public Graphics MainGraphics
        {
            get => _mainGraphics;
            set
            {
                _mainGraphics = value;
                ContainerSize = _mainGraphics.VisibleClipBounds.Size.ToSize();
                _bufferedGraphics = BufferedGraphicsManager.Current.Allocate(_mainGraphics, new Rectangle(new Point(0, 0), ContainerSize));
            }
        }
        public Size ContainerSize
        {
            get => Ball.ContainerSize;
            set => Ball.ContainerSize = value;
        }

        private BufferedGraphics _bufferedGraphics;
        private Graphics _bg => _bufferedGraphics.Graphics;

        public Animator(Graphics g)
        {
            Random random = new Random();
            MainGraphics = g;
            balls = new List<Ball>();
            for (int i = 0; i < 5; i++)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                balls.Add(new Ball(random.Next(100, 800), random.Next(100, 400), random.Next(10, 20), randomColor, ContainerSize));
            }
        }

        private void CreateFrame(Graphics g)
        {
            g.Clear(Color.White);
            g.FillRectangle(new SolidBrush(Color.Brown), 0, 0, 930, 470); //создается кадр
            foreach (var ball in balls) 
            {
                ball.Paint(g);
            }
        }

        public void Start()
        {
            foreach(Ball ball in balls)
            {
                ball.Start();
            }
            _stop = false;
            var t = new Thread(() =>
            {
                bool flag = true;
                while (!_stop)
                {
                    CreateFrame(_bg);
                    try
                    {
                        _bufferedGraphics.Render();
                    }
                    catch
                    {
                    }
                    Thread.Sleep(30);
                    if (flag && checkAllStop())
                    {
                        MessageBox.Show("Все потоки завершили работу");
                        flag = false;
                    }
                }   
            });
            t.IsBackground = true;
            t.Start();
            
        }

        public bool checkAllStop()
        {
            foreach(Ball ball in balls)
            {
                if (!ball._stop) return false;
            }
            return true;
        }
        public void Stop()
        {
            _stop = true;
        }
    }
}
