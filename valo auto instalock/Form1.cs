using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace valo_auto_instalock
{
    public partial class Form1 : Form 
    {

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]

        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        int mouseX;
        int mouseY;
        int PX, PY, LX, LY;
        int timerCount = 0;
        int profileCount = 0;
        bool language = false;

        SqlConnection conn = new SqlConnection(@"Data Source=IOSCAN;Initial Catalog=InstaLockDB;Integrated Security=True");

        enum mouseeventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }

        void leftclick(Point p)
        {
            mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
            mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
        }

        void showProfiles() 
        {
            profiles.Controls.Clear();

            conn.Open();

            SqlCommand cmd = new SqlCommand("select ProfileName from TBLINSTALOCKINFOS", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Panel p = new Panel();
                p.Width = 50;
                p.Height = 50;
                p.Dock = DockStyle.Top;
                profiles.Controls.Add(p);
                Button btn = new Button();
                btn.Text = dr[0].ToString();
                btn.Width = 50;
                btn.Height = 50;
                btn.Dock = DockStyle.Fill;
                p.Controls.Add(btn);
                btn.Click += btnSet_Click;
                btn.MouseHover += btn_MouseHover;
            }

            conn.Close();
        }

        private void btn_MouseHover(object sender, EventArgs e) { txtButtonName.Text = ((Button)sender).Text; }

        private void btnSet_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select PX,PY,LX,LY from TBLINSTALOCKINFOS where ProfileName = @p1", conn);
            cmd.Parameters.AddWithValue("@p1", ((Button)sender).Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) 
            {
                PX = int.Parse(dr[0].ToString());
                PY = int.Parse(dr[1].ToString());
                LX = int.Parse(dr[2].ToString());
                LY = int.Parse(dr[3].ToString());
                timer2.Start(); 
            }

            conn.Close();

        }

        void addNewProfile(string profil,string px,string py,string lx,string ly)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into TBLINSTALOCKINFOS (ProfileName,PX,PY,LX,LY) values (@p1,@p2,@p3,@p4,@p5)", conn);
                cmd.Parameters.AddWithValue("@p1", profil);
                cmd.Parameters.AddWithValue("@p2", int.Parse(px));
                cmd.Parameters.AddWithValue("@P3", int.Parse(py));
                cmd.Parameters.AddWithValue("@p4", int.Parse(lx));
                cmd.Parameters.AddWithValue("@p5", int.Parse(ly));
                cmd.ExecuteNonQuery();

                conn.Close();
            } 
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        void deleteProfile()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("delete from TBLINSTALOCKINFOS where ProfileName = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", txtButtonName.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                profiles.Controls.Clear();
                txtButtonName.Text = "";
                showProfiles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void isThereAny(string profileName)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select ProfileName from TBLINSTALOCKINFOS", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr[profileCount].ToString() == profileName) { profileCount++; break; }
                }

                conn.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }  
        }

        void translateToEnglish() 
        {
            addProfile.Text = "Add Profile";
            lblName.Text = "Profile Name :";
            lblPX.Text = "First coordinate X :";
            lblPY.Text = "First coordinate Y :";
            lblLX.Text = "Last coordinate X :";
            lblLY.Text = "Last coordinate Y :";
            btnSaveProfile.Text = "Save";
            btnChangeLanguage.Text = "Confirm";
            coorAndLang.Text = "Coor and Lang";
        }

        void translateToTurkish() 
        {
            addProfile.Text = "Profil Ekle";
            lblName.Text = "Profil adı :";
            lblPX.Text = "İlk X koordinatı :";
            lblPY.Text = "İlk Y koordinatı :";
            lblLX.Text = "Son X koordinatı :";
            lblLY.Text = "Son Y koordinatı :";
            btnSaveProfile.Text = "Kaydet";
            btnChangeLanguage.Text = "Onayla";
            coorAndLang.Text = "Koordinat ve Dil";
        }

        void clear()
        {
            txtProfileName.Text = "";
            txtPX.Text = "";
            txtPY.Text = "";
            txtLX.Text = "";
            txtLY.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            showProfiles();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mouseX = MousePosition.X - this.Left;
            mouseY = MousePosition.Y - this.Top;
            IX.Text = mouseX.ToString();
            IY.Text = mouseY.ToString();           
        }

        private void txtSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProfileName.Text != "" && txtPX.Text != "" && txtPY.Text != "" && txtLX.Text != "" && txtLY.Text != "")
                {
                    isThereAny(txtProfileName.Text);

                    if (profileCount==0)
                    {
                        addNewProfile(txtProfileName.Text, txtPX.Text, txtPY.Text, txtLX.Text, txtLY.Text);

                        showProfiles();

                        clear();

                        if (language == true) { MessageBox.Show("Profile saved !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else { MessageBox.Show("Profil kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else
                    {
                        if (language == true) { MessageBox.Show("A profile with this name already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); profileCount = 0; }
                        else { MessageBox.Show("Bu isime sahip bir profil zaten var !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); profileCount = 0; }
                    }
                }
                else 
                {
                    if (language == true) { MessageBox.Show("Nowhere musnt be empty !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else { MessageBox.Show("Hiçbir alan boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnMinimize_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void silToolStripMenuItem_Click(object sender, EventArgs e) { deleteProfile(); }

        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            if (cmbLanguage.Text == "Türkçe") { translateToTurkish(); language = false; cmbLanguage.SelectedItem = null; }
            else if (cmbLanguage.Text == "English") { translateToEnglish();  language = true;  cmbLanguage.SelectedItem = null; }
            else 
            { 
                if (language == false) { MessageBox.Show("Bir dil seçmen gerekiyor !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else { MessageBox.Show("First, you must be choose a language !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timerCount<40)
            {
                Cursor.Position = new Point(PX, PY);
                Thread.Sleep(25);
                leftclick(new Point(MousePosition.X, MousePosition.Y));
                Thread.Sleep(25);
                Cursor.Position = new Point(LX, LY);
                Thread.Sleep(25);
                leftclick(new Point(MousePosition.X, MousePosition.Y));
                Thread.Sleep(25);
                timerCount++;
            }
            else if (timerCount==40)
            {
                PX = 0;PY = 0;
                LX = 0;LY = 0;
                timerCount = 0;
                timer2.Stop();
            }      
        }
    }
}
