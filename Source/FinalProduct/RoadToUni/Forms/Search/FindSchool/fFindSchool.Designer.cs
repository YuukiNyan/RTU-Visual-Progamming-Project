﻿
namespace RoadToUni.Forms.Search.FindSchool
{
    partial class fFindSchool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbGrade = new System.Windows.Forms.TextBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbNameUni = new System.Windows.Forms.Label();
            this.cbCombination = new System.Windows.Forms.ComboBox();
            this.lbComb = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.cbNameUni = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGrade
            // 
            this.txbGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbGrade.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGrade.ForeColor = System.Drawing.Color.DarkGray;
            this.txbGrade.Location = new System.Drawing.Point(398, 96);
            this.txbGrade.Name = "txbGrade";
            this.txbGrade.Size = new System.Drawing.Size(277, 29);
            this.txbGrade.TabIndex = 0;
            this.txbGrade.TabStop = false;
            this.txbGrade.Text = "Điểm xét tuyển dự kiến";
            this.txbGrade.Enter += new System.EventHandler(this.txbGrade_Enter);
            this.txbGrade.Leave += new System.EventHandler(this.txbGrade_Leave);
            // 
            // lbGrade
            // 
            this.lbGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGrade.AutoSize = true;
            this.lbGrade.BackColor = System.Drawing.Color.Gold;
            this.lbGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGrade.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbGrade.Location = new System.Drawing.Point(105, 96);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(286, 33);
            this.lbGrade.TabIndex = 2;
            this.lbGrade.Text = "Nhập tổng điểm dự kiến \r\n";
            // 
            // lbNameUni
            // 
            this.lbNameUni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameUni.AutoSize = true;
            this.lbNameUni.BackColor = System.Drawing.Color.Gold;
            this.lbNameUni.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUni.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbNameUni.Location = new System.Drawing.Point(105, 146);
            this.lbNameUni.Name = "lbNameUni";
            this.lbNameUni.Size = new System.Drawing.Size(160, 31);
            this.lbNameUni.TabIndex = 3;
            this.lbNameUni.Text = "Chọn trường ";
            // 
            // cbCombination
            // 
            this.cbCombination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCombination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCombination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCombination.DropDownHeight = 125;
            this.cbCombination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCombination.DropDownWidth = 120;
            this.cbCombination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCombination.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombination.ForeColor = System.Drawing.Color.Black;
            this.cbCombination.FormattingEnabled = true;
            this.cbCombination.IntegralHeight = false;
            this.cbCombination.ItemHeight = 21;
            this.cbCombination.Items.AddRange(new object[] {
            "A00 -- Toán, Vật lý, Hóa học",
            "A01 -- Toán, Vật lý, Tiếng Anh",
            "B00 -- Toán, Hóa học, Sinh học",
            "C00 -- Văn, Sử, Địa",
            "D01 -- Văn, Toán, tiếng Anh",
            "D07 -- Toán, Hóa học, Tiếng Anh",
            "A02 -- Toán, Vật lí , Sinh học",
            "A03 -- Toán, Vật lý, Lịch sử",
            "A04 -- Toán, Vật lý, Địa lí",
            "A05 -- Toán, Hóa học, Lịch sử",
            "A06 -- Toán, Hóa học, Địa lí",
            "A07 -- Toán, Lịch sử, Địa lí",
            "A08 -- Toán, Lịch sử, Giáo dục công dân",
            "A09 -- Toán, Địa lí, Giáo dục công dân",
            "A10 -- Toán, Vật lý, Giáo dục công dân",
            "A11 -- Toán, Hóa học, Giáo dục công dân",
            "A12 -- Toán, Khoa học tự nhiên, Khoa học xã hội",
            "A14 -- Toán, Khoa học tự nhiên, Địa lí",
            "A15 -- Toán, Khoa học tự nhiên, Giáo dục công dân",
            "A16 -- Toán, Khoa học tự nhiên, Văn",
            "A17 -- Toán, Khoa học xã hội, Vật lý",
            "A18 -- Toán, Khoa học xã hội, Hóa học",
            "B01 -- Toán, Sinh học, Lịch sử",
            "B02 -- Toán, Sinh học, Địa lí",
            "B03 -- Toán, Sinh học, Văn",
            "B04 -- Toán, Sinh học, Giáo dục công dân",
            "B05 -- Toán, Sinh học, Khoa học xã hội",
            "B08 -- Toán, Sinh học, Tiếng Anh",
            "C01 -- Văn, Toán, Vật lí",
            "C02 -- Văn, Toán, Hóa học",
            "C03 -- Văn, Toán, Lịch sử",
            "C04 -- Văn, Toán, Địa lí",
            "C05 -- Văn, Vật lí, Hóa học",
            "C06 -- Văn, Vật lí, Sinh học",
            "C07 -- Văn, Vật lí, Lịch sử",
            "C08 -- Văn, Hóa học, Sinh",
            "C09 -- Văn, Vật lí, Địa lí",
            "C10 -- Văn, Hóa học, Lịch sử",
            "C12 -- Văn, Sinh học, Lịch sử",
            "C13 -- Văn, Sinh học, Địa",
            "C14 -- Văn, Toán, Giáo dục công dân",
            "C15 -- Văn, Toán, Khoa học xã hội",
            "C16 -- Văn, Vật lí, Giáo dục công dân",
            "C17 -- Văn, Hóa học, Giáo dục công dân",
            "C19 -- Văn, Lịch sử, Giáo dục công dân",
            "C20 -- Văn, Địa lí, Giáo dục công dân",
            "D02 -- Văn, Toán, tiếng Nga",
            "D03 -- Văn, Toán, tiếng Pháp",
            "D04 -- Văn, Toán, tiếng Trung",
            "D05 -- Văn, Toán, Tiếng Đức",
            "D06 -- Văn, Toán, Tiếng Nhật",
            "D08 -- Toán, Sinh học, Tiếng Anh",
            "D09 -- Toán, Lịch sử, Tiếng Anh",
            "D10 -- Toán, Địa lí, Tiếng Anh",
            "D11 -- Văn, Vật lí, Tiếng Anh",
            "D12 -- Văn, Hóa học, Tiếng Anh",
            "D13 -- Văn, Sinh học, Tiếng Anh",
            "D14 -- Văn, Lịch sử, Tiếng Anh",
            "D15 -- Văn, Địa lí, Tiếng Anh",
            "D16 -- Toán, Địa lí, Tiếng Đức",
            "D17 -- Toán, Địa lí, Tiếng Nga",
            "D18 -- Toán, Địa lí, Tiếng Nhật",
            "D19 -- Toán, Địa lí, Tiếng Pháp",
            "D20 -- Toán, Địa lí, Tiếng Trung",
            "D21 -- Toán, Hóa học, Tiếng Đức",
            "D22 -- Toán, Hóa học, Tiếng Nga",
            "D23 -- Toán, Hóa học, Tiếng Nhật",
            "D24 -- Toán, Hóa học, Tiếng Pháp",
            "D25 -- Toán, Hóa học, Tiếng Trung",
            "D26 -- Toán, Vật lí, Tiếng Đức",
            "D27 -- Toán, Vật lí, Tiếng Nga",
            "D28 -- Toán, Vật lí, Tiếng Nhật",
            "D29 -- Toán, Vật lí, Tiếng Pháp",
            "D30 -- Toán, Vật lí, Tiếng Trung",
            "D31 -- Toán, Sinh học, Tiếng Đức",
            "D32 -- Toán, Sinh học, Tiếng Nga",
            "D33 -- Toán, Sinh học, Tiếng Nhật",
            "D34 -- Toán, Sinh học, Tiếng Pháp",
            "D35 -- Toán, Sinh học, Tiếng Trung",
            "D41 -- Văn, Địa lí, Tiếng Đức",
            "D42 -- Văn, Địa lí, Tiếng Nga",
            "D43 -- Văn, Địa lí, Tiếng Nhật",
            "D44 -- Văn, Địa lí, Tiếng Pháp",
            "D45 -- Văn, Địa lí, Tiếng Trung",
            "D52 -- Văn, Vật lí, Tiếng Nga",
            "D54 -- Văn, Vật lí, Tiếng Pháp",
            "D55 -- Văn, Vật lí, Tiếng Trung",
            "D61 -- Văn, Lịch sử, Tiếng Đức",
            "D62 -- Văn, Lịch sử, Tiếng Nga",
            "D63 -- Văn, Lịch sử, Tiếng Nhật",
            "D64 -- Văn, Lịch sử, Tiếng Pháp",
            "D65 -- Văn, Lịch sử, Tiếng Trung",
            "D66 -- Văn, Giáo dục công dân, Tiếng Anh",
            "D68 -- Văn, Giáo dục công dân, Tiếng Nga",
            "D69 -- Văn, Giáo dục công dân, Tiếng Nhật",
            "D70 -- Văn, Giáo dục công dân, Tiếng Pháp",
            "D72 -- Văn, Khoa học tự nhiên, Tiếng Anh",
            "D73 -- Văn, Khoa học tự nhiên, Tiếng Đức",
            "D74 -- Văn, Khoa học tự nhiên, Tiếng Nga",
            "D75 -- Văn, Khoa học tự nhiên, Tiếng Nhật",
            "D76 -- Văn, Khoa học tự nhiên, Tiếng Pháp",
            "D77 -- Văn, Khoa học tự nhiên, Tiếng Trung",
            "D78 -- Văn, Khoa học xã hội, Tiếng Anh",
            "D79 -- Văn, Khoa học xã hội, Tiếng Đức",
            "D80 -- Văn, Khoa học xã hội, Tiếng Nga",
            "D81 -- Văn, Khoa học xã hội, Tiếng Nhật",
            "D82 -- Văn, Khoa học xã hội, Tiếng Pháp",
            "D83 -- Văn, Khoa học xã hội, Tiếng Trung",
            "D84 -- Toán, Giáo dục công dân, Tiếng Anh",
            "D85 -- Toán, Giáo dục công dân, Tiếng Đức",
            "D86 -- Toán, Giáo dục công dân, Tiếng Nga",
            "D87 -- Toán, Giáo dục công dân, Tiếng Pháp",
            "D88 -- Toán, Giáo dục công dân, Tiếng Nhật",
            "D90 -- Toán, Khoa học tự nhiên, Tiếng Anh",
            "D91 -- Toán, Khoa học tự nhiên, Tiếng Pháp",
            "D92 -- Toán, Khoa học tự nhiên, Tiếng Đức",
            "D93 -- Toán, Khoa học tự nhiên, Tiếng Nga",
            "D94 -- Toán, Khoa học tự nhiên, Tiếng Nhật",
            "D95 -- Toán, Khoa học tự nhiên, Tiếng Trung",
            "D96 -- Toán, Khoa học xã hội, Anh",
            "D97 -- Toán, Khoa học xã hội, Tiếng Pháp",
            "D98 -- Toán, Khoa học xã hội, Tiếng Đức",
            "D99 -- Toán, Khoa học xã hội, Tiếng Nga",
            "H00 -- Văn, Năng khiếu vẽ 1, Năng khiếu vẽ 2",
            "H01 -- Toán, Văn, Vẽ",
            "H02 -- Toán, Vẽ Hình họa mỹ thuật, Vẽ trang trí màu",
            "H03 -- Toán, Khoa học tự nhiên, Vẽ Năng khiếu",
            "H04 -- Toán, Tiếng Anh, Vẽ Năng khiếu",
            "H05 -- Văn, Khoa học xã hội, Vẽ Năng khiếu",
            "H06 -- Văn, Tiếng Anh,Vẽ mỹ thuật",
            "H07 -- Toán, Hình họa, Trang trí",
            "H08 -- Văn, Lịch sử, Vẽ mỹ thuật",
            "V00 -- Toán, Vật lí, Vẽ Hình họa mỹ thuật",
            "V01 -- Toán, Văn, Vẽ Hình họa mỹ thuật",
            "V02 -- VẼ MT, Toán, Tiếng Anh",
            "V03 -- VẼ MT, Toán, Hóa",
            "V05 -- Văn, Vật lí, Vẽ mỹ thuật",
            "V06 -- Toán, Địa lí, Vẽ mỹ thuật",
            "V07 -- Toán, tiếng Đức, Vẽ mỹ thuật",
            "V08 -- Toán, tiếng Nga, Vẽ mỹ thuật",
            "V09 -- Toán, tiếng Nhật, Vẽ mỹ thuật",
            "V10 -- Toán, tiếng Pháp, Vẽ mỹ thuật",
            "V11 -- Toán, tiếng Trung, Vẽ mỹ thuật",
            "M00 -- Văn, Toán, Đọc diễn cảm, Hát",
            "M01 -- Văn, Lịch sử, Năng khiếu",
            "M02 -- Toán, Năng khiếu 1, Năng khiếu 2",
            "M03 -- Văn, Năng khiếu 1, Năng khiếu 2",
            "M04 -- Toán, KHTN, Năng khiếu",
            "M05 -- Văn, Sử, Năng khiếu",
            "M06 -- Văn, Toán, Năng khiếu",
            "M07 -- Văn, Địa, Đọc diễn cảm + Hát",
            "M08 -- Văn, NK 1, NK 2",
            "M09 -- Toán, Kể chuyện – Đọc diễn cảm, Hát",
            "M10 -- Toán, Tiếng Anh, Năng khiếu mầm non",
            "M11 -- Văn, Anh, Năng khiếu GDMN",
            "M13 -- Toán, Sinh, Năng khiếu",
            "M14 -- Toán, Địa, Đọc diễn cảm – Hát",
            "N00 -- Văn, Năng khiếu Âm nhạc 1, Năng khiếu Âm nhạc 2",
            "N01 -- Văn, Hát xướng âm, Biểu diễn nghệ thuật",
            "N02 -- Văn, Ký xướng âm, Hát hoặc biểu diễn nhạc cụ",
            "N03 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N04 -- Văn, Năng khiếu thuyết trình, Năng khiếu",
            "N05 -- Văn, Xây dựng kịch bản sự kiện, Năng khiếu",
            "N06 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N07 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N08 -- Văn, Hòa thanh, Phát triển chủ đề và phổ thơ",
            "N09 -- Văn, Hòa thanh, Chỉ huy tại chỗ",
            "R00 -- Văn, Sử, Năng khiếu nghệ thuật",
            "R01 -- Văn, Địa, Năng khiếu nghệ thuật",
            "R02 -- Văn, Toán, Năng khiếu nghệ thuật",
            "R03 -- Văn, Anh, Năng khiếu nghệ thuật",
            "R04 -- Văn, Biểu diễn nghệ thuật, Năng khiếu văn hóa nghệ thuật",
            "R05 -- Văn, Anh, Năng khiếu báo chí",
            "R06 -- Văn, KHTN, Năng khiếu báo chí",
            "R07 -- Văn, Toán, Năng khiếu ảnh báo chí",
            "R08 -- Văn, Anh, Năng khiếu ảnh báo chí",
            "R09 -- Văn, KHTN, Năng khiếu ảnh báo chí",
            "R11 -- Văn, Toán, Năng khiếu quay phim truyền hình",
            "R12 -- Văn, Anh, Năng khiếu quay phim truyền hình",
            "R13 -- Văn, KHTN, Năng khiếu quay phim truyền hình",
            "R15 -- Văn, Toán, Năng khiếu báo chí",
            "R16 -- Văn, KHXH, Năng khiếu báo chí",
            "R17 -- Văn, KHXH, Năng khiếu ảnh báo chí",
            "R18 -- Văn, KHXH, Năng khiếu quay phim truyền hình",
            " R19 --Văn, Điểm quy đổi chứng chỉ Tiếng Anhh, Năng khiếu báo chí",
            " R20 --Văn, Điểm quy đổi chứng chỉ Tiếng Anh, Năng khiếu ảnh báo chí",
            "R21 -- Văn, Điểm quy đổi chứng chỉ Tiếng Anh, NK quay phim truyền hình",
            "R22 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R23 -- Văn, Sử, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R24 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R25 -- Văn, KHTN, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R26 -- Văn, KHXH, Điểm quy đổi chứng chỉ Tiếng Anh",
            "T00 -- Toán, Sinh, Năng khiếu Thể dục thể thao",
            "T01 -- Toán, Văn, Năng khiếu TDTT",
            "T02 -- Văn, Sinh, Năng khiếu TDTT",
            "T03 -- Văn, Địa, Năng khiếu TDTT",
            "T04 -- Toán, Lý, Năng khiếu TDTT",
            "T05 -- Văn, GDCD, Năng khiếu TDTT",
            "T07 -- Văn, Địa, Năng khiếu TDTT",
            "T08 -- Toán, GDCD, Năng khiếu TDTT",
            "S00 -- Văn, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            "S01 -- Toán, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            ""});
            this.cbCombination.Location = new System.Drawing.Point(398, 201);
            this.cbCombination.MaxDropDownItems = 10;
            this.cbCombination.Name = "cbCombination";
            this.cbCombination.Size = new System.Drawing.Size(423, 29);
            this.cbCombination.TabIndex = 0;
            this.cbCombination.TabStop = false;
            // 
            // lbComb
            // 
            this.lbComb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbComb.AutoSize = true;
            this.lbComb.BackColor = System.Drawing.Color.Gold;
            this.lbComb.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComb.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbComb.Location = new System.Drawing.Point(105, 197);
            this.lbComb.Name = "lbComb";
            this.lbComb.Size = new System.Drawing.Size(152, 31);
            this.lbComb.TabIndex = 5;
            this.lbComb.Text = "Chọn tổ hợp";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Tomato;
            this.btnSearch.Image = global::RoadToUni.Properties.Resources.btnSearch__1_;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(827, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 68);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "    Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewResult
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResult.Location = new System.Drawing.Point(105, 255);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 62;
            this.dataGridViewResult.RowTemplate.Height = 28;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(901, 344);
            this.dataGridViewResult.TabIndex = 7;
            // 
            // cbNameUni
            // 
            this.cbNameUni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNameUni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNameUni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameUni.BackColor = System.Drawing.SystemColors.Window;
            this.cbNameUni.DropDownHeight = 175;
            this.cbNameUni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameUni.DropDownWidth = 120;
            this.cbNameUni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNameUni.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNameUni.ForeColor = System.Drawing.Color.Black;
            this.cbNameUni.FormattingEnabled = true;
            this.cbNameUni.IntegralHeight = false;
            this.cbNameUni.ItemHeight = 21;
            this.cbNameUni.Items.AddRange(new object[] {
            "A00 -- Toán, Vật lý, Hóa học",
            "A01 -- Toán, Vật lý, Tiếng Anh",
            "B00 -- Toán, Hóa học, Sinh học",
            "C00 -- Văn, Sử, Địa",
            "D01 -- Văn, Toán, tiếng Anh",
            "D07 -- Toán, Hóa học, Tiếng Anh",
            "A02 -- Toán, Vật lí , Sinh học",
            "A03 -- Toán, Vật lý, Lịch sử",
            "A04 -- Toán, Vật lý, Địa lí",
            "A05 -- Toán, Hóa học, Lịch sử",
            "A06 -- Toán, Hóa học, Địa lí",
            "A07 -- Toán, Lịch sử, Địa lí",
            "A08 -- Toán, Lịch sử, Giáo dục công dân",
            "A09 -- Toán, Địa lí, Giáo dục công dân",
            "A10 -- Toán, Vật lý, Giáo dục công dân",
            "A11 -- Toán, Hóa học, Giáo dục công dân",
            "A12 -- Toán, Khoa học tự nhiên, Khoa học xã hội",
            "A14 -- Toán, Khoa học tự nhiên, Địa lí",
            "A15 -- Toán, Khoa học tự nhiên, Giáo dục công dân",
            "A16 -- Toán, Khoa học tự nhiên, Văn",
            "A17 -- Toán, Khoa học xã hội, Vật lý",
            "A18 -- Toán, Khoa học xã hội, Hóa học",
            "B01 -- Toán, Sinh học, Lịch sử",
            "B02 -- Toán, Sinh học, Địa lí",
            "B03 -- Toán, Sinh học, Văn",
            "B04 -- Toán, Sinh học, Giáo dục công dân",
            "B05 -- Toán, Sinh học, Khoa học xã hội",
            "B08 -- Toán, Sinh học, Tiếng Anh",
            "C01 -- Văn, Toán, Vật lí",
            "C02 -- Văn, Toán, Hóa học",
            "C03 -- Văn, Toán, Lịch sử",
            "C04 -- Văn, Toán, Địa lí",
            "C05 -- Văn, Vật lí, Hóa học",
            "C06 -- Văn, Vật lí, Sinh học",
            "C07 -- Văn, Vật lí, Lịch sử",
            "C08 -- Văn, Hóa học, Sinh",
            "C09 -- Văn, Vật lí, Địa lí",
            "C10 -- Văn, Hóa học, Lịch sử",
            "C12 -- Văn, Sinh học, Lịch sử",
            "C13 -- Văn, Sinh học, Địa",
            "C14 -- Văn, Toán, Giáo dục công dân",
            "C15 -- Văn, Toán, Khoa học xã hội",
            "C16 -- Văn, Vật lí, Giáo dục công dân",
            "C17 -- Văn, Hóa học, Giáo dục công dân",
            "C19 -- Văn, Lịch sử, Giáo dục công dân",
            "C20 -- Văn, Địa lí, Giáo dục công dân",
            "D02 -- Văn, Toán, tiếng Nga",
            "D03 -- Văn, Toán, tiếng Pháp",
            "D04 -- Văn, Toán, tiếng Trung",
            "D05 -- Văn, Toán, Tiếng Đức",
            "D06 -- Văn, Toán, Tiếng Nhật",
            "D08 -- Toán, Sinh học, Tiếng Anh",
            "D09 -- Toán, Lịch sử, Tiếng Anh",
            "D10 -- Toán, Địa lí, Tiếng Anh",
            "D11 -- Văn, Vật lí, Tiếng Anh",
            "D12 -- Văn, Hóa học, Tiếng Anh",
            "D13 -- Văn, Sinh học, Tiếng Anh",
            "D14 -- Văn, Lịch sử, Tiếng Anh",
            "D15 -- Văn, Địa lí, Tiếng Anh",
            "D16 -- Toán, Địa lí, Tiếng Đức",
            "D17 -- Toán, Địa lí, Tiếng Nga",
            "D18 -- Toán, Địa lí, Tiếng Nhật",
            "D19 -- Toán, Địa lí, Tiếng Pháp",
            "D20 -- Toán, Địa lí, Tiếng Trung",
            "D21 -- Toán, Hóa học, Tiếng Đức",
            "D22 -- Toán, Hóa học, Tiếng Nga",
            "D23 -- Toán, Hóa học, Tiếng Nhật",
            "D24 -- Toán, Hóa học, Tiếng Pháp",
            "D25 -- Toán, Hóa học, Tiếng Trung",
            "D26 -- Toán, Vật lí, Tiếng Đức",
            "D27 -- Toán, Vật lí, Tiếng Nga",
            "D28 -- Toán, Vật lí, Tiếng Nhật",
            "D29 -- Toán, Vật lí, Tiếng Pháp",
            "D30 -- Toán, Vật lí, Tiếng Trung",
            "D31 -- Toán, Sinh học, Tiếng Đức",
            "D32 -- Toán, Sinh học, Tiếng Nga",
            "D33 -- Toán, Sinh học, Tiếng Nhật",
            "D34 -- Toán, Sinh học, Tiếng Pháp",
            "D35 -- Toán, Sinh học, Tiếng Trung",
            "D41 -- Văn, Địa lí, Tiếng Đức",
            "D42 -- Văn, Địa lí, Tiếng Nga",
            "D43 -- Văn, Địa lí, Tiếng Nhật",
            "D44 -- Văn, Địa lí, Tiếng Pháp",
            "D45 -- Văn, Địa lí, Tiếng Trung",
            "D52 -- Văn, Vật lí, Tiếng Nga",
            "D54 -- Văn, Vật lí, Tiếng Pháp",
            "D55 -- Văn, Vật lí, Tiếng Trung",
            "D61 -- Văn, Lịch sử, Tiếng Đức",
            "D62 -- Văn, Lịch sử, Tiếng Nga",
            "D63 -- Văn, Lịch sử, Tiếng Nhật",
            "D64 -- Văn, Lịch sử, Tiếng Pháp",
            "D65 -- Văn, Lịch sử, Tiếng Trung",
            "D66 -- Văn, Giáo dục công dân, Tiếng Anh",
            "D68 -- Văn, Giáo dục công dân, Tiếng Nga",
            "D69 -- Văn, Giáo dục công dân, Tiếng Nhật",
            "D70 -- Văn, Giáo dục công dân, Tiếng Pháp",
            "D72 -- Văn, Khoa học tự nhiên, Tiếng Anh",
            "D73 -- Văn, Khoa học tự nhiên, Tiếng Đức",
            "D74 -- Văn, Khoa học tự nhiên, Tiếng Nga",
            "D75 -- Văn, Khoa học tự nhiên, Tiếng Nhật",
            "D76 -- Văn, Khoa học tự nhiên, Tiếng Pháp",
            "D77 -- Văn, Khoa học tự nhiên, Tiếng Trung",
            "D78 -- Văn, Khoa học xã hội, Tiếng Anh",
            "D79 -- Văn, Khoa học xã hội, Tiếng Đức",
            "D80 -- Văn, Khoa học xã hội, Tiếng Nga",
            "D81 -- Văn, Khoa học xã hội, Tiếng Nhật",
            "D82 -- Văn, Khoa học xã hội, Tiếng Pháp",
            "D83 -- Văn, Khoa học xã hội, Tiếng Trung",
            "D84 -- Toán, Giáo dục công dân, Tiếng Anh",
            "D85 -- Toán, Giáo dục công dân, Tiếng Đức",
            "D86 -- Toán, Giáo dục công dân, Tiếng Nga",
            "D87 -- Toán, Giáo dục công dân, Tiếng Pháp",
            "D88 -- Toán, Giáo dục công dân, Tiếng Nhật",
            "D90 -- Toán, Khoa học tự nhiên, Tiếng Anh",
            "D91 -- Toán, Khoa học tự nhiên, Tiếng Pháp",
            "D92 -- Toán, Khoa học tự nhiên, Tiếng Đức",
            "D93 -- Toán, Khoa học tự nhiên, Tiếng Nga",
            "D94 -- Toán, Khoa học tự nhiên, Tiếng Nhật",
            "D95 -- Toán, Khoa học tự nhiên, Tiếng Trung",
            "D96 -- Toán, Khoa học xã hội, Anh",
            "D97 -- Toán, Khoa học xã hội, Tiếng Pháp",
            "D98 -- Toán, Khoa học xã hội, Tiếng Đức",
            "D99 -- Toán, Khoa học xã hội, Tiếng Nga",
            "H00 -- Văn, Năng khiếu vẽ 1, Năng khiếu vẽ 2",
            "H01 -- Toán, Văn, Vẽ",
            "H02 -- Toán, Vẽ Hình họa mỹ thuật, Vẽ trang trí màu",
            "H03 -- Toán, Khoa học tự nhiên, Vẽ Năng khiếu",
            "H04 -- Toán, Tiếng Anh, Vẽ Năng khiếu",
            "H05 -- Văn, Khoa học xã hội, Vẽ Năng khiếu",
            "H06 -- Văn, Tiếng Anh,Vẽ mỹ thuật",
            "H07 -- Toán, Hình họa, Trang trí",
            "H08 -- Văn, Lịch sử, Vẽ mỹ thuật",
            "V00 -- Toán, Vật lí, Vẽ Hình họa mỹ thuật",
            "V01 -- Toán, Văn, Vẽ Hình họa mỹ thuật",
            "V02 -- VẼ MT, Toán, Tiếng Anh",
            "V03 -- VẼ MT, Toán, Hóa",
            "V05 -- Văn, Vật lí, Vẽ mỹ thuật",
            "V06 -- Toán, Địa lí, Vẽ mỹ thuật",
            "V07 -- Toán, tiếng Đức, Vẽ mỹ thuật",
            "V08 -- Toán, tiếng Nga, Vẽ mỹ thuật",
            "V09 -- Toán, tiếng Nhật, Vẽ mỹ thuật",
            "V10 -- Toán, tiếng Pháp, Vẽ mỹ thuật",
            "V11 -- Toán, tiếng Trung, Vẽ mỹ thuật",
            "M00 -- Văn, Toán, Đọc diễn cảm, Hát",
            "M01 -- Văn, Lịch sử, Năng khiếu",
            "M02 -- Toán, Năng khiếu 1, Năng khiếu 2",
            "M03 -- Văn, Năng khiếu 1, Năng khiếu 2",
            "M04 -- Toán, KHTN, Năng khiếu",
            "M05 -- Văn, Sử, Năng khiếu",
            "M06 -- Văn, Toán, Năng khiếu",
            "M07 -- Văn, Địa, Đọc diễn cảm + Hát",
            "M08 -- Văn, NK 1, NK 2",
            "M09 -- Toán, Kể chuyện – Đọc diễn cảm, Hát",
            "M10 -- Toán, Tiếng Anh, Năng khiếu mầm non",
            "M11 -- Văn, Anh, Năng khiếu GDMN",
            "M13 -- Toán, Sinh, Năng khiếu",
            "M14 -- Toán, Địa, Đọc diễn cảm – Hát",
            "N00 -- Văn, Năng khiếu Âm nhạc 1, Năng khiếu Âm nhạc 2",
            "N01 -- Văn, Hát xướng âm, Biểu diễn nghệ thuật",
            "N02 -- Văn, Ký xướng âm, Hát hoặc biểu diễn nhạc cụ",
            "N03 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N04 -- Văn, Năng khiếu thuyết trình, Năng khiếu",
            "N05 -- Văn, Xây dựng kịch bản sự kiện, Năng khiếu",
            "N06 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N07 -- Văn, Ghi âm- xướng âm, chuyên môn",
            "N08 -- Văn, Hòa thanh, Phát triển chủ đề và phổ thơ",
            "N09 -- Văn, Hòa thanh, Chỉ huy tại chỗ",
            "R00 -- Văn, Sử, Năng khiếu nghệ thuật",
            "R01 -- Văn, Địa, Năng khiếu nghệ thuật",
            "R02 -- Văn, Toán, Năng khiếu nghệ thuật",
            "R03 -- Văn, Anh, Năng khiếu nghệ thuật",
            "R04 -- Văn, Biểu diễn nghệ thuật, Năng khiếu văn hóa nghệ thuật",
            "R05 -- Văn, Anh, Năng khiếu báo chí",
            "R06 -- Văn, KHTN, Năng khiếu báo chí",
            "R07 -- Văn, Toán, Năng khiếu ảnh báo chí",
            "R08 -- Văn, Anh, Năng khiếu ảnh báo chí",
            "R09 -- Văn, KHTN, Năng khiếu ảnh báo chí",
            "R11 -- Văn, Toán, Năng khiếu quay phim truyền hình",
            "R12 -- Văn, Anh, Năng khiếu quay phim truyền hình",
            "R13 -- Văn, KHTN, Năng khiếu quay phim truyền hình",
            "R15 -- Văn, Toán, Năng khiếu báo chí",
            "R16 -- Văn, KHXH, Năng khiếu báo chí",
            "R17 -- Văn, KHXH, Năng khiếu ảnh báo chí",
            "R18 -- Văn, KHXH, Năng khiếu quay phim truyền hình",
            " R19 --Văn, Điểm quy đổi chứng chỉ Tiếng Anhh, Năng khiếu báo chí",
            " R20 --Văn, Điểm quy đổi chứng chỉ Tiếng Anh, Năng khiếu ảnh báo chí",
            "R21 -- Văn, Điểm quy đổi chứng chỉ Tiếng Anh, NK quay phim truyền hình",
            "R22 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R23 -- Văn, Sử, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R24 -- Văn, Toán, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R25 -- Văn, KHTN, Điểm quy đổi chứng chỉ Tiếng Anh",
            "R26 -- Văn, KHXH, Điểm quy đổi chứng chỉ Tiếng Anh",
            "T00 -- Toán, Sinh, Năng khiếu Thể dục thể thao",
            "T01 -- Toán, Văn, Năng khiếu TDTT",
            "T02 -- Văn, Sinh, Năng khiếu TDTT",
            "T03 -- Văn, Địa, Năng khiếu TDTT",
            "T04 -- Toán, Lý, Năng khiếu TDTT",
            "T05 -- Văn, GDCD, Năng khiếu TDTT",
            "T07 -- Văn, Địa, Năng khiếu TDTT",
            "T08 -- Toán, GDCD, Năng khiếu TDTT",
            "S00 -- Văn, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            "S01 -- Toán, Năng khiếu SKĐA 1, Năng khiếu SKĐA 2",
            ""});
            this.cbNameUni.Location = new System.Drawing.Point(398, 150);
            this.cbNameUni.MaxDropDownItems = 10;
            this.cbNameUni.Name = "cbNameUni";
            this.cbNameUni.Size = new System.Drawing.Size(423, 29);
            this.cbNameUni.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Courier New", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::RoadToUni.Properties.Resources.icoTuVan__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 74);
            this.label1.TabIndex = 9;
            this.label1.Text = "    TƯ VẤN CHỌN TRƯỜNG ĐẠI HỌC \r\n    THUỘC ĐHQG-TPHCM 2021-2022\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fFindSchool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::RoadToUni.Properties.Resources.bkgr_Researching;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNameUni);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbComb);
            this.Controls.Add(this.cbCombination);
            this.Controls.Add(this.lbNameUni);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.txbGrade);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFindSchool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbNameUni;
        private System.Windows.Forms.ComboBox cbCombination;
        private System.Windows.Forms.Label lbComb;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.ComboBox cbNameUni;
        private System.Windows.Forms.Label label1;
    }
}

