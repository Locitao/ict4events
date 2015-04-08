using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace MED_TEK
{
    public partial class scan : Form
    {

        //Fields
        string prefix = "rhbj_";
        public string patientID;
        Connect verbinding;

        public scan(Connect _verbinding)
        {
            InitializeComponent();
            verbinding = _verbinding;
            StartPosition = FormStartPosition.CenterScreen; 
            panel1.BackColor = Color.FromArgb(255, 255, 255);

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbScan.Enabled = true;
            tbScan.Text = "";
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tbScan.Text.Length == 10)
            {
                
                timer1.Stop();
                tbScan.Enabled = false;
                // Alle tekens zijn Ingevoerd, methode aanroepen om de nodige gegevens erbij op te zoeken
                string pascode = tbScan.Text;
                string sql = "SELECT patientID, pasfoto FROM " + prefix + "patient WHERE pascode = '" + pascode + "'";
                var data = Connect.ExecuteQuery(sql);
                for (int i = 0; i < data.Count; ++i)
                {
                    Dictionary<string, object> row = data[i];
                    verbinding.patientID = Convert.ToInt32(row["patientID"]);
                    verbinding.pasfoto = (string)row["pasfoto"];
                    Console.WriteLine("patientID en pasfoto opgehaald: " + verbinding.patientID + " " + verbinding.pasfoto);
                }

                string locatie = verbinding.login_locatie;

                if (locatie == "doctor")
                {
                    Doctor doctor = new Doctor(verbinding);
                    this.Hide();
                    doctor.Show();
                }
                else if (locatie == "ambulance")
                {
                    Ambulance ambulance = new Ambulance(verbinding);
                    this.Hide();
                    ambulance.Show();
                }
                else if (locatie == "apotheek")
                {
                    Apotheek apotheek = new Apotheek(verbinding);
                    this.Hide();
                    apotheek.Show();
                }
                


            }

        }

        private void scan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verbinding.login_locatie = null;

            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}
