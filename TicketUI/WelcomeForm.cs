using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDAO;
using System.Net.Mail;
using System.Net;

namespace TicketUI
{
    
    public partial class WelcomeForm : Form
    {
        public int ekKoltukSayisi=0;

        public List<Ticket> alinanBiletlerList = new List<Ticket>();
        public List<User> kayitliKullaniciList = new List<User>();

        public WelcomeForm()
        {
            InitializeComponent();
            grpBoxUserDetails.Visible = false;
            btnIptal.Visible = false;
            grpBoxEkKoltuk.Visible = false;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Button bCurtain = new Button();
            bCurtain.Text = "CURTAIN";
            bCurtain.BackColor = Color.DarkOliveGreen;
            bCurtain.Enabled = false;
            bCurtain.Width = this.fwCurtain.Width;
            bCurtain.Height = this.fwCurtain.Height;
            this.fwCurtain.Controls.Add(bCurtain);

            int seatNumber = 1;
            for (int i=0; i < 4; i++)
            {
                for(int j=0; j<8; j++)
                {
                    Button b = new Button();
                    b.Text = seatNumber.ToString();
                    b.Width = 45;
                    b.Height = 45;
                    b.Top = i * 50;
                    b.Left = j * 50;
                    b.Click += B_Click;

                    if (i % 2 != 0 && (j== 0 || j==7))
                    {
                        b.Visible = false;
                        b.Enabled = false;
                        seatNumber--;
                    }

                    this.pnlSeats.Controls.Add(b);
                    seatNumber++;
                }
                
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            grpBoxUserDetails.Visible = true;

            Button secilenKoltuk = sender as Button;
            txtBoxKoltukNo.Text = secilenKoltuk.Text;

            if (secilenKoltuk.Tag != null){
                User uOwns = secilenKoltuk.Tag as User;
                txtBoxKullAd.Text = uOwns.Name;
                txtBoxCepNo.Text = uOwns.MobileNumber;
                txtBoxMail.Text = uOwns.Email;

                btnIptal.Visible = true;

                //Find all tickets of the user
                foreach(Ticket t in alinanBiletlerList)
                {
                    if(t.UserBought.UserId == uOwns.UserId)
                    {
                        EkKoltuklariGetir(t.MySeats);
                    }
                }
            }
        }

        private void EkKoltuklariGetir(List<Seat> mySeats)
        {
            grpBoxEkKoltuk.Visible = true;
            ekKoltukSayisi = 0;

            foreach (Seat s in mySeats)
            {
                Label nl = new Label();
                nl.Text = "Ek Koltuk:";
                nl.Top = ekKoltukSayisi * 30;
                nl.Width = 60;
                this.pnlEkKoltuk.Controls.Add(nl);

                TextBox nTx = new TextBox();
                nTx.Top = ekKoltukSayisi * 30;
                nTx.Left = 80;
                nTx.Width = 50;
                nTx.Text = s.SeatNumber.ToString();
                this.pnlEkKoltuk.Controls.Add(nTx);

                ekKoltukSayisi++;
            }
        }

        private void btnKoltukEkle_Click(object sender, EventArgs e)
        {
            grpBoxEkKoltuk.Visible = true;
            
            Label nl = new Label();
            nl.Text = "Add Seat:";
            nl.Top = ekKoltukSayisi * 30;
            nl.Width = 60;
            this.pnlEkKoltuk.Controls.Add(nl);

            TextBox nTx = new TextBox();
            nTx.Top = ekKoltukSayisi * 30;
            nTx.Left = 80;
            nTx.Width = 50;
            this.pnlEkKoltuk.Controls.Add(nTx);

            Button nb = new Button();
            nb.Text = "+";
            nb.Width = 20;
            nb.Height = 20;
            nb.Top = ekKoltukSayisi * 30;
            nb.Left = 140;
            nb.Click += btnKoltukEkle_Click;
            this.pnlEkKoltuk.Controls.Add(nb);

            ekKoltukSayisi++;
     
        }

        private void btnSatin_Click(object sender, EventArgs e)
        {
            //get all seat numbers
            List<string> selectedSeatList = new List<string>();
            if(int.Parse(txtBoxKoltukNo.Text)<1 || int.Parse(txtBoxKoltukNo.Text) > 28 || txtBoxKoltukNo.Text=="")
            {
                MessageBox.Show("Geçerli bir koltuk numarası girin!");
                txtBoxKoltukNo.Text = "";
                return;
            }
            selectedSeatList.Add(txtBoxKoltukNo.Text);
            var txtBoxesSeatNumber = pnlEkKoltuk.Controls.OfType<TextBox>();
            foreach (TextBox tb in txtBoxesSeatNumber)
            {
                if (int.Parse(tb.Text) < 1 || int.Parse(tb.Text) > 28 || tb.Text=="")
                {
                    MessageBox.Show("Geçerli bir koltuk numarası girin!");
                    tb.Text = "";
                    return;
                }
                else
                {
                    selectedSeatList.Add(tb.Text);
                }
                
            }

            //seat check if empty, if not error
            if (seatEmpty(selectedSeatList)) //Seat Empty - BUY
            {
                //new user
                User nUser = new User();
                nUser.UserId = Guid.NewGuid();
                nUser.Name = txtBoxKullAd.Text;
                nUser.Email = txtBoxMail.Text;
                nUser.MobileNumber = txtBoxCepNo.Text;
                kayitliKullaniciList.Add(nUser);

                //button tag=user
                var seats = pnlSeats.Controls.OfType<Button>();
                foreach (Button b in seats)
                {
                    foreach (string ss in selectedSeatList)
                    {
                        if (ss == b.Text)
                        {
                            b.Tag = nUser;
                            b.BackColor = Color.Red;
                        }
                    }
                }

                //create ticket
                Ticket nTicket = new Ticket();
                nTicket.UserBought = nUser;
                List<Seat> alinanSeats = new List<Seat>();
                foreach (string ss in selectedSeatList)
                {
                    Seat nS = new Seat();
                    nS.SeatNumber = int.Parse(ss);
                    nS.Taken = true;
                    nS.Details = "Alındı";
                    nS.Price = 10m;
                    alinanSeats.Add(nS);
                }
                nTicket.MySeats = alinanSeats;
                alinanBiletlerList.Add(nTicket);

                //send an email
                //SendMailConfirmation(nTicket);

                MessageBox.Show("Your ticket is successfully created.");
                Temizle();

            }
            else //Seat Not Empty -Error
            {
                MessageBox.Show("Eklediğiniz koltuk müsait değildir! Lütfen başka koltuk deneyiniz.");

            }
        }

        private void SendMailConfirmation(Ticket nTicket)
        {
            string userMailAddr = nTicket.UserBought.Email;
            string userSeats = "Satın aldığınız koltuklar: ";
            foreach(Seat s in nTicket.MySeats)
            {
                userSeats += s.SeatNumber + " ";
            }
            try
            {
                // Credentials
                var credentials = new NetworkCredential("selenozek89@gmail.com", "xxxhjhjkgh");

                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("selenozek89@gmail.com"),
                    Subject = "Satın Aldığınız Biletler(Ticket Uygulaması)",
                    Body = userSeats
                };

                mail.To.Add(new MailAddress(userMailAddr));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }

        }

        private void Temizle()
        {
            txtBoxKullAd.Text = "";
            txtBoxMail.Text = "";
            txtBoxCepNo.Text = "";
            txtBoxKoltukNo.Text = "";
            pnlEkKoltuk.Controls.Clear();
            grpBoxEkKoltuk.Visible = false;
        }

        private bool seatEmpty(List<string> selectedSeatList)
        {
            var seats = pnlSeats.Controls.OfType<Button>();
            foreach (Button b in seats)
            {
                foreach(string ss in selectedSeatList)
                {
                    if (ss == b.Text && b.Tag!=null)
                    {
                        return false;
                    }
                } 
            }
            return true;
        }
    }
}
