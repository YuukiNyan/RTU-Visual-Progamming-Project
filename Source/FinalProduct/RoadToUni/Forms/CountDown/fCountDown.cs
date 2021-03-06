using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;

namespace RoadToUni.Forms.CountDown
{
    public partial class fCountDown : Form
    {
        private TimeSpan daysLeft;
        string days;
        string hours;
        string mins;
        string secs;
        private Random random = new Random();
        private int currentQuote = new Random().Next(0, Quotes.quotes.Count);

        public static System.Windows.Forms.PictureBox topBackGround;

        public static string loadDate = "";

        private int search = -1;
        private int support = -1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        public fCountDown()
        {
            InitializeComponent();
            LoadBackGround();
            CreateBackGround();
        }

        private void LoadBackGround()
        {
            //if(File.Exists())
        }

        private void CreateBackGround()
        {
            topBackGround = new System.Windows.Forms.PictureBox();
            topBackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            topBackGround.BackColor = System.Drawing.Color.Transparent;
            topBackGround.BackgroundImage = RoadToUni.Forms.Login.fLogin.backGround;
            topBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            topBackGround.Location = new System.Drawing.Point(12, 12);
            topBackGround.Name = "topBackGround";
            topBackGround.Size = new System.Drawing.Size(1084, 330);
            topBackGround.TabIndex = 9;
            topBackGround.TabStop = false;
            topBackGround.Parent = this;
            topBackGround.BringToFront();
        }

        private void fCountDown_Load(object sender, EventArgs e)
        {
            search = 1;
            support = 1;

            tmSearch.Start();
            tmSupport.Start();
            ChangeFont();
            topBackGround.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, topBackGround.Width, topBackGround.Height, 20, 20));
            ToFront();

            lbTitle.Location = new Point((this.Width - lbTitle.Width) / 2, lbTitle.Location.Y);

            NextQuote();

            loadDate = RoadToUni.Forms.CountDown.LoadDate.loadDate;

