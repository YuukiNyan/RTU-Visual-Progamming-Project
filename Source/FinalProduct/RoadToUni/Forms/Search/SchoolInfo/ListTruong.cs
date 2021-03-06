using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Fuction4
{
    public partial class Truong : UserControl
    {
        private int boderSize = 0;
        private int boderRadius = 40;
        private Color boderColor = Color.DeepSkyBlue;
        List<string> listIcon = new List<string>();

        public Truong()
        {
            InitializeComponent();
            //this.boderColor = Color.Blue;
            this.boderSize = 1;
            LoadFont();
            //pictureBox1.Image = Properties.Resources
        }

        private void LoadFont()
        {
            TenTruong.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[3], 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private GraphicsPath graphicD(Rectangle rect, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -boderSize, -boderSize);
            int smoothSize = 2;
            if (boderSize > 0)
                smoothSize = boderSize;
            if (boderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = graphicD(rectSurface, boderRadius))
                using (GraphicsPath pathBorder = graphicD(rectBorder, boderRadius - boderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(boderColor, boderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (boderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (boderSize >= 1)
                {
                    using (Pen penBorder = new Pen(boderColor, boderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        public string TuaDe { get; set; }
        public string SearchE { get; set; }
        public Image Icon { get; set; }
        public string MaTruong { get; set; }
        private void Truong_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
            TenTruong.ForeColor = Color.Black;
        }

        private void Truong_MouseEnter(object sender, EventArgs e)
        {
            foreach (Truong tr in UI.listTruong)
            {
                tr.BackColor = Color.White;
                tr.pictureBox1.BackColor = Color.White;
                tr.TenTruong.ForeColor = Color.Black;
            }
            BackColor = Color.Silver;
            pictureBox1.BackColor = Color.Silver;
            TenTruong.ForeColor = Color.White;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            foreach (Truong tr in UI.listTruong)
            {
                tr.BackColor = Color.White;
                tr.pictureBox1.BackColor = Color.White;
                tr.TenTruong.ForeColor = Color.Black;
            }
            BackColor = Color.Silver;
            pictureBox1.BackColor = Color.Silver;
            TenTruong.ForeColor = Color.White;
        }

        private void TenTruong_MouseEnter(object sender, EventArgs e)
        {
            foreach (Truong tr in UI.listTruong)
            {
                tr.BackColor = Color.White;
                tr.pictureBox1.BackColor = Color.White;
                tr.TenTruong.ForeColor = Color.Black;
            }
            BackColor = Color.Silver;
            pictureBox1.BackColor = Color.Silver;
            TenTruong.ForeColor = Color.White;
        }
        public string[] schoolName = { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM" };
        //public string[] schoolNameSearch = { "đại học bách khoa tp.hcm", "đại học công nghệ thông tin đhqg tp.hcm", "trường đại học kinh tế - luật - đhQG tphCM", "trường đại học khoa học tự nhiên, đhQG-hCM", "trường đại học khoa học Xã hội và Nhân văn, đhQG tphCM" };
      
        void click()
        {
            UI.infSchoolForm.label1.Text = "Tên trường:  " + TuaDe;
            //UI.infSchoolForm.label2.Text = "Mã trường:  " + MaTruong;
            UI.infSchoolForm.userControl21.label4.Text = "Địa chỉ:  ";
            UI.infSchoolForm.schoolcode = MaTruong;
            UI.infSchoolForm.userControl31.Code = MaTruong;
            //UI.infSchoolForm.panel1.BackgroundImage = Properties.Resources.UEL;
            //1
            if (UI.infSchoolForm.schoolcode == "QSK")
            {
                UI.infSchoolForm.schoolLink = "https://www.uel.edu.vn/";
                //UI.infSchoolForm.label3.Height = 172;
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.UEL;
                UI.infSchoolForm.userControl21.label4.Text = "Số 669 Đường Quốc lộ 1, Khu phố 3, Phường Linh Xuân, TP. Thủ Đức, TPHCM";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Kinh tế – Luật, Đại học Quốc gia Thành phố Hồ Chí Minh là trường đại học đào tạo và nghiên cứu khối ngành kinh tế, kinh doanh quản lý và luật tại Việt Nam nói chung và tại khu vực phía Nam nói riêng, nổi bật với thế mạnh về năng lực giảng viên, được xếp vào nhóm trường đại học trọng điểm quốc gia Việt Nam. Trường có tiền thân là Khoa Kinh tế thuộc Đại học Quốc gia Thành phố Hồ Chí Minh.";
                UI.infSchoolForm.userControl21.label6.Text = "University of Economics and Law - VNUHCM";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "info@uel.edu.vn";
            }
            //2
            if (UI.infSchoolForm.schoolcode == "QSB")
            {
                UI.infSchoolForm.schoolLink = "https://www.hcmut.edu.vn/vi";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QSB;
                UI.infSchoolForm.userControl21.label4.Text = "268 Lý Thường Kiệt, Phường 14, Quận 10, TPHCM";
                //UI.infSchoolForm.label3.Height = 120;
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Bách khoa là trường đại học chuyên ngành kỹ thuật lớn của Việt Nam, thành viên của hệ thống Đại học Quốc gia, được xếp vào nhóm đại học trọng điểm quốc gia Việt Nam. Tiền thân là Trung tâm Kỹ thuật Quốc gia được thành lập từ năm 1957, đến ngày 27/10/1976, Thủ tướng Phạm Văn Đồng ký Quyết định số 426/TTg đổi tên trường Đại học Kỹ thuật Phú Thọ thành trường Đại học Bách Khoa TP. Hồ Chí Minh.";
                UI.infSchoolForm.userControl21.label6.Text = "Ho Chi Minh City University of Technology";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "info@hcmut.edu.vn";
            }
            //3
            if (UI.infSchoolForm.schoolcode == "QSC")
            {
                UI.infSchoolForm.schoolLink = "https://www.uit.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.UIT;
                UI.infSchoolForm.userControl21.label4.Text = "Khu phố 6, Phường Linh Trung, TP. Thủ Đức, TPHCM";
                //UI.infSchoolForm.label3.Height = 172;
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Công nghệ Thông tin (ĐH CNTT), Đại học Quốc gia Thành phố Hồ Chí Minh (ĐHQG-HCM) là trường đại học công lập đào tạo về công nghệ thông tin và truyền thông (CNTT&TT) được thành lập theo Quyết định số 134/2006/QĐ-TTg ngày 8/6/2006 của Thủ tướng Chính phủ. Là trường thành viên của ĐHQG-HCM, trường ĐH CNTT có nhiệm vụ đào tạo nguồn nhân lực công nghệ thông tin chất lượng cao, góp phần tích cực vào sự phát triển của nền công nghiệp công nghệ thông tin Việt Nam, đồng thời tiến hành nghiên cứu khoa học và chuyển giao công nghệ thông tin tiên tiến, đặc biệt là hướng vào các ứng dụng nhằm góp phần đẩy mạnh sự nghiệp công nghiệp hóa, hiện đại hóa đất nước.";
                UI.infSchoolForm.userControl21.label6.Text = "University of Imformation Technology - VNUHCM";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "info@uit.edu.vn";
            }
            //4
            if (UI.infSchoolForm.schoolcode == "QSQ")
            {
                UI.infSchoolForm.schoolLink = "https://hcmiu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.IU;
                //UI.infSchoolForm.label3.Height = 402;
                UI.infSchoolForm.userControl21.label4.Text = "Khu phố 6, Phường Linh Trung, Thành phố Thủ Đức, TPHCM";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Quốc Tế - Đại học Quốc gia Thành phố Hồ Chí Minh là một trong bảy trường đại học thành viên trực thuộc Đại học Quốc gia Thành phố Hồ Chí Minh, được thành lập vào tháng 12 năm 2003. Đây là trường đại học công lập đa ngành đầu tiên tại Việt Nam giảng dạy hoàn toàn tiếng Anh.Năm 2019, Trường Đại học Quốc Tế là trường thứ 3 của Việt Nam và thứ 7 của Đông Nam Á đạt chuẩn kiểm định AUN cấp cơ sở đào tạo.Hiện nay, trường đang đào tạo hệ chính quy bậc đại học và sau đại học.Nhà trường tập trung đào tạo các ngành học thuộc lĩnh vực mũi nhọn như như kinh tế, quản lý, khoa học và kỹ thuật.Mô hình hoạt động của trường được xây dựng hiện đại theo tiêu chuẩn quốc tế về đội ngũ giảng viên, giáo trình, chương trình học có định hướng và liên thông với các trường đại học tại các quốc gia có nền giáo dục phát triển tại Bắc Mỹ, Châu Âu và khu vực Châu Á – Thái Bình Dương.Mục tiêu của Trường Đại học Quốc Tế là trở thành một trong những trường đại học nghiên cứu hàng đầu tại Việt Nam và trong khu vực, là cơ sở đào tạo nhận được sự hợp tác tin cậy của các đối tác giáo dục và nghiên cứu khoa học có uy tín trên thế giới, của doanh nghiệp, các địa phương và xã hội ở Việt Nam";
                UI.infSchoolForm.userControl21.label6.Text = "International University(IU) -VNU HCMC";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "info@hcmiu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QST")
            {
                UI.infSchoolForm.schoolLink = "https://www.hcmus.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.HCMUS;
                //UI.infSchoolForm.label3.Height = 238;
                UI.infSchoolForm.userControl21.label4.Text = "227 Đ. Nguyễn Văn Cừ, Phường 4, Quận 5, TPHCM";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Khoa học Tự nhiên, Đại học Quốc gia Thành phố Hồ Chí Minh là một trong những trường đại học đào tạo và nghiên cứu khoa học cơ bản & ứng dụng hàng đầu Việt Nam, trực thuộc Đại học Quốc gia Thành phố Hồ Chí Minh, được xếp vào nhóm trường đại học trọng điểm quốc gia Việt Nam. Ngày 30 tháng 3 năm 1996, trường tách ra từ Trường Đại học Tổng hợp Thành phố Hồ Chí Minh và chính thức mang tên Trường Đại học Khoa học Tự nhiên đến ngày nay. Trải qua 80 năm hình thành và phát triển, đến nay Trường Khoa học Tự nhiên đã khẳng định được vị trí của mình -trở thành đơn vị đào tạo các ngành khoa học cơ bản mạnh nhất phía nam và là một trong những trường hàng đầu về khoa học công nghệ, đặc biệt là các ngành công nghệ mũi nhọn như: công nghệ thông tin, công nghệ sinh học, điện tử-viễn thông, kỹ thuật hạt nhân...";
                UI.infSchoolForm.userControl21.label6.Text = "VNUHCM-University Of Science";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "bantin@hcmus.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QSX")
            {
                UI.infSchoolForm.schoolLink = "https://hcmussh.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.USSH;
                //UI.infSchoolForm.label3.Height = 248;
                UI.infSchoolForm.userControl21.label4.Text = "10-12 Đinh Tiên Hoàng, Phường Bến Nghé, Quận 1, TPHCM";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Khoa học Xã hội và Nhân văn, Đại học Quốc gia Thành phố Hồ Chí Minh là một thành viên của hệ thống Đại học Quốc gia Thành phố Hồ Chí Minh - hệ thống đại học xếp hạng 158 Châu Á (QS 2021), TOP 101-150 đại học dưới 50 tuổi (QS 2021), TOP 301 - 500 trong 786 cơ sở giáo dục đại học hàng đầu đến từ 78 quốc gia do QS GER 2022 xếp hạng, TOP 601 - 800 trường đại học trên thế giới trong lĩnh vực Khoa học Xã hội (THE 2022), TOP 193 thế giới về chất lượng đầu ra của cựu sinh viên (QS GER 2022). Trường có tiền thân là Đại học Văn khoa/ Văn khoa Đại học đường (thuộc Viện Đại học Sài Gòn), Đại học Tổng hợp TP. HCM. Hiện nay, Trường là trung tâm nghiên cứu, đào tạo trong lĩnh vực khoa học xã hội và nhân văn lớn nhất miền Nam Việt Nam.";
                UI.infSchoolForm.userControl21.label6.Text = "VNUHCM - University of Social Sciences and Humanities";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "phongdaotao@hcmussh.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QSY")
            {
                UI.infSchoolForm.schoolLink = "http://www.medvnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QSY;
                //UI.infSchoolForm.label3.Height = 143;
                UI.infSchoolForm.userControl21.label4.Text = "16/40 QL1A, Phường Linh Trung, Thủ Đức, Thành phố Hồ Chí Minh";
                UI.infSchoolForm.userControl21.label3.Text = "Khoa Y, Đại học Quốc gia Thành phố Hồ Chí Minh là một cơ sở đào tạo ngành y và ngành dược của hệ thống Đại học Quốc gia thành phố Hồ Chí Minh (hệ công lập), đào tạo theo mô hình Trường học - Bệnh viện, kết hợp chặt chẽ giữa đào tạo với nghiên cứu khoa học và cung cấp dịch vụ chăm sóc sức khoẻ. Trường được xếp vào nhóm Đại học trọng điểm quốc gia Việt Nam.";
                UI.infSchoolForm.userControl21.label6.Text = "Vietnamese National University - School of Medicine";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "tuyensinh@medvnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "DDQ")
            {
                UI.infSchoolForm.schoolLink = "http://due.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DDQ;
                UI.infSchoolForm.userControl21.label4.Text = "71 Ngũ Hành Sơn, Bắc Mỹ Phú, Ngũ Hành Sơn, Đà Nẵng";
                //UI.infSchoolForm.label3.Height = 89;
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Kinh tế Đà Nẵng là trường đại học đứng đầu về đào tạo khối ngành kinh tế tại miền Trung Việt Nam, trực thuộc hệ thống Đại học Đà Nẵng, đồng thời là trung tâm nghiên cứu kinh tế học lớn nhất và đi đầu tự chủ đại học của khu vực Miền Trung-Tây Nguyên.";
                UI.infSchoolForm.userControl21.label6.Text = "The University of Danang - University of Economics";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "contact@due.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "DDK")
            {
                UI.infSchoolForm.schoolLink = "http://dut.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DUT;
                //UI.infSchoolForm.label3.Height = 143;
                UI.infSchoolForm.userControl21.label4.Text = "54 Nguyễn Lương Bằng, Hoà Khánh Bắc, Liên Chiểu, Đà Nẵng";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Bách khoa Đà Nẵng là trường đại học chuyên ngành kỹ thuật đầu ngành tại Việt Nam, thành viên của hệ thống Đại học Đà Nẵng, được xếp vào nhóm đại học trọng điểm quốc gia Việt Nam. Đồng thời cũng là trung tâm nghiên cứu khoa học kỹ thuật và chuyển giao công nghệ hàng đầu khu vực, góp phần phục vụ yêu cầu phát triển kinh tế - xã hội của khu vực và cả nước, một trong ba trường Đại học Bách khoa chuyên đào tạo kỹ sư đa ngành theo định hướng nghiên cứu của Việt Nam.";
                UI.infSchoolForm.userControl21.label6.Text = "The University of Danang - University of Science and Technology";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "tchc.dhbk@dut.udn.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHE")
            {
                UI.infSchoolForm.schoolLink = "http://ueb.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHE;
                //UI.infSchoolForm.label3.Height = 143;
                UI.infSchoolForm.userControl21.label4.Text = "E4, 144 Xuân Thủy, Quận Cầu Giấy, Hà Nội, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Kinh tế là một trường thành viên của Đại học Quốc gia Hà Nội là một cơ sở đào tạo bậc đại học và sau đại học, cơ sở nghiên cứu khoa học chuyên ngành kinh tế học và kinh doanh học hàng đầu của Việt Nam.Trường đã trải qua nhiều giai đoạn chuyển đổi lịch sử và có khởi nguyên từ Khoa Kinh tế Chính trị thuộc Trường Đại học Tổng hợp Hà Nội từ năm 1974.Trải qua các giai đoạn phát triển, Trường đã mang các tên gọi: Khoa Kinh tế Chính trị trực thuộc Trường Đại học Tổng hợp Hà Nội; Khoa Kinh tế trực thuộc Trường Đại học Khoa học Xã hội và Nhân văn – ĐHQGHN; Khoa Kinh tế trực thuộc ĐHQGHN và nay là Trường Đại học Kinh tế -Đại học Quốc gia Hà Nội.Trường Đại học Kinh tế - ĐHQGHN là nơi cung cấp cho xã hội nguồn nhân lực chất lượng cao theo định hướng chuyên gia, lãnh đạo trong các lĩnh vực kinh tế, quản lý và quản trị kinh doanh đáp ứng nhu cầu phát triển chất lượng, hiệu quả và bền vững của Việt Nam; nghiên cứu và chuyển giao các kết quả nghiên cứu cho Chính phủ, các tổ chức, doanh nghiệp và xã hội lớn tại Việt Nam";
                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Economics and Business";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "news_ueb@vnu.edu.vn";
            }

            if (UI.infSchoolForm.schoolcode == "QHF")
            {
                UI.infSchoolForm.schoolLink = "https://ulis.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QUF;
                //UI.infSchoolForm.label3.Height = 172;
                UI.infSchoolForm.userControl21.label4.Text = "Số 2 Phạm Văn Đồng, Cầu Giấy, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Ngoại ngữ là một trường đại học thành viên của Đại học Quốc gia Hà Nội, được xếp vào nhóm trường đại học trọng điểm quốc gia Việt Nam. Đây được đánh giá là trường đại học đầu ngành và có lịch sử lâu đời nhất về đào tạo và giảng dạy ngôn ngữ tại Việt Nam. Trường là trung tâm đào tạo và nghiên cứu ngôn ngữ ở nhiều cấp bậc khác nhau, bao gồm các trình độ Cử nhân, Thạc sĩ và Tiến sĩ.Bên cạnh hoạt động đào tạo ở bậc đại học và sau đại học, trường Đại học Ngoại ngữ còn có hai trường thành viên là trường Trung học Phổ thông Chuyên Ngoại ngữ và trường Trung học Cơ sở Ngoại ngữ.";
                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Languages and International Studies";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "dhnn@vnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "DDF")
            {
                UI.infSchoolForm.schoolLink = "http://ufl.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DDF;
                //UI.infSchoolForm.label3.Height = 238;
                UI.infSchoolForm.userControl21.label4.Text = " 131 Lương Nhữ Hộc, Phường Khuê Trung, Quận Cẩm Lệ, Đà Nẵng";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Ngoại ngữ Đà Nẵng được thành lập theo quyết định số 709/QĐ-TTg ngày 26 tháng 8 năm 2002 của Thủ tướng chính phủ trên cơ sở tách và tổ chức lại 5 khoa ngoại ngữ của Trường Đại học Sư phạm Đà Nẵng - hiện là một trong 7 trường thành viên của Đại học Đà Nẵng. Trường Đại học Ngoại ngữ Đà Nẵng có chức năng đào tạo giáo viên và cử nhân ngôn ngữ có trình độ đại học, thạc sĩ và tiến sĩ về một số ngôn ngữ thông dụng trên thế giới, giảng dạy ngoại ngữ cho các trường thành viên thuộc Đại học Đà Nẵng, giảng dạy tiếng Việt và giới thiệu văn hoá Việt Nam cho lưu học sinh người nước ngoài trong toàn bộ các trường thành viên của Đại học Đà Nẵng. Đồng thời là trung tâm nghiên cứu khoa học và thực hiện dịch vụ xã hội thuộc lĩnh vực ngôn ngữ có uy tín của khu vực miền Trung - Tây Nguyên.";
                UI.infSchoolForm.userControl21.label6.Text = "The University of Danang - University of Foreign Language Studies";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "dhnn@ufl.udn.vn";
            }
            //

            if (UI.infSchoolForm.schoolcode == "DDS")
            {
                UI.infSchoolForm.schoolLink = "https://ued.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DDS;
                UI.infSchoolForm.userControl21.label4.Text = "459 Tôn Đức Thắng, phường Hòa Khánh Nam, quận Liên Chiểu, Đà Nẵng.";
                //UI.infSchoolForm.label3.Height = 115;
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Sư phạm Đà Nẵng là trường thành viên Đại học Đà Nẵng, chuyên đào tạo các chuyên ngành sư phạm và cử nhân khoa học, được xếp vào nhóm các trường Đại học Sư phạm trọng điểm quốc gia Việt Nam. Trường đồng thời là trung tâm nghiên cứu khoa học giáo dục và triển khai công nghệ phục vụ yêu cầu phát triển kinh tế - xã hội các tỉnh, thành phố miền Trung - Tây Nguyên";
                UI.infSchoolForm.userControl21.label6.Text = "The University of Da Nang - University of Science and Education";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "ued@ued.udn.vn";
            }
            if (UI.infSchoolForm.schoolcode == "DSK")
            {
                UI.infSchoolForm.schoolLink = "https://ute.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DSK;
                //UI.infSchoolForm.label3.Height = 220;
                UI.infSchoolForm.userControl21.label4.Text = "48 Cao Thắng, Thanh Bình, Hải Châu, Đà Nẵng";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Sư phạm Kỹ thuật Đà Nẵng là một trường đại học chuyên ngành về khối ngành kỹ thuật tại Việt Nam, được đánh giá là một trong những trường đại học đầu ngành về đào tạo khối ngành kỹ thuật tại Miền Trung Việt Nam. Trường trực thuộc hệ thống Đại học Đại học Đà Nẵng, được xếp vào nhóm đại học trọng điểm quốc gia Việt Nam. Trường đồng thời là trung tâm nghiên cứu kỹ thuật lớn của khu vực miền Trung. Tiền thân là trường Kỹ thuật Đà Nẵng, Trường Đại học Sư phạm Kỹ thuật Đà Nẵng là một trong 6 trường Đại học Sư phạm Kỹ thuật của cả nước – đào tạo kỹ thuật lấy ứng dụng làm trọng tâm để giảng dạy, có chức năng đào tạo kỹ sư công nghệ, kỹ sư theo định hướng ứng dụng và giáo viên kỹ thuật.";
                UI.infSchoolForm.userControl21.label6.Text = "The University of Danang - University of Technology and Education";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "dhspktdn@ute.udn.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHI")
            {
                UI.infSchoolForm.schoolLink = "https://uet.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHI;
                //UI.infSchoolForm.label3.Height = 341;
                UI.infSchoolForm.userControl21.label4.Text = "E3, 144 Xuân Thủy, Cầu Giấy, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Công nghệ, Đại học Quốc gia Hà Nội được thành lập theo Quyết định số 92/2004/QĐ-TTg ngày 25/05/2004 của Thủ tướng Chính phủ trên cơ sở Khoa Công nghệ và Trung tâm Hợp tác Đào tạo và Bồi dưỡng Cơ học trực thuộc Đại học Quốc gia Hà Nội với hai nhiệm vụ như sau: Đào tạo nguồn nhân lực trình độ đại học, sau đại học và bồi dưỡng nhân tài thuộc lĩnh vực khoa học, công nghệ; Nghiên cứu và triển khai ứng dụng khoa học, công nghệ đáp ứng nhu cầu phát triển kinh tế – xã hội. Sứ mạng của Nhà trường là đào tạo nguồn nhân lực chất lượng cao, trình độ cao và bồi dưỡng nhân tài; nghiên cứu phát triển và ứng dụng các lĩnh vực khoa học công nghệ tiên tiến mũi nhọn trên cơ sở phát huy thế mạnh về Công nghệ thông tin và Truyền thông. Nhà trường cũng đã xác định sứ mạng tiên phong tiếp cận chuẩn mực giáo dục đại học khu vực và thế giới, ứng dụng công nghệ thông tin trong quản trị đại học đóng góp tích cực vào sự phát triển nền kinh tế và xã hội tri thức của đất nước. Sứ mạng này hoàn toàn phù hợp và thống nhất với chủ trương, giải pháp và các mục tiêu của Chương trình đổi mới toàn diện giáo dục đại học mà Đảng và Nhà nước đang triển khai thực hiện.";
                UI.infSchoolForm.userControl21.label6.Text = "University of Engineering and Technology";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "uet@vnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHS")
            {
                UI.infSchoolForm.schoolLink = "http://education.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHS;
                //UI.infSchoolForm.label3.Height = 172;
                UI.infSchoolForm.userControl21.label4.Text = "G7, số 144 Đường Xuân Thuỷ, quận Cầu Giấy, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Giáo dục là một trường đại học thành viên trực thuộc Đại học Quốc gia Hà Nội, Việt Nam. Đây là nơi đào tạo, bồi dưỡng chuyên gia giáo dục và nhà giáo cho mọi bậc học ở Việt Nam.Trường Đại học Giáo dục, ĐHQGHN là cơ sở giáo dục đại học đào tạo và nghiên cứu chất lượng cao và trình độ cao trong khoa học và công nghệ giáo dục, ứng dụng cho đào tạo giáo viên, cán bộ quản lý và các nhóm nhân lực khác trong lĩnh vực giáo dục.";

                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Education";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "education@vnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "DDY")
            {
                UI.infSchoolForm.schoolLink = "http://smp.udn.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.DDY;
                //UI.infSchoolForm.label3.Height = 270;
                UI.infSchoolForm.userControl21.label4.Text = "Khu đô thị  Đại học Đà Nẵng, P. Hòa Quý, Q. Ngũ Hành Sơn, TP. Đà Nẵng";
                UI.infSchoolForm.userControl21.label3.Text = "Khoa Y Dược trực thuộc Đại học Đà Nẵng được thành lập theo Quyết định số 1154 / QĐ - TCCB ngày 16 / 3 / 2007 của Giám đốc Đại học Đà Nẵng, với nhiệm vụ: đào tạo nguồn nhân lực y tế có trình độ đại học, sau đại học; bồi dưỡng chuyên môn cho cán bộ y tế trong các bệnh viện và các cơ sở y tế; nghiên cứu khoa học, hợp tác quốc tế trong lĩnh vực y – dược.Đại học Đà Nẵng(ĐHĐN) với vị thế một đại học vùng, trọng điểm quốc gia, là “nơi hun đúc trí tuệ và tài năng vì sự phát triển của miền Trung – Tây nguyên”. ĐHĐN có nhiều lợi thế về đội ngũ giảng viên và cơ sở vật chất, uy tín giảng dạy và nghiên cứu khoa học trong các lĩnh vực kỹ thuật công nghệ, kinh tế, sư phạm, ngoại ngữ,… ĐHĐN đang từng bước phát triển thành đại học nghiên cứu, khẳng định chất lượng trong cộng đồng các trường Đại học khu vực và thế giới. Những nguồn lực căn bản của ĐHĐN cho phép phát triển thành đại học đa ngành, đóng góp hữu hiệu vào sự nghiệp đào tạo nguồn nhân lực Y tế và sự nghiệp chăm sóc, bảo vệ sức khỏe nhân dân trong khu vực cũng như trên cả nước.";
                UI.infSchoolForm.userControl21.label6.Text = "Faculty of Medicine and Pharmacy";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "smp@ac.udn.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHT")
            {
                UI.infSchoolForm.schoolLink = "http://hus.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHT;
                //UI.infSchoolForm.label3.Height = 240;
                UI.infSchoolForm.userControl21.label4.Text = "334 Nguyễn Trãi - Thanh Xuân - Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Khoa học Tự nhiên, Đại học Quốc gia Hà Nội là một trong những trường đại học thành viên của Đại học Quốc gia Hà Nội; là đơn vị trọng điểm, đầu ngành của Việt Nam về đào tạo, nghiên cứu khoa học cơ bản và khoa học công nghệ, mang tính ứng dụng cao (trong các lĩnh vực Toán học, Toán cơ, Toán - Tin ứng dụng, Máy tính và Khoa học thông tin, Khoa học dữ liệu, Vật lý học, Kỹ thuật điện tử tin học, Khoa học vật liệu, Công nghệ hạt nhân; Hóa học, Công nghệ kỹ thuật hóa học, Hóa dược; Sinh học, Công nghệ sinh học; Địa lý tự nhiên, Quản lý đất đai; Khoa học thông tin địa không gian; Quản lý phát triển đô thị và bất động sản; Địa chất học, Kỹ thuật địa chất, Quản lý tài nguyên và môi trường; Khoa học môi trường, Khoa học đất, Công nghệ kỹ thuật môi trường; Khí tượng học, Thủy văn học, Hải dương học).";
                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Science";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "hus@vnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHY")
            {
                UI.infSchoolForm.schoolLink = "http://ump.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHY;
                //UI.infSchoolForm.label3.Height = 143;
                UI.infSchoolForm.userControl21.label4.Text = "1 Tôn Thất Tùng, Kim Liên, Đống Đa, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Y Dược là trường đại học chuyên ngành y khoa và dược học tại Việt Nam, thành viên của Đại học Quốc gia Hà Nội. Trường có nhiệm vụ đào tạo bác sĩ, dược sĩ, cử nhân về lĩnh vực y tế có trình độ bậc đại học, sau đại học, nghiên cứu khoa học chuyên ngành y khoa và dược học, đáp ứng nhu cầu chăm sóc sức khỏe, phát triển y tế.Trường Đại học Y Dược xác định các lĩnh vực hoạt động chủ yếu là đào tạo, nghiên cứu khoa học công nghê, tiếp nhận và chuyển giao tri thức, cung cấp dịch vụ y tế chất lượng cao, đáp ứng nhu cầu xã hội dựa trên nền tảng tri thức cập nhật và nguồn nhân lực chuyên môn có đạo đức, trách nhiệm, tri thức, kỹ thuật cao.";
                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Medicine and Pharmacy";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = " media.ump@vnu.edu.vn";
            }
            if (UI.infSchoolForm.schoolcode == "QHX")
            {
                UI.infSchoolForm.schoolLink = "https://ussh.vnu.edu.vn/";
                UI.infSchoolForm.pictureBox2.Image = RoadToUni.Properties.Resources.QHX;
                //UI.infSchoolForm.label3.Height = 336;
                UI.infSchoolForm.userControl21.label4.Text = "336 Nguyễn Trãi, Thanh Xuân Trung, Thanh Xuân, Hà Nội";
                UI.infSchoolForm.userControl21.label3.Text = "Trường Đại học Khoa học Xã hội và Nhân văn, Đại học Quốc gia Hà Nội là một trường đại học thành viên của Đại học Quốc gia Hà Nội. Trường ĐHKHXH&NV, ĐHQGHN có sứ mệnh đi đầu trong đào tạo nguồn nhân lực chất lượng cao, trình độ cao; nghiên cứu, sáng tạo và truyền bá tri thức về Khoa học xã hội và nhân văn, phục vụ sự nghiệp xây dựng, bảo vệ Tổ quốc và hội nhập quốc tế.Phát huy thế mạnh của một trường đại học khoa học cơ bản, tập trung nguồn lực xây dựng Trường ĐHKHXH&NV thành một trường đại học nghiên cứu, đa ngành và liên ngành với đội ngũ chuyên gia giỏi, đầu ngành; phát triển một số ngành, chuyên ngành đào tạo mới, tiên phong đóng vai trò nòng cốt trong đào tạo và nghiên cứu các ngành khoa học cơ bản của đất nước đạt trình độ khu vực và quốc tế; xếp vào nhóm 100 các trường đại học hàng đầu của khu vực châu Á và nhóm 500 đại học của thế giới.";
                UI.infSchoolForm.userControl21.label6.Text = "VNU University of Social Sciences and Humanities";
                UI.infSchoolForm.userControl21.DiachiEmail.Text = "contact@ussh.edu.vn";
            }
            UI.infSchoolForm.ChangeCheck();
            UI.infSchoolForm.Show();
        }

        void fontcustom()
        {
            

        }

        private void Truong_Click(object sender, EventArgs e)
        {
            click();
        }

        private void Truong_Load(object sender, EventArgs e)
        {

            UI.FontCustom(TenTruong.Font,TenTruong,TuaDe);
            

            //pfc.Dispose();
            //Marshal.FreeCoTaskMem(data);
            if (MaTruong != "")
            {
                if (MaTruong == "QSK")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.UEL;
                }
                if (MaTruong == "QSB")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QSB;
                }
                if (MaTruong == "QSC")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.UIT;
                }
                if (MaTruong == "QSQ")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.IU;
                }
                if (MaTruong == "QST")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.HCMUS;
                }
                if (MaTruong == "QSX")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.USSH;
                }
                if (MaTruong == "QSY")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QSY;
                }
                if (MaTruong == "DDQ")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DDQ;
                }
                if (MaTruong == "DDK")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DUT;
                }
                if (MaTruong == "QHE")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHE;
                }
                //

                if (MaTruong == "QHF")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QUF;
                }
                if (MaTruong == "DDF")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DDF;
                }
                //

                if (MaTruong == "DDS")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DDS;
                }
                if (MaTruong == "DSK")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DSK;
                }
                if (MaTruong == "QHI")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHI;
                }
                if (MaTruong == "QHS")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHS;
                }
                if (MaTruong == "DDY")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.DDY;
                }
                if (MaTruong == "QHT")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHT;
                }
                if (MaTruong == "QHY")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHY;
                }
                if (MaTruong == "QHX")
                {
                    pictureBox1.Image = RoadToUni.Properties.Resources.QHX;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click();
        }

        private void TenTruong_Click(object sender, EventArgs e)
        {
            click();
        }
    }
}
