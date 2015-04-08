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
    public partial class Beheer_Update : Form
    {
        // Fields 
        Select select = new Select();
        Connect verbinding = new Connect();
        Update update = new Update();
        Miscellaneous overig = new Miscellaneous();

        // Deze variabele wordt gebruikt voor de controle of het oude wachtwoord van een gebruiker juist is ingevuld
        string userpassword;

        // Deze fields worden dmv verschillende event handlers ingevuld
        int ziekteID;
        int medicatieID;
        int afspraakID;

        public Beheer_Update()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Beheer_Update_Load(object sender, EventArgs e)
        {
            // Zorgen dat alle elementen van data worden voorzien, voor zover dat nodig is
            refresh();

            // Format van DTP aanpassen zodat er geen fouten onstaan met verwerking van SQL
            dtpDoB.Format = DateTimePickerFormat.Custom;
            dtpDoB.CustomFormat = "yyyy-MM-dd";
            dtpGebruikEind.Format = DateTimePickerFormat.Custom;
            dtpGebruikEind.CustomFormat = "yyyy-MM-dd";
            dtpGebruikStart.Format = DateTimePickerFormat.Custom;
            dtpGebruikStart.CustomFormat = "yyyy-MM-dd";
            dtpAfspraak.Format = DateTimePickerFormat.Custom;
            dtpAfspraak.CustomFormat = "yyyy-MM-dd";
            dtpTijd.Format = DateTimePickerFormat.Custom;
            dtpTijd.CustomFormat = "HH : mm";
            dtpTijd.Text = "00 : 00";



        }

        public void refresh()
        {
            // ComboBoxes leegmaken zodat gegevens niet 2 of meer keer worden weergegeven
            cbLocatie.Items.Clear();
            cbSelectMedicatie.Items.Clear();
            cbSelectMedicijn.Items.Clear();
            cbSelectUser.Items.Clear();
            cbSelectZiekte.Items.Clear();
            cbZiekte.Items.Clear();

            // alle textboxes van patientgegevens uitschakelen, totdat patient gegevens worden opgehaald.
            tbVoornamen.Enabled = false;
            tbAchternaam.Enabled = false;
            dtpDoB.Enabled = false;
            tbBsn.Enabled = false;
            tbBloedgroep.Enabled = false;
            tbPasfoto.Enabled = false;
            tbEmail.Enabled = false;
            tbMobiel.Enabled = false;
            tbTelefoon.Enabled = false;
            tbAdres.Enabled = false;
            tbGemeente.Enabled = false;
            tbProvincie.Enabled = false;
            tbPascode.Enabled = false;
            tbZiekte.Enabled = false;
            btnUpdateZiekte.Enabled = false;
            btnUpdatePatient.Enabled = false;
            tbMedicijnNaam.Enabled = false;
            tbGebruikMedicijn.Enabled = false;
            tbBijwerkingMedicijn.Enabled = false;
            btnUpdateMedicijn.Enabled = false;

            // Gebruiker aanpassen
            tbPwdNew.Enabled = false;
            tbPwdNewRepeat.Enabled = false;
            tbPwdOld.Enabled = false;
            btnUpdatePwd.Enabled = false;

            // Medicatie aanpassen
            cbSelectMedicatie.Enabled = false;
            btnSelectMedicatie2.Enabled = false;
            dtpGebruikEind.Enabled = false;
            dtpGebruikStart.Enabled = false;
            tbHoeveelheid.Enabled = false;
            btnUpdateMedicatie.Enabled = false;

            // form elementen van data voorzien.
            var ziekte = select.Select_Ziekte();
            var medicijn = select.Select_Medicijn();
            var user = select.Select_User_Name();

            // Ziekte van patient aanpassen
            cbSelectZiekte.Enabled = false;
            btnSelectZiekte2.Enabled = false;
            tbSymptomen.Enabled = false;
            btnUpdateZiektePatient.Enabled = false;

            // Afspraak van patient aanpassen
            cbAfspraak.Enabled = false;
            btnSelectAfspraak2.Enabled = false;
            cbLocatie.Enabled = false;
            dtpAfspraak.Enabled = false;
            dtpTijd.Enabled = false;
            cbActief.Enabled = false;

            for (int i = 0; i < 1; ++i)
            {
                for (int a = 0; a < ziekte.Count; ++a)
                {
                    Dictionary<string, object> row = ziekte[a];
                    cbZiekte.Items.Add("ID " + row["ziekteID"] + " - " + row["naam"] + ".");
                }
                for (int b = 0; b < medicijn.Count; ++b)
                {
                    Dictionary<string, object> row = medicijn[b];
                    cbSelectMedicijn.Items.Add("ID " + row["medicijnID"] + " - " + row["naam"] + ".");
                }
                for(int c = 0; c < user.Count; ++c)
                {
                    Dictionary<string, object> row = user[c];
                    cbSelectUser.Items.Add(row["username"]);
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string pascode = tbCode.Text;
            var data = select.Select_Patient_All(pascode);

            for (int i = 0; i < data.Count; ++i)
            {
                Dictionary<string, object> row = data[i];
                tbVoornamen.Text = row["voornamen"].ToString();
                tbAchternaam.Text = row["achternaam"].ToString();
                dtpDoB.Text = row["geboortedatum"].ToString();
                tbBsn.Text = row["bsn"].ToString();
                tbBloedgroep.Text = row["bloedgroep"].ToString();
                tbPasfoto.Text = row["pasfoto"].ToString();
                tbEmail.Text = row["email"].ToString();
                tbMobiel.Text = row["mobiel"].ToString();
                tbTelefoon.Text = row["telefoon"].ToString();
                tbAdres.Text = row["adres"].ToString();
                tbGemeente.Text = row["gemeente"].ToString();
                tbProvincie.Text = row["provincie"].ToString();
                tbPascode.Text = row["pascode"].ToString();

                verbinding.patientID = Convert.ToInt32(row["patientID"]);

                tbVoornamen.Enabled = true;
                tbAchternaam.Enabled = true;
                dtpDoB.Enabled = true;
                tbBsn.Enabled = true;
                tbBloedgroep.Enabled = true;
                tbPasfoto.Enabled = true;
                tbEmail.Enabled = true;
                tbMobiel.Enabled = true;
                tbTelefoon.Enabled = true;
                tbAdres.Enabled = true;
                tbGemeente.Enabled = true;
                tbProvincie.Enabled = true;
                tbPascode.Enabled = true;

                tbCode.Enabled = false;
                btnActivate.Enabled = false;
                btnUpdatePatient.Enabled = true;

            }

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            int error = 0;

            string voornamen = tbVoornamen.Text;
            string achternaam = tbAchternaam.Text;
            string DoB = dtpDoB.Text;
            string bsn = tbBsn.Text;
            string bloedgroep = tbBloedgroep.Text;
            string pasfoto = tbPasfoto.Text;
            string email = tbEmail.Text;
            string mobiel = tbMobiel.Text;
            string telefoon = tbTelefoon.Text;
            string adres = tbAdres.Text;
            string gemeente = tbGemeente.Text;
            string provincie = tbProvincie.Text;
            string pascode = tbPascode.Text;

            if (voornamen == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om de voornamen van de patient op te geven!");
            }
            if (achternaam == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om de achternaam van de patient op te gegeven!");
            }
            if (DoB == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht de geboortedatum van de patient op te geven!");
            }
            if (Convert.ToString(bsn) == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om het BSN nummer van de patient op te geven!");
            }
            if(bloedgroep == "" )
            {
                ++error;
                MessageBox.Show("Het is verplicht om de bloedgroep van de patient op te geven!");
            }
            if(pasfoto == "" )
            {
                ++error;
                MessageBox.Show("Het is verplicht om een link naar de pasfoto op te geven!");
            }
            if(email == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om een email adres van de patient op te geven!");
            }
            if (mobiel == "" || telefoon == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om een mobielnummer of telefoonnummer van de patient op te geven!");
            }
            if (adres == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om het adres van de patient op te geven!");
            }
            if(gemeente == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om de gemeente op te geven waar de patient in woont!");
            }
            if (provincie == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om de provincie op te geven waar de patient in woont!");
            }
            if (Convert.ToString(pascode) == "")
            {
                ++error;
                MessageBox.Show("Het is verplicht om de pascode van de patient op te geven!");
            }

            if (error == 0)
            {
                update.Update_Patient(verbinding.patientID, voornamen, achternaam, DoB, bsn, bloedgroep, pasfoto, email, telefoon, mobiel, adres, gemeente, provincie, pascode);
                MessageBox.Show("De patientgegevens zijn succesvol bijgewerkt!");

                // Gegevens zijn bijgewerkt, mogelijk maken om gegevens voor nieuwe patient op te zoeken
                tbCode.Enabled = true;
                tbCode.Text = "";
                btnActivate.Enabled = true;

                // Alle velden leegmaken
                tbVoornamen.Text = "";
                tbAchternaam.Text = "";
                dtpDoB.Text = Convert.ToString(DateTime.Now);
                tbBsn.Text = "";
                tbBloedgroep.Text = "";
                tbPasfoto.Text = "";
                tbEmail.Text = "";
                tbTelefoon.Text = "";
                tbMobiel.Text = "";
                tbAdres.Text = "";
                tbGemeente.Text = "";
                tbProvincie.Text = "";
                tbPascode.Text = "";

                // Gegevens van formulier verversen
                refresh();
            }
        }

        private void btnChangeZiekte_Click(object sender, EventArgs e)
        {
            if (cbZiekte.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een ziekte voordat u kunt verder gaan.");
            }
            else
            {
                string data = Convert.ToString(cbZiekte.SelectedItem);
                ziekteID = Convert.ToInt32(overig.GetSubstringByString("ID ", " -", data));
                string ziekteNaam = overig.GetSubstringByString(" - ", ".", data);

                btnChangeZiekte.Enabled = false;
                cbZiekte.Enabled = false;
                tbZiekte.Text = ziekteNaam;

                // Veld en knop mogen nu gebruikt worden, dus enabled = true
                tbZiekte.Enabled = true;
                btnUpdateZiekte.Enabled = true;
            }
        }

        private void btnUpdateZiekte_Click(object sender, EventArgs e)
        {
            string ziekte = tbZiekte.Text;
            
            int error = 0;
            
            if(ziekte == "")
            {
                ++error;
                MessageBox.Show("Voer een naam van de ziekte in!");
            }

            if (error == 0)
            {
                update.Update_Ziekte(ziekteID, ziekte);
                MessageBox.Show("De ziekte is succesvol bijgewerk!");

                refresh();

                cbZiekte.Enabled = true;
                btnChangeZiekte.Enabled = true;

                tbZiekte.Enabled = false;
                btnUpdateZiekte.Enabled = false;
            }

        }

        private void btnChangeMedicijn_Click(object sender, EventArgs e)
        {
            if (cbSelectMedicijn.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een medicijn voordat deze bewerkt kan worden!");
            }
            else
            {
                string data = Convert.ToString(cbSelectMedicijn.SelectedItem);
                string medicijnID = overig.GetSubstringByString("ID ", " -", data);
                cbSelectMedicijn.Enabled = false;
                btnChangeMedicijn.Enabled = false;

                // Elementen voor bewerken medicijn activeren
                tbMedicijnNaam.Enabled = true;
                tbBijwerkingMedicijn.Enabled = true;
                tbGebruikMedicijn.Enabled = true;
                btnUpdateMedicijn.Enabled = true;

                // We weten het medicijn ID, juiste elementen vullen met gegevens
                var medicijn = select.Select_Medicijn_Data(Convert.ToInt32(medicijnID));

                for (int i = 0; i < medicijn.Count; ++i)
                {
                    Dictionary<string, object> row = medicijn[i];
                    tbMedicijnNaam.Text = row["naam"].ToString();
                    tbGebruikMedicijn.Text = row["gebruik"].ToString();
                    tbBijwerkingMedicijn.Text = row["bijwerking"].ToString();
                }
            }
        }

        private void btnUpdateMedicijn_Click(object sender, EventArgs e)
        {
            string naam = tbMedicijnNaam.Text;
            string gebruik = tbGebruikMedicijn.Text;
            string bijwerking = tbBijwerkingMedicijn.Text;

            int error = 0;

            if(naam == "")
            {
                ++error;
                MessageBox.Show("Geef een naam op van de medicijn!");
            }
            if (gebruik == "")
            {
                ++error;
                MessageBox.Show("Geef het gebruik van het medicijn op!");
            }
            if (bijwerking == "")
            {
                ++error;
                MessageBox.Show("Geef een bijwerking voor het medicijn op!");
            }

            if(error == 0)
            {
                int medicijnID = Convert.ToInt32(overig.GetSubstringByString("ID ", " -", cbSelectMedicijn.Text));
                update.Update_Medicijn(medicijnID, naam, gebruik, bijwerking);
                MessageBox.Show("Medicijn succesvol aangepast!");

                refresh();
            }
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            if (cbSelectUser.SelectedItem != null)
            {
                tbUsername.Text = cbSelectUser.Text;
                cbSelectUser.Enabled = false;
                btnChangeUser.Enabled = false;

                tbUsername.Enabled = true;
                tbPwdNew.Enabled = true;
                tbPwdNewRepeat.Enabled = true;
                tbPwdOld.Enabled = true;
                btnUpdatePwd.Enabled = true;

                var data = select.Select_User_Password(Convert.ToString(cbSelectUser.SelectedItem));

                for(int i = 0; i < data.Count; ++i)
                {
                    Dictionary<string, object> row = data[i];
                    userpassword = (string)(row["password"]);
                }
            }
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            string oldpassword = overig.versleutel(tbPwdOld.Text);
            string newPwd = overig.versleutel(tbPwdNew.Text);
            string newPwdCheck = overig.versleutel(tbPwdNewRepeat.Text);
            string username = tbUsername.Text;

            int error = 0;

            if (oldpassword == "")
            {
                ++error;
                MessageBox.Show("Vul het oude wachtwoord in!");
            }
            if (oldpassword != userpassword)
            {
                ++error;
                MessageBox.Show("Het oude wachtwoord is onjuist.");
            }
            if(newPwd == "")
            {
                ++error;
                MessageBox.Show("Vul een nieuw wachtwoord in!");
            }
            if(newPwdCheck == "")
            {
                ++error;
                MessageBox.Show("Herhaal het wachtwoord opnieuw.");
            }
            if (newPwd != newPwdCheck)
            {
                ++error;
                MessageBox.Show("Beide nieuwe wachtwoorden komen niet overeen.");
            }

            if(error == 0)
            {
                string password = newPwd;
                update.Update_User(username, password);
                MessageBox.Show("Het wachtwoord is succesvol gewijzigd!");

                refresh();
            }
        }

        private void tbPascodeMedicatie_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelectMedicaite_Click(object sender, EventArgs e)
        {
            tbPascodeMedicatie.Enabled = false;
            btnSelectMedicaite.Enabled = false;

            cbSelectMedicatie.Enabled = true;
            btnSelectMedicatie2.Enabled = true;

            string pascode = tbPascodeMedicatie.Text;
            var medicatiedata = select.Select_Medicatie_Data(pascode);
            for(int j = 0; j < medicatiedata.Count; ++j)
            {
                Dictionary<string, object> row = medicatiedata[j];
                cbSelectMedicatie.Items.Add("ID " + row["medicatieID"] + " - " + row["naam"] + ", Start: " + row["gebruikstart"]);
            }
        }

        private void btnSelectMedicatie2_Click(object sender, EventArgs e)
        {
            cbSelectMedicatie.Enabled = false;
            btnSelectMedicatie2.Enabled = false;

            dtpGebruikEind.Enabled = true;
            dtpGebruikStart.Enabled = true;
            tbHoeveelheid.Enabled = true;
            btnUpdateMedicatie.Enabled = true;
            
            string data = Convert.ToString(cbSelectMedicatie.SelectedItem);

            medicatieID = Convert.ToInt32(overig.GetSubstringByString("ID ", " -", data));
            var medicatie = select.Select_Medicaite_MedicatieID(medicatieID);
            
            for( int i = 0; i < medicatie.Count; ++i)
            {
                Dictionary<string, object> row = medicatie[i];
                dtpGebruikEind.Text = Convert.ToString(row["gebruikstart"]);
                dtpGebruikEind.Text = Convert.ToString(row["gebruikeind"]);
                tbHoeveelheid.Text = Convert.ToString(row["hoeveelheid"]);
            }
        }

        private void btnUpdateMedicatie_Click(object sender, EventArgs e)
        {
            string gebruiksstart = dtpGebruikStart.Text;
            string gebruikeind = dtpGebruikEind.Text;
            string hoeveelheid = tbHoeveelheid.Text;

            int error = 0;

            if(gebruiksstart == "")
            {
                ++error;
                MessageBox.Show("Geef een begin datum voor de medicatie op!");
            }
            if(gebruikeind == "" )
            {
                ++error;
                MessageBox.Show("Geef een einddatum voor de medicatie op!");
            }
            if(hoeveelheid == "")
            {
                ++error;
                MessageBox.Show("Geef een hoeveelheid op voor de medicatie!");
            }

            if(error == 0)
            {
                update.Update_Medicatie(medicatieID, gebruiksstart, gebruikeind, hoeveelheid);
                MessageBox.Show("De medicatie is succesvol aangepast!");

                refresh();
                tbPascodeMedicatie.Enabled = true;
                btnSelectMedicaite.Enabled = true;
            }


        }

        private void btnSelectZiekte_Click(object sender, EventArgs e)
        {
            tbPascodeZiekte.Enabled = false;
            btnSelectZiekte.Enabled = false;

            cbSelectZiekte.Enabled = true;
            btnSelectZiekte2.Enabled = true;

            string pascode = tbPascodeZiekte.Text;

            var ziekteData = select.Select_Ziekte_Data(pascode);
            for (int i = 0; i < ziekteData.Count; ++i)
            {
                Dictionary<string, object> row = ziekteData[i];
                cbSelectZiekte.Items.Add("ID " + row["ziekteID"] + " - " + row["naam"]);
            }



        }

        private void btnSelectZiekte2_Click(object sender, EventArgs e)
        {
            cbSelectZiekte.Enabled = false;
            btnSelectZiekte2.Enabled = false;

            tbSymptomen.Enabled = true;
            btnUpdateZiektePatient.Enabled = true;

            string data = Convert.ToString(cbSelectZiekte.SelectedItem);
            ziekteID = Convert.ToInt32(overig.GetSubstringByString("ID ", " -", data));

            var ziekte = select.Select_Ziekte_Symptomen(ziekteID);
            for(int i = 0; i < ziekte.Count; ++i)
            {
                Dictionary<string, object> row = ziekte[i];
                tbSymptomen.Text = Convert.ToString(row["symptomen"]);
            }
        }

        private void btnUpdateZiektePatient_Click(object sender, EventArgs e)
        {
            string symptomen = tbSymptomen.Text;

            if(symptomen == "" )
            {
                MessageBox.Show("Geef de symptomen van de ziekte op!");
            }
            else
            {
                update.Update_Ziekteoverzicht(ziekteID, symptomen);
                MessageBox.Show("De symptomen van de ziekte zijn succesvol bijgewerkt!");

                refresh();

                tbPascodeZiekte.Enabled = true;
                btnSelectZiekte.Enabled = true;
            }
        }

        private void btnSelectAfspraak_Click(object sender, EventArgs e)
        {
            string pascode = tbPascodeAfspraak.Text;

            tbPascodeAfspraak.Enabled = false;
            btnSelectAfspraak.Enabled = false;

            cbAfspraak.Enabled = true;
            btnSelectAfspraak2.Enabled = true;

            var data = select.Select_Afspraak_Patient(pascode);
            for(int i = 0; i < data.Count; ++i)
            {
                Dictionary<string, object> row = data[i];
                cbAfspraak.Items.Add("ID " + row["medicatieID"] + " - " + row["naam"] + ", " + row["datum"]);
            }
        }

        private void btnSelectAfspraak2_Click(object sender, EventArgs e)
        {
            cbAfspraak.Enabled = false;
            btnSelectAfspraak2.Enabled = false;

            dtpAfspraak.Enabled = true;
            dtpTijd.Enabled = true;
            cbActief.Enabled = true;
            btnUpdateAfspraak.Enabled = true;

            string data = Convert.ToString(cbAfspraak.SelectedItem);
            int medicatieID = (Convert.ToInt32(overig.GetSubstringByString("ID ", " -", data)));

            var afspraakdata = select.Select_Afspraak_Data(medicatieID);
            for(int i = 0; i < afspraakdata.Count; ++i)
            {
                Dictionary<string, object> row = afspraakdata[i];
                cbLocatie.Items.Add(Convert.ToString(row["locatienaam"]));
                dtpAfspraak.Text = Convert.ToString(row["datum"]);
                dtpTijd.Text = Convert.ToString(row["tijd"]);
                afspraakID = Convert.ToInt32(row["medicatieID"]);
                if(Convert.ToInt32(row["actief"]) == 1)
                {
                    cbActief.Checked = true;
                }
            }
        }

        private void btnUpdateAfspraak_Click(object sender, EventArgs e)
        {
            string datum = dtpAfspraak.Text;
            string tijd = dtpTijd.Text;
            bool actief = cbActief.Checked;

            int error = 0;

            if(datum == "")
            {
                ++error;
                MessageBox.Show("Geef een datum van de afspraak op!");
            }
            if(tijd == "")
            {
                ++error;
                MessageBox.Show("Geef een tijd van de afspraak op!");
            }

            if(error == 0)
            {
                int actiefstatus;
                if(actief)
                {
                    actiefstatus = 1;
                }
                else
                {
                    actiefstatus = 0;
                }
                
                update.Update_Afspraak(afspraakID, datum, tijd, actiefstatus);
                MessageBox.Show("Afspraak is succesvol bijgewerkt!");
                refresh();
                tbPascodeAfspraak.Enabled = true;
                btnSelectAfspraak.Enabled = true;
                
            }
        }

    }
}
