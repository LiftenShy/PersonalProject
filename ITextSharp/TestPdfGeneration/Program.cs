using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace TestPdfGeneration
{
    class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static Graphics graphics;
        static BufferedGraphics bufferedGraphics;
        static Player player;

        public static Graphics Graphics { get => graphics; set => graphics = value; }
        public static BufferedGraphics BufferedGraphics { get => bufferedGraphics; set => bufferedGraphics = value; }
        internal static Player Player { get => player; set => player = value; }

        public const int WINDOW_WIDTH = 990;
        public const int WINDOW_HEIGHT = 780;

        static void Main()
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);
            

            if (handle != IntPtr.Zero)
            {
                //DeleteMenu(sysMenu, SC_CLOSE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);

                player = new Player();
                Console.CursorVisible = false;
                Process process = Process.GetCurrentProcess();
                graphics = Graphics.FromHdc(GetDC(process.MainWindowHandle));
                BufferedGraphicsContext context = BufferedGraphicsManager.Current;
                context.MaximumBuffer = new Size(WINDOW_WIDTH, WINDOW_HEIGHT);
                bufferedGraphics = context.Allocate(graphics, new Rectangle(0, 0, WINDOW_WIDTH, WINDOW_HEIGHT));
                while (true)
                {
                    bufferedGraphics.Graphics.Clear(Color.Red);
                    player.Draw(bufferedGraphics.Graphics);
                    bufferedGraphics.Render(graphics);
                    player.DoMove();
                }
            }
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC(IntPtr hWnd);
    }

    public class Player
    {
        const int LEFT = 0x25;
        const int UP = 0x26;
        const int RIGHT = 0x27;
        const int DOWN = 0x28;
        float x;
        float y;

        public static int LEFT1 => LEFT;

        public static int UP1 => UP;

        public static int RIGHT1 => RIGHT;

        public static int DOWN1 => DOWN;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public Player()
        {
            x = 0;
            y = 0;
        }
        public void DoMove()
        {
            if ((GetKeyState(LEFT) | 0x8000) > 0 && x < Program.WINDOW_WIDTH)
            {
                x += 0.1f;
            }
            if ((GetKeyState(RIGHT) | 0x8000) > 0 && x > 0)
            {
                x -= 0.1f;
            }
            if ((GetKeyState(UP) | 0x8000) > 0 && y < Program.WINDOW_HEIGHT)
            {
                y += 0.1f;
            }
            /*if ((GetKeyState(DOWN) | 0x8000) > 0 && y > 0)
            {
                y -= 0.1f;
            }*/
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, x - 10, y - 10, 20, 20);
        }
        [DllImport("user32.dll")]
        static extern short GetKeyState(int nVirtKey);
    }
}
