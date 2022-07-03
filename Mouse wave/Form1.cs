using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mouse_wave
{
    public partial class Form1 : Form
    {
        private int[] verticalWave;
        private int[] horizontalWave;
        private int oldPanelRenderVerticalWidth;
        private int oldPanelRenderHorizontalHeight;
        private Rectangle megascreenRect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oldPanelRenderVerticalWidth = panelRenderVertical.Width;
            oldPanelRenderHorizontalHeight = panelRenderHorizontal.Height;

            megascreenRect = GetWholeScreenRect();
            verticalWave = new int[panelRenderVertical.Width];
            int screenHeight = Math.Abs(megascreenRect.Top) + megascreenRect.Bottom;
            for (int i = 0; i < verticalWave.Length; ++i)
            {
                verticalWave[i] = screenHeight;
            }
            horizontalWave = new int[panelRenderHorizontal.Height];
            for (int i = 0; i < horizontalWave.Length; ++i)
            {
                horizontalWave[i] = megascreenRect.Left;
            }

            timer1.Interval = (int)numericUpDownTimerInterval.Value;
        }

        private void panelRenderHorizontal_Resize(object sender, EventArgs e)
        {
            int diff = panelRenderHorizontal.Height - oldPanelRenderHorizontalHeight;
            if (diff != 0)
            {
                int[] array = new int[panelRenderHorizontal.Height];
                if (diff > 0)
                {
                    Array.Copy(horizontalWave, 0, array, diff, horizontalWave.Length);
                    for (int i = 0; i < diff; ++i)
                    {
                        array[i] = megascreenRect.Left;
                    }
                }
                else if (diff < 0)
                {
                    diff = Math.Abs(diff);
                    Array.Copy(horizontalWave, diff, array, 0, oldPanelRenderHorizontalHeight - diff);
                }

                horizontalWave = array;

                oldPanelRenderHorizontalHeight = panelRenderHorizontal.Height;
            }
        }

        private void panelRenderVertical_Resize(object sender, EventArgs e)
        {
            int diff = panelRenderVertical.Width - oldPanelRenderVerticalWidth;
            if (diff != 0)
            {
                int[] array = new int[panelRenderVertical.Width];
                if (diff > 0)
                {
                    Array.Copy(verticalWave, 0, array, diff, verticalWave.Length);
                    int screenHeight = Math.Abs(megascreenRect.Top) + megascreenRect.Bottom;
                    for (int i = 0; i < diff; ++i)
                    {
                        array[i] = screenHeight;
                    }
                }
                else if (diff < 0)
                {
                    diff = Math.Abs(diff);
                    Array.Copy(verticalWave, diff, array, 0, oldPanelRenderVerticalWidth - diff);
                }

                verticalWave = array;

                oldPanelRenderVerticalWidth = panelRenderVertical.Width;
            }
        }

        private void panelRenderHorizontal_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(panelRenderHorizontal.Width, panelRenderHorizontal.Height))
                {
                    using (Graphics buffer = Graphics.FromImage(bitmap))
                    {
                        Point[] points = new Point[horizontalWave.Length];
                        for (int i = 0; i < horizontalWave.Length; ++i)
                        {
                            int mappedX = Map(horizontalWave[i], megascreenRect.Left, megascreenRect.Width, 0, panelRenderHorizontal.Width - 1);
                            points[i] = new Point(mappedX, i);
                        }

                        buffer.Clear(panelRenderHorizontal.BackColor);
                        buffer.DrawCurve(Pens.Black, points);
                        e.Graphics.DrawImage(bitmap, 0, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        private void panelRenderVertical_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(panelRenderVertical.Width, panelRenderVertical.Height))
                {
                    using (Graphics buffer = Graphics.FromImage(bitmap))
                    {
                        Point[] points = new Point[verticalWave.Length];
                        int screenHeight = Math.Abs(megascreenRect.Top) + megascreenRect.Bottom;
                        for (int i = 0; i < verticalWave.Length; ++i)
                        {
                            int mappedY = Map(verticalWave[i], 0, screenHeight, 0, panelRenderVertical.Height);
                            points[i] = new Point(i, mappedY);
                        }

                        buffer.Clear(panelRenderVertical.BackColor);
                        buffer.DrawCurve(Pens.Black, points);
                        e.Graphics.DrawImage(bitmap, 0, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
        }

        private void btnApplyTimerInterval_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < horizontalWave.Length - 1; ++i)
            {
                horizontalWave[i] = megascreenRect.Left;
            }

            int screenHeight = Math.Abs(megascreenRect.Top) + megascreenRect.Bottom;
            for (int i = 0; i < verticalWave.Length - 1; ++i)
            {
                verticalWave[i] = screenHeight;
            }

            timer1.Interval = (int)numericUpDownTimerInterval.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point cursorPos = Cursor.Position;
            
            for (int i = 0; i < horizontalWave.Length - 1; ++i)
            {
                horizontalWave[i] = horizontalWave[i + 1];
            }
            horizontalWave[horizontalWave.Length - 1] = cursorPos.X;

            for (int i = 0; i < verticalWave.Length - 1; ++i)
            {
                verticalWave[i] = verticalWave[i + 1];
            }
            verticalWave[verticalWave.Length - 1] = cursorPos.Y;

            panelRenderHorizontal.Invalidate();
            panelRenderVertical.Invalidate();
        }

        private int Map(int value, int min, int max, int targetMin, int targetMax)
        {
            int diff = max - min;
            if (diff == 0)
            {
                return value;
            }
            return (value - min) * (targetMax - targetMin) / diff + targetMin;
        }

        private Rectangle GetWholeScreenRect()
        {
            int xMin = 0;
            int xMax = 0;
            int yMin = 0;
            int yMax = 0;
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Bounds.Left < xMin)
                {
                    xMin = screen.Bounds.Left;
                }
                if (screen.Bounds.Right > xMax)
                {
                    xMax = screen.Bounds.Right;
                }
                if (screen.Bounds.Top < yMin)
                {
                    yMin = screen.Bounds.Top;
                }
                if (screen.Bounds.Bottom > yMax)
                {
                    yMax = screen.Bounds.Bottom;
                }
            }
            return new Rectangle(xMin, yMin, xMax, yMax);
        }
    }
}
