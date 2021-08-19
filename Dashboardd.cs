using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// library to curve tge bordes of form
using System.Runtime.InteropServices;

namespace StudentHousing
{
    public partial class Dashboardd : Form
    {       
        //Dll ext for round the borders of form we import the dll file

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );

        public Dashboardd()
        {
            InitializeComponent();
            //initialize the variables for roud the borders dashboard form
            //With #region, we can organize code into blocks

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //intialze the panel propersties for navbar
            panNav.Height = btn_dashboard.Height;
            panNav.Top = btn_dashboard.Top;
            panNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.PnlFormLoaderD.Controls.Clear();
            DashBoardd2 db = new DashBoardd2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            db.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(db);
            db.Show();
        }
        private void Dashboardd_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            //This code is for navbaar

            panNav.Height = btn_dashboard.Height;
            panNav.Top = btn_dashboard.Top;
            panNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            //Load Form on Main Dashboard Panel
            lbltitle.Text = "Dashboard";
            this.PnlFormLoaderD.Controls.Clear();
            //Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent. public: virtual property
            DashBoardd2 db = new DashBoardd2() { Dock = DockStyle.Fill,TopLevel = false, TopMost= true };
            db.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(db);
            db.Show();
            


        }
        private void btn_addroom_Click(object sender, EventArgs e)
        {
            panNav.Height = btn_addroom.Height;
            panNav.Top = btn_addroom.Top;
            panNav.Left = btn_addroom.Left;
           btn_addroom.BackColor = Color.FromArgb(46, 51, 73);

            //Load Form on Main Dashboard Panel
            lbltitle.Text = "Add New Room";
            this.PnlFormLoaderD.Controls.Clear();
            AddNewRoom anr = new AddNewRoom() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            anr.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(anr);
            anr.Show();



        }

        private void btn_newStudent_Click(object sender, EventArgs e)
        {
            panNav.Height = btn_newStudent.Height;
            panNav.Top = btn_newStudent.Top;
            panNav.Left = btn_newStudent.Left;
            btn_newStudent.BackColor = Color.FromArgb(46, 51, 73);

            //Load Form on Main Dashboard Panel
            lbltitle.Text = "New Student";
            this.PnlFormLoaderD.Controls.Clear();
             NewStudent ns = new NewStudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ns.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(ns);
            ns.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panNav.Height = button3.Height;
            panNav.Top =button3.Top;
            panNav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Update And Delete";
            this.PnlFormLoaderD.Controls.Clear();
           UpdateDeleteStudents udp = new UpdateDeleteStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            udp.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(udp);
            udp.Show();

        }

        private void btn_studentFee_Click(object sender, EventArgs e)
        {
            panNav.Height = btn_studentFee.Height;
            panNav.Top =btn_studentFee.Top;
            panNav.Left = btn_studentFee.Left;
            btn_studentFee.BackColor = Color.FromArgb(46, 51, 73);

            //Load Form on Main Dashboard Panel
            lbltitle.Text = "Student Fee";
            this.PnlFormLoaderD.Controls.Clear();
            StudentFees sf = new StudentFees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sf.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(sf);
            sf.Show();


        }

        private void btn_allStu_Click(object sender, EventArgs e)
        {
            panNav.Height = btn_allStu.Height;
            panNav.Top =btn_allStu.Top;
            panNav.Left =btn_allStu.Left;
            btn_allStu.BackColor = Color.FromArgb(46, 51, 73);

           // Load Form on Main Dashboard Panel
            lbltitle.Text = "Reports";
            this.PnlFormLoaderD.Controls.Clear();
            Reports rp = new Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            rp.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(rp);
            rp.Show();
        }

       


        //Buttons Events Leave to leve nav bar on button after clicking on it 
        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_addroom_Leave(object sender, EventArgs e)
        {
           btn_addroom.BackColor=Color.FromArgb(24, 30, 54);
        }

        private void btn_newStudent_Leave(object sender, EventArgs e)
        {
            btn_newStudent.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_studentFee_Leave(object sender, EventArgs e)
        {
            btn_studentFee.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_allStu_Leave(object sender, EventArgs e)
        {
          btn_allStu.BackColor = Color.FromArgb(24, 30, 54);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panNav.Height = button2.Height;
            panNav.Top = button2.Top;
            panNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            //Logout
            this.Hide();
            //Back to login Page
            Form1 login = new Form1();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.PnlFormLoaderD.Controls.Clear();
            UpdateDeleteStudents udp = new UpdateDeleteStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            udp.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(udp);
            udp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            

            this.PnlFormLoaderD.Controls.Clear();
           export ex = new export() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ex.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoaderD.Controls.Add(ex);
            ex.Show();

        }
    }
}
