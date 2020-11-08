#region Directives
using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Diagnostics;
#endregion

namespace PWR_UI2
{
    public partial class frmMain : Form
    {
        #region Fields
        private Dictionary<string, MediaSlider.MediaSlider> _dictControls = new Dictionary<string, MediaSlider.MediaSlider>();
        #endregion

        #region Controls
        #region Form
        public frmMain()
        {
            // only call needed to extend into frame
            ExtendMargins(0, 62, 0, 0, true, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ncToolStrip.BackColor = Color.Black;
            toolStripLabel1.ForeColor = Color.White;
            ncEqToolStrip.BackColor = Color.Black;
            toolStripLabel3.ForeColor = Color.White;

            if (IsCompatableOS())
            {
                // renderer needed to draw text on controls on frame
                ncToolStrip.Renderer = new NcRenderer();
                ncEqToolStrip.Renderer = new NcRenderer();
            }
            else
            {
                ncToolStrip.RenderMode = ToolStripRenderMode.System;
                ncToolStrip.Dock = DockStyle.Top;
                ncEqToolStrip.RenderMode = ToolStripRenderMode.System;
                ncEqToolStrip.Dock = DockStyle.Top;
                this.Height += 40;
            }
            pnlEq.Paint += new PaintEventHandler(pnlEq_Paint);
            mediaSlider18.FlyOutInfo += new MediaSlider.MediaSlider.FlyOutInfoDelegate(mediaSlider18_FlyOutInfo);
            ControlManager();
        }
        #endregion

        #region Toolbars
        private void precisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                _dictControls["mediaSlider" + i.ToString()].TickStyle = TickStyle.TopLeft;
                _dictControls["mediaSlider" + i.ToString()].TickType = MediaSlider.MediaSlider.TickMode.Precision;
            }
        }

        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                _dictControls["mediaSlider" + i.ToString()].TickStyle = TickStyle.TopLeft;
                _dictControls["mediaSlider" + i.ToString()].TickType = MediaSlider.MediaSlider.TickMode.Composite;
            }
        }

        private void largeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                _dictControls["mediaSlider" + i.ToString()].TickStyle = TickStyle.TopLeft;
                _dictControls["mediaSlider" + i.ToString()].TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
            {
                _dictControls["mediaSlider" + i.ToString()].TickStyle = TickStyle.TopLeft;
                _dictControls["mediaSlider" + i.ToString()].TickType = MediaSlider.MediaSlider.TickMode.Standard;
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].TickStyle = TickStyle.None;
        }

        private void precisionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].ButtonStyle = MediaSlider.MediaSlider.ButtonType.PointerDownLeft;
        }

        private void rectangleInlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].ButtonStyle = MediaSlider.MediaSlider.ButtonType.RoundedRectInline;
        }

        private void overlapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].ButtonStyle = MediaSlider.MediaSlider.ButtonType.RoundedRectOverlap;
        }

        private void roundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
        }

        private void tsAnimate_Click(object sender, EventArgs e)
        {
            tsAnimate.Checked = !tsAnimate.Checked;
            msLeftFreq100.Animated = tsAnimate.Checked;
            msRightFreq100.Animated = tsAnimate.Checked;
        }

        private void tsFlyout_Click(object sender, EventArgs e)
        {
            tsFlyout.Checked = !tsFlyout.Checked;
            if (tsFlyout.Checked)
            {
                msLeftFreq100.TickStyle = TickStyle.None;
                msRightFreq100.TickStyle = TickStyle.None;
                msLeftFreq100.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.Persistant;
                msRightFreq100.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.Persistant;
                msLeftFreq100.Size = new Size(46, 96);
                msRightFreq100.Size = new Size(46, 96);
                msLeftFreq100.Location = new Point(31, 9);
                msRightFreq100.Location = new Point(169, 9);
            }
            else
            {
                msLeftFreq100.TickStyle = TickStyle.TopLeft;
                msRightFreq100.TickStyle = TickStyle.TopLeft;
                msLeftFreq100.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
                msRightFreq100.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
                msLeftFreq100.Size = new Size(40, 90);
                msRightFreq100.Size = new Size(40, 90);
                msLeftFreq100.Location = new Point(44, 12);
                msRightFreq100.Location = new Point(182, 12);
            }
        }

        private void tsSmooth_Click(object sender, EventArgs e)
        {
            tsSmooth.Checked = !tsSmooth.Checked;
            for (int i = 1; i < 9; i++)
                _dictControls["mediaSlider" + i.ToString()].SmoothScrolling = tsSmooth.Checked;
        }

        private void tsBlack_Click(object sender, EventArgs e)
        {
            tsBlack.Checked = !tsBlack.Checked;
            if (tsBlack.Checked)
            {
                tsSilver.Checked = false;
                tsBlue.Checked = false;
                tsGreen.Checked = false;
                ColorChange(0);
            }
        }

        private void tsSilver_Click(object sender, EventArgs e)
        {
            tsSilver.Checked = !tsSilver.Checked;
            if (tsSilver.Checked)
            {
                tsBlack.Checked = false;
                tsBlue.Checked = false;
                tsGreen.Checked = false;
                ColorChange(1);
            }
        }

        private void tsBlue_Click(object sender, EventArgs e)
        {
            tsBlue.Checked = !tsBlue.Checked;
            if (tsBlue.Checked)
            {
                tsSilver.Checked = false;
                tsBlack.Checked = false;
                tsGreen.Checked = false;
                ColorChange(2);
            }
        }

        private void tsGreen_Click(object sender, EventArgs e)
        {
            tsGreen.Checked = !tsGreen.Checked;
            if (tsGreen.Checked)
            {
                tsBlack.Checked = false;
                tsSilver.Checked = false;
                tsBlue.Checked = false;
                ColorChange(3);
            }
        }

        private void ColorChange(int style)
        {
            switch (style)
            {
                case 0:
                    {
                        foreach (MediaSlider.MediaSlider ms in _dictControls.Values)
                        {
                            ms.ButtonAccentColor = Color.FromArgb(128, 64, 64, 64);
                            ms.ButtonBorderColor = Color.Black;
                            ms.ButtonColor = Color.FromArgb(160, 0, 0, 0);
                            ms.TrackProgressColor = Color.FromArgb(5, 101, 188);
                        }
                        break;
                    }
                case 1:
                    {
                        for (int i = 0; i < _dictControls.Count; i++)
                        {
                            foreach (MediaSlider.MediaSlider ms in _dictControls.Values)
                            {
                                ms.ButtonAccentColor = Color.FromArgb(255, 224, 224, 224);
                                ms.ButtonBorderColor = Color.Black;
                                ms.ButtonColor = Color.FromArgb(160, 0, 0, 0);
                                ms.TrackProgressColor = Color.Silver;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < _dictControls.Count; i++)
                        {
                            foreach (MediaSlider.MediaSlider ms in _dictControls.Values)
                            {
                                ms.ButtonAccentColor = Color.FromArgb(128, 178, 205, 229);
                                ms.ButtonBorderColor = Color.FromArgb(220, 65, 114, 166);
                                ms.ButtonColor = Color.FromArgb(250, 11, 84, 152);
                                ms.TrackProgressColor = Color.FromArgb(5, 101, 188);
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < _dictControls.Count; i++)
                        {
                            foreach (MediaSlider.MediaSlider ms in _dictControls.Values)
                            {
                                ms.ButtonAccentColor = Color.FromArgb(140, 178, 229, 205);
                                ms.ButtonBorderColor = Color.FromArgb(220, 65, 166, 114);
                                ms.ButtonColor = Color.FromArgb(200, 11, 152, 84);
                                ms.TrackProgressColor = Color.FromArgb(200, 11, 152, 84);
                            }
                        }
                        break;
                    }
            }
        }

        private void ControlManager()
        {
            _dictControls.Add("msLeftFreq100", msLeftFreq100);
            _dictControls.Add("msLeftFreq200", msLeftFreq200);
            _dictControls.Add("msLeftFreq400", msLeftFreq400);
            _dictControls.Add("msLeftFreq800", msLeftFreq800);
            _dictControls.Add("msLeftFreq1600", msLeftFreq1600);
            _dictControls.Add("msLeftFreq3200", msLeftFreq3200);
            _dictControls.Add("msLeftFreq6400", msLeftFreq6400);

            _dictControls.Add("msRightFreq100", msRightFreq100);
            _dictControls.Add("msRightFreq200", msRightFreq200);
            _dictControls.Add("msRightFreq400", msRightFreq400);
            _dictControls.Add("msRightFreq800", msRightFreq800);
            _dictControls.Add("msRightFreq1600", msRightFreq1600);
            _dictControls.Add("msRightFreq3200", msRightFreq3200);
            _dictControls.Add("msRightFreq6400", msRightFreq6400);

            _dictControls.Add("mediaSlider10", mediaSlider10);
            _dictControls.Add("mediaSlider11", mediaSlider11);
            _dictControls.Add("mediaSlider12", mediaSlider12);
            _dictControls.Add("mediaSlider13", mediaSlider13);
            _dictControls.Add("mediaSlider14", mediaSlider14);
            _dictControls.Add("mediaSlider15", mediaSlider15);
            _dictControls.Add("mediaSlider16", mediaSlider16);
            _dictControls.Add("mediaSlider17", mediaSlider17);
            _dictControls.Add("mediaSlider20", mediaSlider20);
        }

        #endregion

        #region EQ Panel
        private void pnlEq_Paint(object sender, PaintEventArgs e)
        {
           // DrawEq();
        }

        private void DrawEq()
        {
            using (Graphics g = Graphics.FromHwnd(pnlEq.Handle))
            {
                Rectangle panelRect = new Rectangle(0, 0, pnlEq.Width, pnlEq.Height);
                panelRect.Inflate(-1, -1);

                using (GraphicsPath gp = CreateRoundRectanglePath(g, panelRect, 6))
                {
                    // back fill
                    using (Brush br = new SolidBrush(Color.Black))
                        g.FillPath(br, gp);

                    float fx = panelRect.Width * .5f;
                    float fy = panelRect.Height * .5f;
                    // add a shine
                    using (LinearGradientBrush fillBrush = new LinearGradientBrush(
                        panelRect,
                        Color.FromArgb(60, Color.White),
                        Color.FromArgb(5, Color.Silver),
                        LinearGradientMode.Vertical))
                    {
                        Blend blnd = new Blend();
                        blnd.Positions = new float[] { 0f, .2f, .4f, .6f, .8f, 1f };
                        blnd.Factors = new float[] { .2f, .4f, .6f, .7f, .5f, .3f };
                        fillBrush.Blend = blnd;
                        g.FillPath(fillBrush, gp);
                    }
                    // draw the border
                    using (Pen borderPen = new Pen(Color.FromArgb(220, Color.Gray), .5f))
                        g.DrawPath(borderPen, gp);
                    // add a spotlight
                    Rectangle accentRect = new Rectangle(0, 0, panelRect.Width, (int)(panelRect.Height * .6f));
                    accentRect.Inflate(1, 1);
                    using (GraphicsPath ga = CreateRoundRectanglePath(g, accentRect, 4))
                    {
                        using (PathGradientBrush borderBrush = new PathGradientBrush(ga))
                        {
                            // center focus
                            fx = accentRect.Width * .5f;
                            fy = accentRect.Height * .1f;
                            borderBrush.CenterColor = Color.FromArgb(60, Color.White);
                            borderBrush.SurroundColors = new Color[] { Color.FromArgb(5, Color.Silver) };
                            borderBrush.FocusScales = new PointF(1f, .5f);
                            borderBrush.CenterPoint = new PointF(fx, fy);
                            g.FillPath(borderBrush, ga);
                        }
                    }
                }
            }
        }

        /// <summary>Create a rounded rectangle GraphicsPath</summary>
        private GraphicsPath CreateRoundRectanglePath(Graphics g, Rectangle bounds, float radius)
        {
            // create a path
            GraphicsPath pathBounds = new GraphicsPath();
            // arc top left
            pathBounds.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);
            // line top
            pathBounds.AddLine(bounds.Left + radius, bounds.Top, bounds.Right - radius, bounds.Top);
            // arc top right
            pathBounds.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);
            // line right
            pathBounds.AddLine(bounds.Right, bounds.Top + radius, bounds.Right, bounds.Bottom - radius);
            // arc bottom right
            pathBounds.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            // line bottom
            pathBounds.AddLine(bounds.Right - radius, bounds.Bottom, bounds.Left + radius, bounds.Bottom);
            // arc bottom left
            pathBounds.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);
            // line left
            pathBounds.AddLine(bounds.Left, bounds.Bottom - radius, bounds.Left, bounds.Top + radius);
            pathBounds.CloseFigure();
            return pathBounds;
        }
        #endregion

        #region Sliders
        private void mediaSlider18_FlyOutInfo(ref string data)
        {
            TimeSpan ts = new TimeSpan(0, 0, mediaSlider18.Value);
            data = ts.ToString();
        }

        private void mediaSlider1_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq100: " + msLeftFreq100.Value);
        }

        private void mediaSlider2_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq200: " + msLeftFreq200.Value);
        }

        private void mediaSlider3_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq400: " + msLeftFreq400.Value);
        }

        private void mediaSlider4_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq800: " + msLeftFreq800.Value);
        }

        private void mediaSlider5_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq1600: " + msLeftFreq1600.Value);
        }

        private void mediaSlider6_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq3200: " + msLeftFreq3200.Value);
        }

        private void mediaSlider7_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msLeftFreq6400: " + msLeftFreq6400.Value);
        }

        private void mediaSlider8_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("msRightFreq100: " + msRightFreq100.Value);
        }

        private void mediaSlider9_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider9: " + mediaSlider9.Value);
        }

        private void mediaSlider10_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider10: " + mediaSlider10.Value);
        }

        private void mediaSlider11_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider11: " + mediaSlider11.Value);
        }

        private void mediaSlider12_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider12: " + mediaSlider12.Value);
        }

        private void mediaSlider13_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider13: " + mediaSlider13.Value);
        }

        private void mediaSlider14_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider14: " + mediaSlider14.Value);
        }

        private void mediaSlider15_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider15: " + mediaSlider15.Value);
        }

        private void mediaSlider16_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider16: " + mediaSlider16.Value);
        }

        private void mediaSlider17_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider17: " + mediaSlider17.Value);
        }

        private void mediaSlider18_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider18: " + mediaSlider18.Value);
        }

        private void mediaSlider19_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider19: " + mediaSlider19.Value);
        }

        private void mediaSlider20_ValueChanged(object sender, EventArgs e)
        {
            Debug.Print("mediaSlider20: " + mediaSlider20.Value);
        }
        #endregion
        #endregion

        #region Extend Frame
        #region Constants
        // windowpos
        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_NOREDRAW = 0x0008;
        private const int SWP_NOACTIVATE = 0x0010;
        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int SWP_HIDEWINDOW = 0x0080;
        private const int SWP_NOCOPYBITS = 0x0100;
        private const int SWP_NOOWNERZORDER = 0x0200;
        private const int SWP_NOSENDCHANGING = 0x0400;
        // redraw
        private const int RDW_INVALIDATE = 0x0001;
        private const int RDW_INTERNALPAINT = 0x0002;
        private const int RDW_ERASE = 0x0004;
        private const int RDW_VALIDATE = 0x0008;
        private const int RDW_NOINTERNALPAINT = 0x0010;
        private const int RDW_NOERASE = 0x0020;
        private const int RDW_NOCHILDREN = 0x0040;
        private const int RDW_ALLCHILDREN = 0x0080;
        private const int RDW_UPDATENOW = 0x0100;
        private const int RDW_ERASENOW = 0x0200;
        private const int RDW_FRAME = 0x0400;
        private const int RDW_NOFRAME = 0x0800;
        // frame
        private const int FRAME_WIDTH = 8;
        private const int CAPTION_HEIGHT = 30;
        private const int FRAME_SMWIDTH = 4;
        private const int CAPTION_SMHEIGHT = 24;
        // misc
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_RESTORE = 0xF120;
        private const int SC_MAXIMIZE = 0xF030;
        private const int SM_SWAPBUTTON = 23;
        private const int WM_GETTITLEBARINFOEX = 0x033F;
        private const int VK_LBUTTON = 0x1;
        private const int VK_RBUTTON = 0x2;
        private const int KEY_PRESSED = 0x1000;
        private const int BLACK_BRUSH = 4;
        // proc
        private const int WM_CREATE = 0x0001;
        private const int WM_NCCALCSIZE = 0x83;
        private const int WM_NCHITTEST = 0x84;
        private const int WM_SIZE = 0x5;
        private const int WM_PAINT = 0xF;
        private const int WM_TIMER = 0x113;
        private const int WM_ACTIVATE = 0x6;
        private const int WM_NCMOUSEMOVE = 0xA0;
        private const int WM_NCMOUSEHOVER = 0x02A0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCLBUTTONUP = 0xA2;
        private const int WM_NCLBUTTONDBLCLK = 0xA3;
        private const int WM_NCRBUTTONDOWN = 0xA4;
        private const int WM_NCRBUTTONUP = 0xA5;
        private const int WM_NCRBUTTONDBLCLK = 0xA6;
        private const int WM_DWMCOMPOSITIONCHANGED = 0x031E;
        private const int WVR_ALIGNTOP = 0x0010;
        private const int WVR_ALIGNLEFT = 0x0020;
        private const int WVR_ALIGNBOTTOM = 0x0040;
        private const int WVR_ALIGNRIGHT = 0x0080;
        private const int WVR_HREDRAW = 0x0100;
        private const int WVR_VREDRAW = 0x0200;
        private const int WVR_REDRAW = (WVR_HREDRAW | WVR_VREDRAW);
        private const int WVR_VALIDRECTS = 0x400;
        private static IntPtr MSG_HANDLED = new IntPtr(0);
        #endregion

        #region Enums
        private enum HIT_CONSTANTS : int
        {
            HTERROR = -2,
            HTTRANSPARENT = -1,
            HTNOWHERE = 0,
            HTCLIENT = 1,
            HTCAPTION = 2,
            HTSYSMENU = 3,
            HTGROWBOX = 4,
            HTMENU = 5,
            HTHSCROLL = 6,
            HTVSCROLL = 7,
            HTMINBUTTON = 8,
            HTMAXBUTTON = 9,
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17,
            HTBORDER = 18,
            HTOBJECT = 19,
            HTCLOSE = 20,
            HTHELP = 21
        }

        private enum PART_TYPE : int
        {
            WP_MINBUTTON = 15,
            WP_MAXBUTTON = 17,
            WP_CLOSEBUTTON = 18,
            WP_RESTOREBUTTON = 21
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            internal int X;
            internal int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SIZE
        {
            public int cx;
            public int cy;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            internal RECT(int X, int Y, int Width, int Height)
            {
                this.Left = X;
                this.Top = Y;
                this.Right = Width;
                this.Bottom = Height;
            }
            internal int Left;
            internal int Top;
            internal int Right;
            internal int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct PAINTSTRUCT
        {
            internal IntPtr hdc;
            internal int fErase;
            internal RECT rcPaint;
            internal int fRestore;
            internal int fIncUpdate;
            internal int Reserved1;
            internal int Reserved2;
            internal int Reserved3;
            internal int Reserved4;
            internal int Reserved5;
            internal int Reserved6;
            internal int Reserved7;
            internal int Reserved8;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
            public MARGINS(int Left, int Right, int Top, int Bottom)
            {
                this.cxLeftWidth = Left;
                this.cxRightWidth = Right;
                this.cyTopHeight = Top;
                this.cyBottomHeight = Bottom;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct NCCALCSIZE_PARAMS
        {
            internal RECT rect0, rect1, rect2;
            internal IntPtr lppos;
        }
        #endregion

        #region API
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hdc, ref MARGINS marInset);

        [DllImport("dwmapi.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DwmDefWindowProc(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam, ref IntPtr result);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndAfter, int x, int y, int cx, int cy, uint flags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PtInRect([In] ref RECT lprc, Point pt);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetClientRect(IntPtr hWnd, ref RECT r);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateSolidBrush(int crColor);

        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        [DllImport("user32.dll")]
        private static extern int FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr);

        [DllImport("gdi32.dll")]
        private static extern IntPtr GetStockObject(int fnObject);

        [DllImport("user32.dll")]
        private static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool InflateRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool OffsetRect(ref RECT lprc, int dx, int dy);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);
        #endregion

        #region Fields
        private bool _bPaintWindow = false;
        private bool _bDrawCaption = false;
        private bool _bIsCompatible = false;
        private bool _bPainting = false;
        private bool _bExtendIntoFrame = false;
        private int _iCaptionHeight = CAPTION_HEIGHT;
        private int _iFrameHeight = FRAME_WIDTH;
        private int _iFrameWidth = FRAME_WIDTH;
        private int _iFrameOffset = 100;
        private int _iStoreHeight = 0;
        private RECT _tClientRect = new RECT();
        private MARGINS _tMargins = new MARGINS();
        private RECT[] _tButtonSize = new RECT[3];
        #endregion

        #region Properties
        private int CaptionHeight
        {
            get { return _iCaptionHeight; }
        }

        private int FrameWidth
        {
            get { return _iFrameWidth; }
        }

        private int FrameHeight
        {
            get { return _iFrameHeight; }
        }
        #endregion

        #region Methods
        private void ExtendMargins(int left, int top, int right, int bottom, bool drawcaption, bool intoframe)
        {
            // any negative value causes whole window client to extend
            if (left < 0 || top < 0 || right < 0 || bottom < 0)
            {
                _bPaintWindow = true;
                _tMargins.cyTopHeight = -1;
            }
            // only caption can be extended
            else if (intoframe)
            {
                _tMargins.cxLeftWidth = 0;
                _tMargins.cyTopHeight = top;
                _tMargins.cxRightWidth = 0;
                _tMargins.cyBottomHeight = 0;
            }
            // normal extender
            else
            {
                _tMargins.cxLeftWidth = left;
                _tMargins.cyTopHeight = top;
                _tMargins.cxRightWidth = right;
                _tMargins.cyBottomHeight = bottom;
            }
            _bExtendIntoFrame = intoframe;
            _bDrawCaption = drawcaption;
            _bIsCompatible = IsCompatableOS();
        }

        private void GetFrameSize()
        {
            if (this.MinimizeBox)
                _iFrameOffset = 100;
            else
                _iFrameOffset = 40;
            switch (this.FormBorderStyle)
            {
                case FormBorderStyle.Sizable:
                    {
                        _iCaptionHeight = CAPTION_HEIGHT;
                        _iFrameHeight = FRAME_WIDTH;
                        _iFrameWidth = FRAME_WIDTH;
                        break;
                    }
                case FormBorderStyle.Fixed3D:
                    {
                        _iCaptionHeight = 27;
                        _iFrameHeight = 4;
                        _iFrameWidth = 4;
                        break;
                    }
                case FormBorderStyle.FixedDialog:
                    {
                        _iCaptionHeight = 25;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.FixedSingle:
                    {
                        _iCaptionHeight = 25;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.FixedToolWindow:
                    {
                        _iFrameOffset = 20;
                        _iCaptionHeight = 21;
                        _iFrameHeight = 2;
                        _iFrameWidth = 2;
                        break;
                    }
                case FormBorderStyle.SizableToolWindow:
                    {
                        _iFrameOffset = 20;
                        _iCaptionHeight = 26;
                        _iFrameHeight = 4;
                        _iFrameWidth = 4;
                        break;
                    }
                default:
                    {
                        _iCaptionHeight = CAPTION_HEIGHT;
                        _iFrameHeight = FRAME_WIDTH;
                        _iFrameWidth = FRAME_WIDTH;
                        break;
                    }
            }
        }

        private HIT_CONSTANTS HitTest()
        {
            RECT windowRect = new RECT();
            Point cursorPoint = new Point();
            RECT posRect;
            GetCursorPos(ref cursorPoint);
            GetWindowRect(this.Handle, ref windowRect);
            cursorPoint.X -= windowRect.Left;
            cursorPoint.Y -= windowRect.Top;
            int width = windowRect.Right - windowRect.Left;
            int height = windowRect.Bottom - windowRect.Top;

            posRect = new RECT(0, 0, FrameWidth, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOPLEFT;

            posRect = new RECT(width - FrameWidth, 0, width, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOPRIGHT;

            posRect = new RECT(FrameWidth, 0, width - (FrameWidth * 2) - _iFrameOffset, FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTTOP;

            posRect = new RECT(FrameWidth, FrameHeight, width - ((FrameWidth * 2) + _iFrameOffset), _tMargins.cyTopHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTCAPTION;

            posRect = new RECT(0, FrameHeight, FrameWidth, height - FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTLEFT;

            posRect = new RECT(0, height - FrameHeight, FrameWidth, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOMLEFT;

            posRect = new RECT(FrameWidth, height - FrameHeight, width - FrameWidth, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOM;

            posRect = new RECT(width - FrameWidth, height - FrameHeight, width, height);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTBOTTOMRIGHT;

            posRect = new RECT(width - FrameWidth, FrameHeight, width, height - FrameHeight);
            if (PtInRect(ref posRect, cursorPoint))
                return HIT_CONSTANTS.HTRIGHT;

            return HIT_CONSTANTS.HTCLIENT;
        }

        public bool IsCompatableOS()
        {
            int enabled = 0;
            if (Environment.OSVersion.Version.Major >= 6)
                DwmIsCompositionEnabled(ref enabled);
            return (enabled == 1);
        }

        private void FrameChanged()
        {
            RECT rcClient = new RECT();
            GetWindowRect(this.Handle, ref rcClient);
            // force a calc size message
            SetWindowPos(this.Handle,
                         IntPtr.Zero,
                         rcClient.Left, rcClient.Top,
                         rcClient.Right - rcClient.Left, rcClient.Bottom - rcClient.Top,
                         SWP_FRAMECHANGED);
        }

        private void InvalidateWindow()
        {
            RedrawWindow(this.Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_UPDATENOW | RDW_INVALIDATE | RDW_ERASE);
        }

        private void PaintThis(IntPtr hdc, RECT rc)
        {
            RECT clientRect = new RECT();
            GetClientRect(this.Handle, ref clientRect);
            if (_bExtendIntoFrame)
            {
                clientRect.Left = _tClientRect.Left - _tMargins.cxLeftWidth;
                clientRect.Top = _tMargins.cyTopHeight;
                clientRect.Right -= _tMargins.cxRightWidth;
                clientRect.Bottom -= _tMargins.cyBottomHeight;
            }
            else if (!_bPaintWindow)
            {
                clientRect.Left = _tMargins.cxLeftWidth;
                clientRect.Top = _tMargins.cyTopHeight;
                clientRect.Right -= _tMargins.cxRightWidth;
                clientRect.Bottom -= _tMargins.cyBottomHeight;
            }
            if (!_bPaintWindow)
            {
                int clr;
                IntPtr hb;
                using (ClippingRegion cp = new ClippingRegion(hdc, clientRect, rc))
                    FillRect(hdc, ref rc, GetStockObject(BLACK_BRUSH));
                clr = ColorTranslator.ToWin32(this.BackColor);
                hb = CreateSolidBrush(clr);
                FillRect(hdc, ref clientRect, hb);
                DeleteObject(hb);
            }
            else
            {
                FillRect(hdc, ref rc, GetStockObject(BLACK_BRUSH));
            }
            if (_bExtendIntoFrame && _bDrawCaption)
            {
                Rectangle captionBounds = new Rectangle(4, 4, rc.Right, CaptionHeight);
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    using (Font fc = new Font("Segoe UI", 12, FontStyle.Regular))
                    {
                        SizeF sz = g.MeasureString(this.Text, fc);
                        int offset = (rc.Right - (int)sz.Width) / 2;
                        if (offset < 2 * FrameWidth)
                            offset = 2 * FrameWidth;
                        captionBounds.X = offset;
                        captionBounds.Y = 4;
                        using (StringFormat sf = new StringFormat())
                        {
                            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                            sf.FormatFlags = StringFormatFlags.NoWrap;
                            sf.Alignment = StringAlignment.Near;
                            sf.LineAlignment = StringAlignment.Near;
                            using (GraphicsPath path = new GraphicsPath())
                            {
                                g.SmoothingMode = SmoothingMode.HighQuality;
                                path.AddString(this.Text, fc.FontFamily, (int)fc.Style, fc.Size, captionBounds, sf);
                                g.FillPath(Brushes.Black, path);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region WndProc
        protected override void WndProc(ref Message m)
        {
            if (_bIsCompatible)
                CustomProc(ref m);
            else
                base.WndProc(ref m);
        }

        protected void CustomProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                    {
                        PAINTSTRUCT ps = new PAINTSTRUCT();
                        if (!_bPainting)
                        {
                            _bPainting = true;
                            BeginPaint(m.HWnd, ref ps);
                            PaintThis(ps.hdc, ps.rcPaint);
                            EndPaint(m.HWnd, ref ps);
                            _bPainting = false;
                            base.WndProc(ref m);
                        }
                        else
                        {
                            base.WndProc(ref m);
                        }
                        break;
                    }
                case WM_CREATE:
                    {
                        GetFrameSize();
                        FrameChanged();
                        m.Result = MSG_HANDLED;
                        base.WndProc(ref m);
                        break;
                    }
                case WM_NCCALCSIZE:
                    {
                        if (m.WParam != IntPtr.Zero && m.Result == IntPtr.Zero)
                        {
                            if (_bExtendIntoFrame)
                            {
                                NCCALCSIZE_PARAMS nc = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));
                                nc.rect0.Top -= (_tMargins.cyTopHeight > CaptionHeight ? CaptionHeight : _tMargins.cyTopHeight);
                                nc.rect1 = nc.rect0;
                                Marshal.StructureToPtr(nc, m.LParam, false);
                                m.Result = (IntPtr)WVR_VALIDRECTS;
                            }
                            base.WndProc(ref m);
                        }
                        else
                        {
                            base.WndProc(ref m);
                        }
                        break;
                    }
                case WM_SYSCOMMAND:
                    {
                        UInt32 param;
                        if (IntPtr.Size == 4)
                            param = (UInt32)(m.WParam.ToInt32());
                        else
                            param = (UInt32)(m.WParam.ToInt64());
                        if ((param & 0xFFF0) == SC_RESTORE)
                        {
                            this.Height = _iStoreHeight;
                        }
                        else if (this.WindowState == FormWindowState.Normal)
                        {
                            _iStoreHeight = this.Height;
                        }
                        base.WndProc(ref m);
                        break;
                    }
                case WM_NCHITTEST:
                    {
                        if (m.Result == (IntPtr)HIT_CONSTANTS.HTNOWHERE)
                        {
                            IntPtr res = IntPtr.Zero;
                            if (DwmDefWindowProc(m.HWnd, (uint)m.Msg, m.WParam, m.LParam, ref res))
                                m.Result = res;
                            else
                                m.Result = (IntPtr)HitTest();
                        }
                        else
                            base.WndProc(ref m);
                        break;
                    }
                case WM_DWMCOMPOSITIONCHANGED:
                case WM_ACTIVATE:
                    {
                        DwmExtendFrameIntoClientArea(this.Handle, ref _tMargins);
                        m.Result = MSG_HANDLED;
                        base.WndProc(ref m);
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        break;
                    }
            }
        }
        #endregion

        #region Clipping Region
        /// <summary>Clip rectangles or rounded rectangles</summary>
        internal class ClippingRegion : IDisposable
        {
            #region Enum
            private enum CombineRgnStyles : int
            {
                RGN_AND = 1,
                RGN_OR = 2,
                RGN_XOR = 3,
                RGN_DIFF = 4,
                RGN_COPY = 5,
                RGN_MIN = RGN_AND,
                RGN_MAX = RGN_COPY
            }
            #endregion

            #region API
            [DllImport("gdi32.dll")]
            private static extern int SelectClipRgn(IntPtr hdc, IntPtr hrgn);

            [DllImport("gdi32.dll")]
            private static extern int GetClipRgn(IntPtr hdc, [In, Out]IntPtr hrgn);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

            [DllImport("gdi32.dll")]
            private static extern int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, CombineRgnStyles fnCombineMode);

            [DllImport("gdi32.dll")]
            private static extern int ExcludeClipRect(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

            [DllImport("gdi32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool DeleteObject(IntPtr hObject);
            #endregion

            #region Fields
            private IntPtr _hClipRegion;
            private IntPtr _hDc;
            #endregion

            #region Methods
            public ClippingRegion(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect)
            {
                CreateRectangleClip(hdc, cliprect, canvasrect);
            }

            public ClippingRegion(IntPtr hdc, RECT cliprect, RECT canvasrect)
            {
                CreateRectangleClip(hdc, cliprect, canvasrect);
            }

            public ClippingRegion(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect, uint radius)
            {
                CreateRoundedRectangleClip(hdc, cliprect, canvasrect, radius);
            }

            public ClippingRegion(IntPtr hdc, RECT cliprect, RECT canvasrect, uint radius)
            {
                CreateRoundedRectangleClip(hdc, cliprect, canvasrect, radius);
            }

            public void CreateRectangleClip(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect)
            {
                _hDc = hdc;
                IntPtr clip = CreateRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRectangleClip(IntPtr hdc, RECT cliprect, RECT canvasrect)
            {
                _hDc = hdc;
                IntPtr clip = CreateRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRoundedRectangleClip(IntPtr hdc, Rectangle cliprect, Rectangle canvasrect, uint radius)
            {
                int r = (int)radius;
                _hDc = hdc;
                // create rounded regions
                IntPtr clip = CreateRoundRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom, r, r);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRoundRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom, r, r);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                // add it in
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void CreateRoundedRectangleClip(IntPtr hdc, RECT cliprect, RECT canvasrect, uint radius)
            {
                int r = (int)radius;
                _hDc = hdc;
                // create rounded regions
                IntPtr clip = CreateRoundRectRgn(cliprect.Left, cliprect.Top, cliprect.Right, cliprect.Bottom, r, r);
                IntPtr canvas = CreateRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom);
                _hClipRegion = CreateRoundRectRgn(canvasrect.Left, canvasrect.Top, canvasrect.Right, canvasrect.Bottom, r, r);
                CombineRgn(_hClipRegion, canvas, clip, CombineRgnStyles.RGN_DIFF);
                // add it in
                SelectClipRgn(_hDc, _hClipRegion);
                DeleteObject(clip);
                DeleteObject(canvas);
            }

            public void Release()
            {
                if (_hClipRegion != IntPtr.Zero)
                {
                    // remove region
                    SelectClipRgn(_hDc, IntPtr.Zero);
                    // delete region
                    DeleteObject(_hClipRegion);
                }
            }

            public void Dispose()
            {
                Release();
            }
            #endregion
        }
        #endregion
        #endregion
    }
}
