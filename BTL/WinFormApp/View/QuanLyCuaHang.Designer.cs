﻿namespace WinFormApp
{
    partial class QuanLyCuaHang
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
            this.gpMain = new WinFormApp.CustomControl.GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new WinFormApp.CustomControl.GradientPanel();
            this.gradientPanel3 = new WinFormApp.CustomControl.GradientPanel();
            this.btnLogout = new WinFormApp.RJButton();
            this.lbCapBac = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnThongKe = new WinFormApp.RJButton();
            this.btnXuatHang = new WinFormApp.RJButton();
            this.btnNhanVien = new WinFormApp.RJButton();
            this.btnKhachHang = new WinFormApp.RJButton();
            this.btnNhapHang = new WinFormApp.RJButton();
            this.btnKhoXe = new WinFormApp.RJButton();
            this.btnKhoPhuTung = new WinFormApp.RJButton();
            this.btnChiNhanh = new WinFormApp.RJButton();
            this.btnHome = new WinFormApp.RJButton();
            this.rjCircularPictureBox1 = new WinFormApp.RJCircularPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpMain
            // 
            this.gpMain.Angle = 0F;
            this.gpMain.BackColor = System.Drawing.Color.White;
            this.gpMain.BottomColor = System.Drawing.Color.Empty;
            this.gpMain.Controls.Add(this.dataGridView1);
            this.gpMain.Controls.Add(this.panel1);
            this.gpMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.gpMain.Location = new System.Drawing.Point(283, 0);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(1153, 803);
            this.gpMain.TabIndex = 1;
            this.gpMain.TopColor = System.Drawing.Color.Empty;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 415);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 363);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Controls.Add(this.btnThongKe);
            this.gradientPanel1.Controls.Add(this.btnXuatHang);
            this.gradientPanel1.Controls.Add(this.btnNhanVien);
            this.gradientPanel1.Controls.Add(this.btnKhachHang);
            this.gradientPanel1.Controls.Add(this.btnNhapHang);
            this.gradientPanel1.Controls.Add(this.btnKhoXe);
            this.gradientPanel1.Controls.Add(this.btnKhoPhuTung);
            this.gradientPanel1.Controls.Add(this.btnChiNhanh);
            this.gradientPanel1.Controls.Add(this.btnHome);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(291, 803);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 0F;
            this.gradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel3.Controls.Add(this.btnLogout);
            this.gradientPanel3.Controls.Add(this.lbCapBac);
            this.gradientPanel3.Controls.Add(this.lbUserName);
            this.gradientPanel3.Controls.Add(this.rjCircularPictureBox1);
            this.gradientPanel3.Location = new System.Drawing.Point(12, 674);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(262, 117);
            this.gradientPanel3.TabIndex = 30;
            this.gradientPanel3.TopColor = System.Drawing.Color.Empty;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(3, 83);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(254, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.rjButton10_Click);
            // 
            // lbCapBac
            // 
            this.lbCapBac.AutoSize = true;
            this.lbCapBac.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapBac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCapBac.Location = new System.Drawing.Point(86, 50);
            this.lbCapBac.Name = "lbCapBac";
            this.lbCapBac.Size = new System.Drawing.Size(65, 19);
            this.lbCapBac.TabIndex = 2;
            this.lbCapBac.Text = "Cấp Bậc";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbUserName.Location = new System.Drawing.Point(86, 16);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(98, 22);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.BorderSize = 0;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(12, 519);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(263, 40);
            this.btnThongKe.TabIndex = 25;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextColor = System.Drawing.Color.White;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatHang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnXuatHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnXuatHang.BorderRadius = 0;
            this.btnXuatHang.BorderSize = 0;
            this.btnXuatHang.FlatAppearance.BorderSize = 0;
            this.btnXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHang.ForeColor = System.Drawing.Color.White;
            this.btnXuatHang.Location = new System.Drawing.Point(12, 473);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(263, 40);
            this.btnXuatHang.TabIndex = 26;
            this.btnXuatHang.Text = "Xuất Hàng";
            this.btnXuatHang.TextColor = System.Drawing.Color.White;
            this.btnXuatHang.UseVisualStyleBackColor = false;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 0;
            this.btnNhanVien.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(12, 244);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(263, 40);
            this.btnNhanVien.TabIndex = 29;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextColor = System.Drawing.Color.White;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderRadius = 0;
            this.btnKhachHang.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(14, 290);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(263, 40);
            this.btnKhachHang.TabIndex = 28;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextColor = System.Drawing.Color.White;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.BorderColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.BorderRadius = 0;
            this.btnNhapHang.BorderSize = 0;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(14, 427);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(263, 40);
            this.btnNhapHang.TabIndex = 24;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.TextColor = System.Drawing.Color.White;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnKhoXe
            // 
            this.btnKhoXe.BackColor = System.Drawing.Color.Transparent;
            this.btnKhoXe.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKhoXe.BorderColor = System.Drawing.Color.Transparent;
            this.btnKhoXe.BorderRadius = 0;
            this.btnKhoXe.BorderSize = 0;
            this.btnKhoXe.FlatAppearance.BorderSize = 0;
            this.btnKhoXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoXe.ForeColor = System.Drawing.Color.White;
            this.btnKhoXe.Location = new System.Drawing.Point(12, 335);
            this.btnKhoXe.Name = "btnKhoXe";
            this.btnKhoXe.Size = new System.Drawing.Size(263, 40);
            this.btnKhoXe.TabIndex = 27;
            this.btnKhoXe.Text = "Kho Xe";
            this.btnKhoXe.TextColor = System.Drawing.Color.White;
            this.btnKhoXe.UseVisualStyleBackColor = false;
            this.btnKhoXe.Click += new System.EventHandler(this.btnKhoXe_Click);
            // 
            // btnKhoPhuTung
            // 
            this.btnKhoPhuTung.BackColor = System.Drawing.Color.Transparent;
            this.btnKhoPhuTung.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKhoPhuTung.BorderColor = System.Drawing.Color.Transparent;
            this.btnKhoPhuTung.BorderRadius = 0;
            this.btnKhoPhuTung.BorderSize = 0;
            this.btnKhoPhuTung.FlatAppearance.BorderSize = 0;
            this.btnKhoPhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoPhuTung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoPhuTung.ForeColor = System.Drawing.Color.White;
            this.btnKhoPhuTung.Location = new System.Drawing.Point(14, 381);
            this.btnKhoPhuTung.Name = "btnKhoPhuTung";
            this.btnKhoPhuTung.Size = new System.Drawing.Size(263, 40);
            this.btnKhoPhuTung.TabIndex = 23;
            this.btnKhoPhuTung.Text = "Kho Phụ Tùng";
            this.btnKhoPhuTung.TextColor = System.Drawing.Color.White;
            this.btnKhoPhuTung.UseVisualStyleBackColor = false;
            this.btnKhoPhuTung.Click += new System.EventHandler(this.btnKhoPhuTung_Click);
            // 
            // btnChiNhanh
            // 
            this.btnChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.btnChiNhanh.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChiNhanh.BorderColor = System.Drawing.Color.Transparent;
            this.btnChiNhanh.BorderRadius = 0;
            this.btnChiNhanh.BorderSize = 0;
            this.btnChiNhanh.FlatAppearance.BorderSize = 0;
            this.btnChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnChiNhanh.Location = new System.Drawing.Point(12, 198);
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.Size = new System.Drawing.Size(263, 40);
            this.btnChiNhanh.TabIndex = 22;
            this.btnChiNhanh.Text = "Chi Nhánh";
            this.btnChiNhanh.TextColor = System.Drawing.Color.White;
            this.btnChiNhanh.UseVisualStyleBackColor = false;
            this.btnChiNhanh.Click += new System.EventHandler(this.btnChiNhanh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 15;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(12, 152);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(263, 40);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::WinFormApp.Properties.Resources.avatar;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(12, 4);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(68, 68);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormApp.Properties.Resources.icon_honda;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // QuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 803);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuanLyCuaHang";
            this.Text = "Quản lý cửa hàng Honda Phát Tiến";
            this.gpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.GradientPanel gradientPanel1;
        private CustomControl.GradientPanel gpMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton btnHome;
        private RJButton btnChiNhanh;
        private RJButton btnThongKe;
        private RJButton btnXuatHang;
        private RJButton btnNhanVien;
        private RJButton btnKhachHang;
        private RJButton btnNhapHang;
        private RJButton btnKhoXe;
        private RJButton btnKhoPhuTung;
        private CustomControl.GradientPanel gradientPanel3;
        private RJCircularPictureBox rjCircularPictureBox1;
        private RJButton btnLogout;
        private System.Windows.Forms.Label lbCapBac;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}