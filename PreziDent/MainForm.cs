﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreziDent
{
    public partial class MainForm : MaterialForm
    {
        private ClinicContext db;
        private user User;
        public void SetUser(user User)
        {
            this.User = User; 
        }
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            /* materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 14);
             materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 14);*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRoom9Orders_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.Date.ToLongDateString();
            switch (User.role_id)
            {
                case 1:
                    MainTabControl.TabPages.Remove(Room);
                    
                break;
                case 2:
                    MainTabControl.TabPages.Remove(Rooms);
                    db = new ClinicContext();
                    db.shedules.Load();
                    SheduleView.DataSource = db.shedules.Select(s => new SheduleShow
                    {
                        start_time = s.start_time,
                        end_time = s.end_time
                    }).ToList();
                break;
            }
        }

        private void SheduleView_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewColumn header in SheduleView.Columns)
            {
                if(header.HeaderText == "start_time")
                    header.HeaderText = "Начало";
                
                if (header.HeaderText == "end_time")
                    header.HeaderText = "Конец";
            }
        }
    }
}
