using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using Newtonsoft.Json.Converters;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace boostpanel
{
    partial class Form1
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

            username = "Test User";
            alerts.Show($"Hello {username}", alerts.AlertType.success);
			
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox31 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label40 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox30 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuThinButton215 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton214 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton213 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label39 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox29 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label38 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox28 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox27 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox26 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label33 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox25 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label32 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox24 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label31 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox23 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label30 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox22 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label29 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox21 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label28 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox20 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label27 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox19 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label26 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox18 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox17 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label24 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox16 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label23 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox15 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox14 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox13 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox12 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox11 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox10 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label17 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox9 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox8 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox7 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuThinButton210 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton211 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton212 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox6 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox5 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox4 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuThinButton29 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Rank2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.stats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelChart.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1620, 80);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuTop_Paint);
            this.MenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = global::boostpanel.Properties.Resources.Minimizar;
            this.Minimizar.Location = new System.Drawing.Point(1531, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = global::boostpanel.Properties.Resources.Salir;
            this.Salir.Location = new System.Drawing.Point(1567, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "VERTIGO BOOST PANEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = global::boostpanel.Properties.Resources.icon;
            this.MenuSidebar.Location = new System.Drawing.Point(18, 14);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(39, 42);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 840);
            this.SidebarWrapper.TabIndex = 1;
            this.SidebarWrapper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButton14);
            this.Sidebar.Controls.Add(this.bunifuFlatButton13);
            this.Sidebar.Controls.Add(this.bunifuFlatButton12);
            this.Sidebar.Controls.Add(this.bunifuFlatButton11);
            this.Sidebar.Controls.Add(this.bunifuFlatButton10);
            this.Sidebar.Controls.Add(this.bunifuFlatButton9);
            this.Sidebar.Controls.Add(this.bunifuFlatButton8);
            this.Sidebar.Controls.Add(this.bunifuFlatButton7);
            this.Sidebar.Controls.Add(this.bunifuFlatButton6);
            this.Sidebar.Controls.Add(this.bunifuFlatButton5);
            this.Sidebar.Controls.Add(this.bunifuFlatButton4);
            this.Sidebar.Controls.Add(this.bunifuFlatButton3);
            this.Sidebar.Controls.Add(this.bunifuFlatButton2);
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.RoyalBlue;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Aqua;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(301, 840);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            this.Sidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseDown);
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "      SHOW CALIBRATIONS";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton14;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 50D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(7, 725);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton14.TabIndex = 21;
            this.bunifuFlatButton14.Text = "      SHOW CALIBRATIONS";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "      AUTO INVITE: OFF";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton13;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 50D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(7, 574);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton13.TabIndex = 20;
            this.bunifuFlatButton13.Text = "      AUTO INVITE: OFF";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "      FETCH INFO";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton12;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 50D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(7, 674);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton12.TabIndex = 19;
            this.bunifuFlatButton12.Text = "      FETCH INFO";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "      GAMES COUNT";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton11;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 50D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(7, 624);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton11.TabIndex = 18;
            this.bunifuFlatButton11.Text = "      GAMES COUNT";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "      DISCONNECTS: OFF";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton10;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 50D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(7, 524);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(291, 45);
            this.bunifuFlatButton10.TabIndex = 17;
            this.bunifuFlatButton10.Text = "      DISCONNECTS: OFF";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton10.MouseUp += new System.EventHandler(this.bunifuFlatButton10_MouseUp);
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "      MEM REDUCT: OFF";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton9;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 50D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(7, 474);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton9.TabIndex = 16;
            this.bunifuFlatButton9.Text = "      MEM REDUCT: OFF";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "      LEADER: #1";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton8;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 50D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(7, 424);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton8.TabIndex = 15;
            this.bunifuFlatButton8.Text = "      LEADER: #1";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "      SCORE: 0:0";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton7;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 50D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(7, 374);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton7.TabIndex = 14;
            this.bunifuFlatButton7.Text = "      SCORE: 0:0";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "      TIME: 0:00";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton6;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 50D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(7, 324);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(291, 45);
            this.bunifuFlatButton6.TabIndex = 13;
            this.bunifuFlatButton6.Text = "      TIME: 0:00";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      AUTO-START: DISABLED";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton5;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 50D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(7, 274);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton5.TabIndex = 12;
            this.bunifuFlatButton5.Text = "      AUTO-START: DISABLED";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "      AUTO-ACCEPT: DISABLED";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton4;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(7, 224);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(291, 45);
            this.bunifuFlatButton4.TabIndex = 11;
            this.bunifuFlatButton4.Text = "      AUTO-ACCEPT: DISABLED";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "      SETTINGS";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton3;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(7, 174);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton3.TabIndex = 10;
            this.bunifuFlatButton3.Text = "      SETTINGS";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      DATABASE";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton2;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(7, 124);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(292, 45);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Text = "      DATABASE";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      MANAGER";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::boostpanel.Properties.Resources.bunifuFlatButton1;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(7, 75);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(294, 45);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "      MANAGER";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(283, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = username;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::boostpanel.Properties.Resources.iconmonstr_user_5_240;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1320, 840);
            this.Wrapper.TabIndex = 2;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelChart.Controls.Add(this.panel1);
            this.PanelChart.Controls.Add(this.label3);
            this.AnimacionSidebarBack.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.PanelChart, BunifuAnimatorNS.DecorationType.None);
            this.PanelChart.Location = new System.Drawing.Point(0, 0);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1424, 850);
            this.PanelChart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.comboBox9);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.bunifuCustomTextbox31);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.bunifuCustomTextbox30);
            this.panel1.Controls.Add(this.bunifuThinButton215);
            this.panel1.Controls.Add(this.bunifuThinButton214);
            this.panel1.Controls.Add(this.bunifuThinButton213);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.bunifuCustomTextbox29);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.bunifuCustomTextbox28);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.bunifuCustomTextbox27);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.bunifuCustomTextbox26);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.bunifuCustomTextbox25);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.bunifuCustomTextbox24);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.bunifuCustomTextbox23);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.bunifuCustomTextbox22);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.bunifuCustomTextbox21);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.bunifuCustomTextbox20);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.bunifuCustomTextbox19);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.bunifuCustomTextbox18);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.bunifuCustomTextbox17);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.bunifuCustomTextbox16);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.bunifuCustomTextbox15);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.bunifuCustomTextbox14);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.bunifuCustomTextbox13);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.bunifuCustomTextbox12);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.bunifuCustomTextbox11);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.bunifuCustomTextbox10);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.bunifuCustomTextbox9);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.bunifuCustomTextbox8);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bunifuCustomTextbox7);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.bunifuThinButton210);
            this.panel1.Controls.Add(this.bunifuThinButton211);
            this.panel1.Controls.Add(this.bunifuThinButton212);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bunifuCustomTextbox6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bunifuCustomTextbox5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bunifuCustomTextbox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bunifuCustomTextbox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuCustomTextbox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuCustomTextbox1);
            this.panel1.Controls.Add(this.bunifuThinButton29);
            this.panel1.Controls.Add(this.bunifuThinButton28);
            this.panel1.Controls.Add(this.bunifuThinButton27);
            this.panel1.Controls.Add(this.bunifuThinButton26);
            this.panel1.Controls.Add(this.bunifuThinButton25);
            this.panel1.Controls.Add(this.bunifuThinButton24);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(34, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 674);
            this.panel1.TabIndex = 17;
            // 
            // comboBox9
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox9, BunifuAnimatorNS.DecorationType.None);
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "None",
            "Groups",
            "Ranks 5x5",
            "Ranks 2x2"});
            this.comboBox9.Location = new System.Drawing.Point(595, 24);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(350, 28);
            this.comboBox9.TabIndex = 103;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox8, BunifuAnimatorNS.DecorationType.None);
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Default",
            "Green",
            "Red",
            "Orange",
            "Yellow",
            "Purple",
            "Black"});
            this.comboBox8.Location = new System.Drawing.Point(1046, 460);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(350, 28);
            this.comboBox8.TabIndex = 102;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label43, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label43, BunifuAnimatorNS.DecorationType.None);
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(1197, 439);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(45, 18);
            this.label43.TabIndex = 101;
            this.label43.Text = "Color";
            // 
            // comboBox7
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox7, BunifuAnimatorNS.DecorationType.None);
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "16-0",
            "15-15",
            "16-0(v2)",
            "15-15(v2)",
            "Calibration",
            "16-0(v3)"});
            this.comboBox7.Location = new System.Drawing.Point(595, 283);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(350, 28);
            this.comboBox7.TabIndex = 100;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label42, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label42, BunifuAnimatorNS.DecorationType.None);
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(736, 263);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 18);
            this.label42.TabIndex = 99;
            this.label42.Text = "Type";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label41, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label41, BunifuAnimatorNS.DecorationType.None);
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(707, 207);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(110, 18);
            this.label41.TabIndex = 98;
            this.label41.Text = "Disconnect MS";
            // 
            // bunifuCustomTextbox31
            // 
            this.bunifuCustomTextbox31.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox31, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox31, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox31.Location = new System.Drawing.Point(595, 231);
            this.bunifuCustomTextbox31.Name = "bunifuCustomTextbox31";
            this.bunifuCustomTextbox31.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox31.TabIndex = 97;
            this.bunifuCustomTextbox31.Text = "20000";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label40, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label40, BunifuAnimatorNS.DecorationType.None);
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(709, 155);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 18);
            this.label40.TabIndex = 96;
            this.label40.Text = "Reconnect MS";
            // 
            // bunifuCustomTextbox30
            // 
            this.bunifuCustomTextbox30.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox30, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox30, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox30.Location = new System.Drawing.Point(595, 179);
            this.bunifuCustomTextbox30.Name = "bunifuCustomTextbox30";
            this.bunifuCustomTextbox30.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox30.TabIndex = 95;
            this.bunifuCustomTextbox30.Text = "16000";
            // 
            // bunifuThinButton215
            // 
            this.bunifuThinButton215.ActiveBorderThickness = 1;
            this.bunifuThinButton215.ActiveCornerRadius = 20;
            this.bunifuThinButton215.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton215.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton215.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton215.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton215.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton215.BackgroundImage")));
            this.bunifuThinButton215.ButtonText = "Configure selected leaders";
            this.bunifuThinButton215.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton215, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton215, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton215.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton215.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton215.IdleBorderThickness = 1;
            this.bunifuThinButton215.IdleCornerRadius = 20;
            this.bunifuThinButton215.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton215.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton215.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton215.Location = new System.Drawing.Point(595, 483);
            this.bunifuThinButton215.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton215.Name = "bunifuThinButton215";
            this.bunifuThinButton215.Size = new System.Drawing.Size(350, 43);
            this.bunifuThinButton215.TabIndex = 94;
            this.bunifuThinButton215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton215.Click += new System.EventHandler(this.bunifuThinButton215_Click);
            // 
            // bunifuThinButton214
            // 
            this.bunifuThinButton214.ActiveBorderThickness = 1;
            this.bunifuThinButton214.ActiveCornerRadius = 20;
            this.bunifuThinButton214.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton214.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton214.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton214.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton214.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton214.BackgroundImage")));
            this.bunifuThinButton214.ButtonText = "Reset selected leaders";
            this.bunifuThinButton214.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton214, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton214, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton214.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton214.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton214.IdleBorderThickness = 1;
            this.bunifuThinButton214.IdleCornerRadius = 20;
            this.bunifuThinButton214.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton214.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton214.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton214.Location = new System.Drawing.Point(595, 533);
            this.bunifuThinButton214.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton214.Name = "bunifuThinButton214";
            this.bunifuThinButton214.Size = new System.Drawing.Size(350, 43);
            this.bunifuThinButton214.TabIndex = 93;
            this.bunifuThinButton214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton214.Click += new System.EventHandler(this.bunifuThinButton214_Click);
            // 
            // bunifuThinButton213
            // 
            this.bunifuThinButton213.ActiveBorderThickness = 1;
            this.bunifuThinButton213.ActiveCornerRadius = 20;
            this.bunifuThinButton213.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton213.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton213.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton213.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton213.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton213.BackgroundImage")));
            this.bunifuThinButton213.ButtonText = "Save current settings";
            this.bunifuThinButton213.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton213, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton213, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton213.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton213.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton213.IdleBorderThickness = 1;
            this.bunifuThinButton213.IdleCornerRadius = 20;
            this.bunifuThinButton213.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton213.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton213.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton213.Location = new System.Drawing.Point(595, 586);
            this.bunifuThinButton213.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton213.Name = "bunifuThinButton213";
            this.bunifuThinButton213.Size = new System.Drawing.Size(350, 43);
            this.bunifuThinButton213.TabIndex = 92;
            this.bunifuThinButton213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton213.Click += new System.EventHandler(this.bunifuThinButton213_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label39, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label39, BunifuAnimatorNS.DecorationType.None);
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(723, 103);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 18);
            this.label39.TabIndex = 91;
            this.label39.Text = "Parameters";
            // 
            // bunifuCustomTextbox29
            // 
            this.bunifuCustomTextbox29.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox29, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox29, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox29.Location = new System.Drawing.Point(595, 127);
            this.bunifuCustomTextbox29.Name = "bunifuCustomTextbox29";
            this.bunifuCustomTextbox29.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox29.TabIndex = 90;
            this.bunifuCustomTextbox29.Text = "-Steamos -nofriendsui -nochatui -single_core -window -w 640 -h 480 -novid -noshad" +
    "er -nofbo -nodcaudio -nomsaa -16bpp -nosound -high";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label38, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label38, BunifuAnimatorNS.DecorationType.None);
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(695, 54);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(146, 18);
            this.label38.TabIndex = 89;
            this.label38.Text = "Leaders SteamIDs64";
            // 
            // bunifuCustomTextbox28
            // 
            this.bunifuCustomTextbox28.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox28, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox28, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox28.Location = new System.Drawing.Point(595, 75);
            this.bunifuCustomTextbox28.Name = "bunifuCustomTextbox28";
            this.bunifuCustomTextbox28.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox28.TabIndex = 88;
            this.bunifuCustomTextbox28.Text = "test1,test1,test1,test1,test1";
            // 
            // comboBox6
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox6, BunifuAnimatorNS.DecorationType.None);
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.comboBox6.Location = new System.Drawing.Point(595, 24);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(350, 28);
            this.comboBox6.TabIndex = 87;
            this.comboBox6.Visible = false;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label37, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label37, BunifuAnimatorNS.DecorationType.None);
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(718, 4);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 18);
            this.label37.TabIndex = 86;
            this.label37.Text = "     Sorting";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label36, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label36, BunifuAnimatorNS.DecorationType.None);
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(459, 520);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 18);
            this.label36.TabIndex = 85;
            this.label36.Text = "Color";
            // 
            // bunifuCustomTextbox27
            // 
            this.bunifuCustomTextbox27.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox27, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox27, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox27.Enabled = false;
            this.bunifuCustomTextbox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox27.Location = new System.Drawing.Point(378, 542);
            this.bunifuCustomTextbox27.Name = "bunifuCustomTextbox27";
            this.bunifuCustomTextbox27.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox27.TabIndex = 84;
            this.bunifuCustomTextbox27.Text = "-11751600";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label35, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label35, BunifuAnimatorNS.DecorationType.None);
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(458, 572);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 18);
            this.label35.TabIndex = 83;
            this.label35.Text = "Mode";
            // 
            // comboBox5
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox5, BunifuAnimatorNS.DecorationType.None);
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "FreezeTime"});
            this.comboBox5.Location = new System.Drawing.Point(378, 593);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(211, 28);
            this.comboBox5.TabIndex = 82;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label34, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label34, BunifuAnimatorNS.DecorationType.None);
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(433, 468);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(108, 18);
            this.label34.TabIndex = 81;
            this.label34.Text = "Reconnect #10";
            // 
            // bunifuCustomTextbox26
            // 
            this.bunifuCustomTextbox26.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox26, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox26, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox26.Enabled = false;
            this.bunifuCustomTextbox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox26.Location = new System.Drawing.Point(378, 491);
            this.bunifuCustomTextbox26.Name = "bunifuCustomTextbox26";
            this.bunifuCustomTextbox26.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox26.TabIndex = 80;
            this.bunifuCustomTextbox26.Text = "0,0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label33, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label33, BunifuAnimatorNS.DecorationType.None);
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(432, 418);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 18);
            this.label33.TabIndex = 79;
            this.label33.Text = "Reconnect #9";
            // 
            // bunifuCustomTextbox25
            // 
            this.bunifuCustomTextbox25.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox25, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox25, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox25.Enabled = false;
            this.bunifuCustomTextbox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox25.Location = new System.Drawing.Point(378, 439);
            this.bunifuCustomTextbox25.Name = "bunifuCustomTextbox25";
            this.bunifuCustomTextbox25.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox25.TabIndex = 78;
            this.bunifuCustomTextbox25.Text = "0,0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label32, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label32, BunifuAnimatorNS.DecorationType.None);
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(432, 364);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 18);
            this.label32.TabIndex = 77;
            this.label32.Text = "Reconnect #8";
            // 
            // bunifuCustomTextbox24
            // 
            this.bunifuCustomTextbox24.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox24, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox24.Enabled = false;
            this.bunifuCustomTextbox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox24.Location = new System.Drawing.Point(378, 387);
            this.bunifuCustomTextbox24.Name = "bunifuCustomTextbox24";
            this.bunifuCustomTextbox24.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox24.TabIndex = 76;
            this.bunifuCustomTextbox24.Text = "0,0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label31, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label31, BunifuAnimatorNS.DecorationType.None);
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(432, 312);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 18);
            this.label31.TabIndex = 75;
            this.label31.Text = "Reconnect #7";
            // 
            // bunifuCustomTextbox23
            // 
            this.bunifuCustomTextbox23.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox23, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox23.Enabled = false;
            this.bunifuCustomTextbox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox23.Location = new System.Drawing.Point(378, 335);
            this.bunifuCustomTextbox23.Name = "bunifuCustomTextbox23";
            this.bunifuCustomTextbox23.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox23.TabIndex = 74;
            this.bunifuCustomTextbox23.Text = "0,0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label30, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label30, BunifuAnimatorNS.DecorationType.None);
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(432, 260);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(100, 18);
            this.label30.TabIndex = 73;
            this.label30.Text = "Reconnect #6";
            // 
            // bunifuCustomTextbox22
            // 
            this.bunifuCustomTextbox22.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox22, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox22.Enabled = false;
            this.bunifuCustomTextbox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox22.Location = new System.Drawing.Point(378, 283);
            this.bunifuCustomTextbox22.Name = "bunifuCustomTextbox22";
            this.bunifuCustomTextbox22.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox22.TabIndex = 72;
            this.bunifuCustomTextbox22.Text = "0,0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label29, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label29, BunifuAnimatorNS.DecorationType.None);
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(432, 208);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 18);
            this.label29.TabIndex = 71;
            this.label29.Text = "Reconnect #5";
            // 
            // bunifuCustomTextbox21
            // 
            this.bunifuCustomTextbox21.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox21, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox21.Enabled = false;
            this.bunifuCustomTextbox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox21.Location = new System.Drawing.Point(378, 231);
            this.bunifuCustomTextbox21.Name = "bunifuCustomTextbox21";
            this.bunifuCustomTextbox21.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox21.TabIndex = 70;
            this.bunifuCustomTextbox21.Text = "0,0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label28, BunifuAnimatorNS.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(432, 156);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 18);
            this.label28.TabIndex = 69;
            this.label28.Text = "Reconnect #4";
            // 
            // bunifuCustomTextbox20
            // 
            this.bunifuCustomTextbox20.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox20, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox20, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox20.Enabled = false;
            this.bunifuCustomTextbox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox20.Location = new System.Drawing.Point(378, 179);
            this.bunifuCustomTextbox20.Name = "bunifuCustomTextbox20";
            this.bunifuCustomTextbox20.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox20.TabIndex = 68;
            this.bunifuCustomTextbox20.Text = "0,0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label27, BunifuAnimatorNS.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(432, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 18);
            this.label27.TabIndex = 67;
            this.label27.Text = "Reconnect #3";
            // 
            // bunifuCustomTextbox19
            // 
            this.bunifuCustomTextbox19.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox19, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox19, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox19.Enabled = false;
            this.bunifuCustomTextbox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox19.Location = new System.Drawing.Point(378, 127);
            this.bunifuCustomTextbox19.Name = "bunifuCustomTextbox19";
            this.bunifuCustomTextbox19.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox19.TabIndex = 66;
            this.bunifuCustomTextbox19.Text = "0,0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(432, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 18);
            this.label26.TabIndex = 65;
            this.label26.Text = "Reconnect #2";
            // 
            // bunifuCustomTextbox18
            // 
            this.bunifuCustomTextbox18.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox18, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox18, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox18.Location = new System.Drawing.Point(378, 75);
            this.bunifuCustomTextbox18.Name = "bunifuCustomTextbox18";
            this.bunifuCustomTextbox18.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox18.TabIndex = 64;
            this.bunifuCustomTextbox18.Text = "0,0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(156, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 18);
            this.label25.TabIndex = 63;
            this.label25.Text = "Steam path";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // bunifuCustomTextbox17
            // 
            this.bunifuCustomTextbox17.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox17, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox17, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox17.Location = new System.Drawing.Point(22, 25);
            this.bunifuCustomTextbox17.Name = "bunifuCustomTextbox17";
            this.bunifuCustomTextbox17.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox17.TabIndex = 62;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(433, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 18);
            this.label24.TabIndex = 61;
            this.label24.Text = "Reconnect #1";
            // 
            // bunifuCustomTextbox16
            // 
            this.bunifuCustomTextbox16.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox16, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox16, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox16.Location = new System.Drawing.Point(378, 25);
            this.bunifuCustomTextbox16.Name = "bunifuCustomTextbox16";
            this.bunifuCustomTextbox16.Size = new System.Drawing.Size(211, 26);
            this.bunifuCustomTextbox16.TabIndex = 60;
            this.bunifuCustomTextbox16.Text = "0,0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(131, 468);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 18);
            this.label23.TabIndex = 59;
            this.label23.Text = "Play button color #2";
            // 
            // bunifuCustomTextbox15
            // 
            this.bunifuCustomTextbox15.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox15, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox15, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox15.Enabled = false;
            this.bunifuCustomTextbox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox15.Location = new System.Drawing.Point(22, 491);
            this.bunifuCustomTextbox15.Name = "bunifuCustomTextbox15";
            this.bunifuCustomTextbox15.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox15.TabIndex = 58;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(131, 418);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(139, 18);
            this.label22.TabIndex = 57;
            this.label22.Text = "Play button color #1";
            // 
            // bunifuCustomTextbox14
            // 
            this.bunifuCustomTextbox14.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox14, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox14.Enabled = false;
            this.bunifuCustomTextbox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox14.Location = new System.Drawing.Point(22, 439);
            this.bunifuCustomTextbox14.Name = "bunifuCustomTextbox14";
            this.bunifuCustomTextbox14.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox14.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(151, 364);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 18);
            this.label21.TabIndex = 55;
            this.label21.Text = "Play button #2";
            // 
            // bunifuCustomTextbox13
            // 
            this.bunifuCustomTextbox13.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox13, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox13.Enabled = false;
            this.bunifuCustomTextbox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox13.Location = new System.Drawing.Point(22, 387);
            this.bunifuCustomTextbox13.Name = "bunifuCustomTextbox13";
            this.bunifuCustomTextbox13.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox13.TabIndex = 54;
            this.bunifuCustomTextbox13.Click += new System.EventHandler(this.bunifuCustomTextbox13_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(151, 312);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 18);
            this.label20.TabIndex = 53;
            this.label20.Text = "Play button #1";
            // 
            // bunifuCustomTextbox12
            // 
            this.bunifuCustomTextbox12.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox12, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox12.Location = new System.Drawing.Point(22, 335);
            this.bunifuCustomTextbox12.Name = "bunifuCustomTextbox12";
            this.bunifuCustomTextbox12.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox12.TabIndex = 52;
            this.bunifuCustomTextbox12.Click += new System.EventHandler(this.bunifuCustomTextbox12_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(136, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 18);
            this.label19.TabIndex = 51;
            this.label19.Text = "Auto-Start color #2";
            // 
            // bunifuCustomTextbox11
            // 
            this.bunifuCustomTextbox11.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox11, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox11.Enabled = false;
            this.bunifuCustomTextbox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox11.Location = new System.Drawing.Point(22, 283);
            this.bunifuCustomTextbox11.Name = "bunifuCustomTextbox11";
            this.bunifuCustomTextbox11.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox11.TabIndex = 50;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(136, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 18);
            this.label18.TabIndex = 49;
            this.label18.Text = "Auto-Start color #1";
            // 
            // bunifuCustomTextbox10
            // 
            this.bunifuCustomTextbox10.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox10, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox10.Enabled = false;
            this.bunifuCustomTextbox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox10.Location = new System.Drawing.Point(22, 231);
            this.bunifuCustomTextbox10.Name = "bunifuCustomTextbox10";
            this.bunifuCustomTextbox10.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox10.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(152, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 18);
            this.label17.TabIndex = 47;
            this.label17.Text = "Auto-Start #2";
            // 
            // bunifuCustomTextbox9
            // 
            this.bunifuCustomTextbox9.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox9.Enabled = false;
            this.bunifuCustomTextbox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox9.Location = new System.Drawing.Point(22, 179);
            this.bunifuCustomTextbox9.Name = "bunifuCustomTextbox9";
            this.bunifuCustomTextbox9.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox9.TabIndex = 46;
            this.bunifuCustomTextbox9.Click += new System.EventHandler(this.bunifuCustomTextbox9_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(152, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 18);
            this.label16.TabIndex = 45;
            this.label16.Text = "Auto-Start #1";
            // 
            // bunifuCustomTextbox8
            // 
            this.bunifuCustomTextbox8.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox8.Location = new System.Drawing.Point(22, 127);
            this.bunifuCustomTextbox8.Name = "bunifuCustomTextbox8";
            this.bunifuCustomTextbox8.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox8.TabIndex = 44;
            this.bunifuCustomTextbox8.Click += new System.EventHandler(this.bunifuCustomTextbox8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(161, 572);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 18);
            this.label15.TabIndex = 43;
            this.label15.Text = "Leader #2";
            // 
            // comboBox4
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox4, BunifuAnimatorNS.DecorationType.None);
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(22, 593);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(350, 28);
            this.comboBox4.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(161, 520);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 41;
            this.label14.Text = "Leader #1";
            // 
            // comboBox1
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 541);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 28);
            this.comboBox1.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(156, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "CSGO path";
            // 
            // bunifuCustomTextbox7
            // 
            this.bunifuCustomTextbox7.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox7.Location = new System.Drawing.Point(22, 75);
            this.bunifuCustomTextbox7.Name = "bunifuCustomTextbox7";
            this.bunifuCustomTextbox7.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox7.TabIndex = 37;
            // 
            // comboBox3
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox3, BunifuAnimatorNS.DecorationType.None);
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Unranked",
            "Silver 1",
            "Silver 2",
            "Silver 3",
            "Silver 4",
            "Silver 5",
            "Silver 6",
            "Gold Nova 1",
            "Gold Nova 2",
            "Gold Nova 3",
            "Gold Nova 4",
            "Master Guardian 1",
            "Master Guardian 2",
            "Master Guardian 3",
            "Distinguished Master Guardian",
            "Legendary Eagle",
            "Legendary Eagle Master",
            "Supreme Master First Class",
            "Global Elite"});
            this.comboBox3.Location = new System.Drawing.Point(1046, 406);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(350, 28);
            this.comboBox3.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1181, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "RANK 2x2";
            // 
            // comboBox2
            // 
            this.AnimacionSidebarBack.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Unranked",
            "Silver 1",
            "Silver 2",
            "Silver 3",
            "Silver 4",
            "Silver 5",
            "Silver 6",
            "Gold Nova 1",
            "Gold Nova 2",
            "Gold Nova 3",
            "Gold Nova 4",
            "Master Guardian 1",
            "Master Guardian 2",
            "Master Guardian 3",
            "Distinguished Master Guardian",
            "Legendary Eagle",
            "Legendary Eagle Master",
            "Supreme Master First Class",
            "Global Elite"});
            this.comboBox2.Location = new System.Drawing.Point(1046, 354);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(350, 28);
            this.comboBox2.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1181, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "RANK 5x5";
            // 
            // bunifuThinButton210
            // 
            this.bunifuThinButton210.ActiveBorderThickness = 1;
            this.bunifuThinButton210.ActiveCornerRadius = 20;
            this.bunifuThinButton210.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton210.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton210.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton210.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton210.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton210.BackgroundImage")));
            this.bunifuThinButton210.ButtonText = "Delete account";
            this.bunifuThinButton210.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton210, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton210, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton210.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton210.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton210.IdleBorderThickness = 1;
            this.bunifuThinButton210.IdleCornerRadius = 20;
            this.bunifuThinButton210.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton210.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton210.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton210.Location = new System.Drawing.Point(1056, 612);
            this.bunifuThinButton210.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton210.Name = "bunifuThinButton210";
            this.bunifuThinButton210.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton210.TabIndex = 32;
            this.bunifuThinButton210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton210.Click += new System.EventHandler(this.bunifuThinButton210_Click);
            // 
            // bunifuThinButton211
            // 
            this.bunifuThinButton211.ActiveBorderThickness = 1;
            this.bunifuThinButton211.ActiveCornerRadius = 20;
            this.bunifuThinButton211.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton211.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton211.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton211.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton211.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton211.BackgroundImage")));
            this.bunifuThinButton211.ButtonText = "Configure account";
            this.bunifuThinButton211.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton211, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton211, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton211.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton211.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton211.IdleBorderThickness = 1;
            this.bunifuThinButton211.IdleCornerRadius = 20;
            this.bunifuThinButton211.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton211.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton211.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton211.Location = new System.Drawing.Point(1056, 559);
            this.bunifuThinButton211.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton211.Name = "bunifuThinButton211";
            this.bunifuThinButton211.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton211.TabIndex = 31;
            this.bunifuThinButton211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton211.Click += new System.EventHandler(this.bunifuThinButton211_Click);
            // 
            // bunifuThinButton212
            // 
            this.bunifuThinButton212.ActiveBorderThickness = 1;
            this.bunifuThinButton212.ActiveCornerRadius = 20;
            this.bunifuThinButton212.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton212.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton212.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton212.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton212.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton212.BackgroundImage")));
            this.bunifuThinButton212.ButtonText = "Save current account\'s settings";
            this.bunifuThinButton212.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton212, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton212, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton212.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton212.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton212.IdleBorderThickness = 1;
            this.bunifuThinButton212.IdleCornerRadius = 20;
            this.bunifuThinButton212.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton212.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton212.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton212.Location = new System.Drawing.Point(1056, 506);
            this.bunifuThinButton212.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton212.Name = "bunifuThinButton212";
            this.bunifuThinButton212.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton212.TabIndex = 30;
            this.bunifuThinButton212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton212.Click += new System.EventHandler(this.bunifuThinButton212_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1134, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "ACCOUNT\'S ACCEPT Y";
            // 
            // bunifuCustomTextbox6
            // 
            this.bunifuCustomTextbox6.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox6.Enabled = false;
            this.bunifuCustomTextbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox6.Location = new System.Drawing.Point(1046, 304);
            this.bunifuCustomTextbox6.Name = "bunifuCustomTextbox6";
            this.bunifuCustomTextbox6.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox6.TabIndex = 25;
            this.bunifuCustomTextbox6.Text = "0";
            this.bunifuCustomTextbox6.Click += new System.EventHandler(this.bunifuCustomTextbox6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1134, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "ACCOUNT\'S ACCEPT X";
            // 
            // bunifuCustomTextbox5
            // 
            this.bunifuCustomTextbox5.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox5.Enabled = false;
            this.bunifuCustomTextbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox5.Location = new System.Drawing.Point(1046, 254);
            this.bunifuCustomTextbox5.Name = "bunifuCustomTextbox5";
            this.bunifuCustomTextbox5.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox5.TabIndex = 23;
            this.bunifuCustomTextbox5.Text = "0";
            this.bunifuCustomTextbox5.Click += new System.EventHandler(this.bunifuCustomTextbox5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1122, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "ACCOUNT\'S PARAMETERS";
            // 
            // bunifuCustomTextbox4
            // 
            this.bunifuCustomTextbox4.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox4.Location = new System.Drawing.Point(1046, 204);
            this.bunifuCustomTextbox4.Name = "bunifuCustomTextbox4";
            this.bunifuCustomTextbox4.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox4.TabIndex = 21;
            this.bunifuCustomTextbox4.Text = "-x 0 -y 0 -window -w 640 -h 480 -novid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1111, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "ACCOUNT\'S DISCONNECTS DATA\r\n";
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(1046, 154);
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1134, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "ACCOUNT\'S PASSWORD";
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(1046, 104);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.PasswordChar = '•';
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1152, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "ACCOUNT\'S LOGIN";
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(1046, 54);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(350, 26);
            this.bunifuCustomTextbox1.TabIndex = 10;
            // 
            // bunifuThinButton29
            // 
            this.bunifuThinButton29.ActiveBorderThickness = 1;
            this.bunifuThinButton29.ActiveCornerRadius = 20;
            this.bunifuThinButton29.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton29.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton29.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton29.BackgroundImage")));
            this.bunifuThinButton29.ButtonText = "Open account\'s userdata path";
            this.bunifuThinButton29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton29, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton29, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton29.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton29.IdleBorderThickness = 1;
            this.bunifuThinButton29.IdleCornerRadius = 20;
            this.bunifuThinButton29.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton29.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton29.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton29.Location = new System.Drawing.Point(1394, 404);
            this.bunifuThinButton29.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton29.Name = "bunifuThinButton29";
            this.bunifuThinButton29.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton29.TabIndex = 9;
            this.bunifuThinButton29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton29.Click += new System.EventHandler(this.bunifuThinButton29_Click);
            // 
            // bunifuThinButton28
            // 
            this.bunifuThinButton28.ActiveBorderThickness = 1;
            this.bunifuThinButton28.ActiveCornerRadius = 20;
            this.bunifuThinButton28.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton28.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton28.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton28.BackgroundImage")));
            this.bunifuThinButton28.ButtonText = "Open account\'s path";
            this.bunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton28, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton28, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton28.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton28.IdleBorderThickness = 1;
            this.bunifuThinButton28.IdleCornerRadius = 20;
            this.bunifuThinButton28.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton28.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton28.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton28.Location = new System.Drawing.Point(1394, 351);
            this.bunifuThinButton28.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton28.Name = "bunifuThinButton28";
            this.bunifuThinButton28.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton28.TabIndex = 8;
            this.bunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton28.Click += new System.EventHandler(this.bunifuThinButton28_Click);
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "Close all accounts";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton27, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton27, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton27.Location = new System.Drawing.Point(1394, 616);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton27.TabIndex = 7;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "Close account";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton26, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton26, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton26.Location = new System.Drawing.Point(1394, 563);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton26.TabIndex = 6;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Open Steam profile";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton25, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton25, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton25.Location = new System.Drawing.Point(1394, 510);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton25.TabIndex = 5;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Open Steam client";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton24, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton24.Location = new System.Drawing.Point(1394, 457);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton24.TabIndex = 4;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Restart account";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton23.Location = new System.Drawing.Point(1394, 298);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Close Steam and CSGO";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton22.Location = new System.Drawing.Point(1394, 245);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Purple;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Start account";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Indigo;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkOrchid;
            this.bunifuThinButton21.Location = new System.Drawing.Point(1394, 192);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(331, 43);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 35;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Rank1,
            this.Rank2,
            this.stats});
            this.AnimacionSidebar.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.bunifuCustomDataGrid1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Indigo;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(405, 460);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(635, 636);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            this.bunifuCustomDataGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellDoubleClick);
            this.bunifuCustomDataGrid1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellMouseEnter);
            this.bunifuCustomDataGrid1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellMouseLeave);
            this.bunifuCustomDataGrid1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bunifuCustomDataGrid1_CellMouseMove);
            this.bunifuCustomDataGrid1.MouseHover += new System.EventHandler(this.bunifuCustomDataGrid1_MouseHover);
            this.bunifuCustomDataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomDataGrid1_MouseUp);
            // 
            // Login
            // 
            this.Login.FillWeight = 150F;
            this.Login.Frozen = true;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Login.Width = 250;
            // 
            // Rank1
            // 
            this.Rank1.Frozen = true;
            this.Rank1.HeaderText = "Rank 5x5";
            this.Rank1.Name = "Rank1";
            this.Rank1.ReadOnly = true;
            this.Rank1.Width = 150;
            // 
            // Rank2
            // 
            this.Rank2.Frozen = true;
            this.Rank2.HeaderText = "Rank 2x2";
            this.Rank2.Name = "Rank2";
            this.Rank2.ReadOnly = true;
            this.Rank2.Width = 150;
            // 
            // stats
            // 
            this.stats.Frozen = true;
            this.stats.HeaderText = "Lobby             ";
            this.stats.Name = "stats";
            this.stats.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "ACCOUNTS MANAGER";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation3;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation4;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this.PanelChart;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5555;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERTIGO BOOST PANEL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.PanelChart.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

		}

		private Panel MenuTop;

		private PictureBox Minimizar;

		private PictureBox Salir;

		private Label label1;

		private PictureBox MenuSidebar;

		private Panel SidebarWrapper;

		private Panel Wrapper;

		private BunifuGradientPanel Sidebar;

		private BunifuFlatButton bunifuFlatButton7;

		private BunifuFlatButton bunifuFlatButton6;

		private BunifuFlatButton bunifuFlatButton5;

		private BunifuFlatButton bunifuFlatButton4;

		private BunifuFlatButton bunifuFlatButton3;

		private BunifuFlatButton bunifuFlatButton2;

		private BunifuFlatButton bunifuFlatButton1;

		private BunifuSeparator LineaSidebar;

		private Label label2;

		private PictureBox pictureBox1;

		private BunifuElipse CurvaSidebar;

		private BunifuTransition AnimacionSidebar;

		private BunifuTransition AnimacionSidebarBack;

		private Panel PanelChart;

		private BunifuElipse RadioPanelChart;

		private Label label3;

		private BunifuDragControl MoverDashboard;

		private Panel panel1;

		private BunifuCustomDataGrid bunifuCustomDataGrid1;

		private BunifuThinButton2 bunifuThinButton21;

		private BunifuThinButton2 bunifuThinButton27;

		private BunifuThinButton2 bunifuThinButton26;

		private BunifuThinButton2 bunifuThinButton25;

		private BunifuThinButton2 bunifuThinButton24;

		private BunifuThinButton2 bunifuThinButton23;

		private BunifuThinButton2 bunifuThinButton22;

		private BunifuThinButton2 bunifuThinButton29;

		private BunifuThinButton2 bunifuThinButton28;

		private BunifuCustomTextbox bunifuCustomTextbox1;

		private Label label5;

		private Label label6;

		private BunifuCustomTextbox bunifuCustomTextbox2;

		private Label label10;

		private BunifuCustomTextbox bunifuCustomTextbox6;

		private Label label9;

		private BunifuCustomTextbox bunifuCustomTextbox5;

		private Label label8;

		private BunifuCustomTextbox bunifuCustomTextbox4;

		private Label label7;

		private BunifuCustomTextbox bunifuCustomTextbox3;

		private BunifuThinButton2 bunifuThinButton210;

		private BunifuThinButton2 bunifuThinButton211;

		private BunifuThinButton2 bunifuThinButton212;

		private ComboBox comboBox2;

		private Label label12;

		private ComboBox comboBox3;

		private Label label13;

		private Label label23;

		private BunifuCustomTextbox bunifuCustomTextbox15;

		private Label label22;

		private BunifuCustomTextbox bunifuCustomTextbox14;

		private Label label21;

		private BunifuCustomTextbox bunifuCustomTextbox13;

		private Label label20;

		private BunifuCustomTextbox bunifuCustomTextbox12;

		private Label label19;

		private BunifuCustomTextbox bunifuCustomTextbox11;

		private Label label18;

		private BunifuCustomTextbox bunifuCustomTextbox10;

		private Label label17;

		private BunifuCustomTextbox bunifuCustomTextbox9;

		private Label label16;

		private BunifuCustomTextbox bunifuCustomTextbox8;

		private Label label15;

		private ComboBox comboBox4;

		private Label label14;

		private ComboBox comboBox1;

		private Label label11;

		private BunifuCustomTextbox bunifuCustomTextbox7;

		private Label label24;

		private BunifuCustomTextbox bunifuCustomTextbox16;

		private Label label25;

		private BunifuCustomTextbox bunifuCustomTextbox17;

		private Label label34;

		private BunifuCustomTextbox bunifuCustomTextbox26;

		private Label label33;

		private BunifuCustomTextbox bunifuCustomTextbox25;

		private Label label32;

		private BunifuCustomTextbox bunifuCustomTextbox24;

		private Label label31;

		private BunifuCustomTextbox bunifuCustomTextbox23;

		private Label label30;

		private BunifuCustomTextbox bunifuCustomTextbox22;

		private Label label29;

		private BunifuCustomTextbox bunifuCustomTextbox21;

		private Label label28;

		private BunifuCustomTextbox bunifuCustomTextbox20;

		private Label label27;

		private BunifuCustomTextbox bunifuCustomTextbox19;

		private Label label26;

		private BunifuCustomTextbox bunifuCustomTextbox18;

		private Label label36;

		private BunifuCustomTextbox bunifuCustomTextbox27;

		private Label label35;

		private ComboBox comboBox5;

		private Label label39;

		private BunifuCustomTextbox bunifuCustomTextbox29;

		private Label label38;

		private BunifuCustomTextbox bunifuCustomTextbox28;

		private ComboBox comboBox6;

		private Label label37;

		private BunifuThinButton2 bunifuThinButton215;

		private BunifuThinButton2 bunifuThinButton214;

		private BunifuThinButton2 bunifuThinButton213;

		private System.Windows.Forms.Timer timer1;

		private Label label41;

		private BunifuCustomTextbox bunifuCustomTextbox31;

		private Label label40;

		private BunifuCustomTextbox bunifuCustomTextbox30;

		private ComboBox comboBox7;

		private Label label42;

		private BunifuFlatButton bunifuFlatButton8;

		private BunifuFlatButton bunifuFlatButton9;

		private BunifuFlatButton bunifuFlatButton10;

		private ComboBox comboBox8;

		private Label label43;

		private BunifuFlatButton bunifuFlatButton11;

		private BunifuFlatButton bunifuFlatButton12;

		private BunifuFlatButton bunifuFlatButton13;

		private DataGridViewTextBoxColumn Login;

		private DataGridViewImageColumn Rank1;

		private DataGridViewImageColumn Rank2;

		private DataGridViewTextBoxColumn stats;

		private BunifuFlatButton bunifuFlatButton14;

		private System.Windows.Forms.Timer timer2;

		private System.Windows.Forms.Timer timer3;

		private ComboBox comboBox9;

		#endregion
	}
}