            if (loadDate == "")
            {
                int year;
                if(DateTime.Now >= new DateTime(DateTime.Now.Year, 6, 7))
                {
                    year = DateTime.Now.Year + 1;
                }
                else
                {
                    year = DateTime.Now.Year;
                }
                daysLeft = -DateTime.Now.Subtract(new DateTime(year, 6, 7));
                lbSubTitle.Text = "Kỳ thi THPT Quốc Gia " + year.ToString();
            }
            else
            {
                string[] date = loadDate.Split('/');
                daysLeft = -DateTime.Now.Subtract(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])));
                lbSubTitle.Text = "Kỳ thi THPT Quốc Gia " + date[0];
            }
            lbSubTitle.Location = new Point((this.Width - lbSubTitle.Width) / 2, lbSubTitle.Location.Y);
            UpdateTime();
            tmCountDown.Start();
            timerNextQuote.Start();
        }

        private void ChangeFont()
        {
            lbQuote.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[2], 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbAuthor.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[1], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ToFront()
        {
            picRoundedRec1.BringToFront();
            picRoundedRec2.BringToFront();
            picRoundedRec3.BringToFront();
            picRoundedRec4.BringToFront();

            lbDays.BringToFront();
            lbHours.BringToFront();
            lbMins.BringToFront();
            lbSec.BringToFront();

            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            label4.BringToFront();

            lbQuote.BringToFront();
            lbAuthor.BringToFront();

            lbTitle.BringToFront();
            lbSubTitle.BringToFront();

            lbDays.Parent = topBackGround;
            lbHours.Parent = topBackGround;
            lbMins.Parent = topBackGround;
            lbSec.Parent = topBackGround;

            label1.Parent = topBackGround;
            label2.Parent = topBackGround;
            label3.Parent = topBackGround;
            label4.Parent = topBackGround;

            picRoundedRec1.Parent = topBackGround;
            picRoundedRec2.Parent = topBackGround;
            picRoundedRec3.Parent = topBackGround;
            picRoundedRec4.Parent = topBackGround;

            lbTitle.Parent = topBackGround;
            lbSubTitle.Parent = topBackGround;

            lbQuote.Parent = topBackGround;
            lbAuthor.Parent = topBackGround;

            lbQuote.BackColor = Color.FromArgb(50, 0, 0, 0);
            lbAuthor.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            daysLeft = daysLeft.Subtract(new TimeSpan(0,0,1));
            UpdateTime();
        }
        private void UpdateTime()
        {
            if (daysLeft.Days < 10)
            {
                days = "  " + daysLeft.Days.ToString();
            }
            else if(daysLeft.Days < 100)
            {
                days = " " + daysLeft.Days.ToString();
            }
            else
            {
                days = daysLeft.Days.ToString();
            }

            if (daysLeft.Hours < 10)
            {
                hours = " " + daysLeft.Hours.ToString();
            }
            else
            {
                hours = daysLeft.Hours.ToString();
            }

            if (daysLeft.Minutes < 10)
            {
                mins = " " + daysLeft.Minutes.ToString();
            }
            else
            {
                mins = daysLeft.Minutes.ToString();
            }

            if (daysLeft.Seconds < 10)
            {
                secs = " " + daysLeft.Seconds.ToString();
            }
            else
            {
                secs = daysLeft.Seconds.ToString();
            }

            lbDays.Text = days;
            lbHours.Text = hours;
            lbMins.Text = mins;
            lbSec.Text = secs;
        }


        private void fCountDown_SizeChanged(object sender, EventArgs e)
        {
            if (RoadToUni.Forms.UI.fUI.isMaximized)
            {
                topBackGround.Region = null;
            }
            else
            {
                topBackGround.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, topBackGround.Width, topBackGround.Height, 20, 20));
            }
        }

        private void btnPomo_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.UI.fUI.SwitchForm(new RoadToUni.Forms.Pomodoro.fPomodoro());
        }

        private void btnMBTI_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.UI.fUI.SwitchForm(new Đồ_án_1.Meow());
        }

        private void NextQuote()
        {
            timerNextQuote.Stop();
            int nextQuote;
            do
            {
                nextQuote = random.Next(0, Quotes.quotes.Count);
            }
            while (nextQuote == currentQuote);

            currentQuote = nextQuote;
            this.lbQuote.Text = Quotes.quotes[currentQuote];
            if(currentQuote < Quotes.authors.Count)
            {
                this.lbAuthor.Text = Quotes.authors[currentQuote];
            }
            else
            {
                this.lbAuthor.Text = "";
            }
            AdjustPos();
            timerNextQuote.Start();
        }

        private void AdjustPos()
        {
            lbQuote.Location = new Point((this.Width - lbQuote.Width) / 2, lbQuote.Location.Y);
            lbAuthor.Location = new Point(lbQuote.Location.X + lbQuote.Width - (80), lbQuote.Location.Y + lbQuote.Height + 2);
        }

        private void lbQuote_Click(object sender, EventArgs e)
        {
            NextQuote();
        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {
            NextQuote();
        }

        private void timerNextQuote_Tick(object sender, EventArgs e)
        {
            NextQuote();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(support == 1)
            {
                RoadToUni.Forms.UI.fUI.SwitchForm(new Forms.Search.FindSchool.fsearch());
            }
            else if (support == 2)
            {
                RoadToUni.Forms.UI.fUI.SwitchForm(new Forms.Search.Major.ChoosingMajor.MajorUI());
            }
        }

        private void btnDeskSearch_Click(object sender, EventArgs e)
        {
            if (search == 1)
            {
                RoadToUni.Forms.UI.fUI.SwitchForm(new Searching.Form1());
            }
            else if (search == 2)
            {
                RoadToUni.Forms.UI.fUI.SwitchForm(new Fuction4.UI());
            }
        }

        private void btnDeskTools_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.UI.fUI.SwitchForm(new Đồ_án_1.Meow());
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            search = (search == 1) ? 2 : 1;
            if(search == 1)
            {
                btnDeskSearch.BackgroundImage = Properties.Resources.countdown_score;
            }
            else if (search == 2)
            {
                btnDeskSearch.BackgroundImage = Properties.Resources.countdown_infoSchool;
            }
            tmSearch.Stop();
            tmSearch.Start();
        }

        private void btn3_CheckedChanged(object sender, EventArgs e)
        {
            support = (support == 1) ? 2 : 1;
            if (support == 1)
            {
                btnSupport.BackgroundImage = Properties.Resources.countdown_schoolSearch;
            }
            else if (support == 2)
            {
                btnSupport.BackgroundImage = Properties.Resources.countdown_jobsearch;
            }
            tmSupport.Stop();
            tmSupport.Start();
        }

        private void tmSearch_Tick(object sender, EventArgs e)
        {
            if(search == 1)
            {
                rbtn2.Checked = true;
            }
            else if (search == 2)
            {
                rbtn1.Checked = true;
            }
        }

        private void tmSupport_Tick(object sender, EventArgs e)
        {
            if (support == 1)
            {
                rbtn4.Checked = true;
            }
            else if (support == 2)
            {
                rbtn3.Checked = true;
            }
        }
    }
}
