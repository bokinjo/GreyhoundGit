using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Greyhound
{
    public partial class GreyhoundRacingForm : Form
    {
        Dogs dogs = new Dogs();
        Bitmap dogImage;
        Rectangle dogRectangle = new Rectangle();
        bool race = false;
        string[] imena = new String[4];

        public GreyhoundRacingForm()
        {
            InitializeComponent();

            dogImage = Properties.Resources.dog;

            for (int i = 0; i < 4; i++)
            {
                imena[i] = this.tableLayoutPanel1.Controls["dogMTB" + i].Text;
                //Grey. construktor(string name, Point initialL, Point destination, bool reached)
                dogs.AddMember(new Greyhound(imena[i],
                   new Point(20, 5 + (i * 50)), new Point(500, 5 + (i * 50)), i));

                this.tableLayoutPanel1.Controls["dogMTB" + i].Visible = false;
            }
            dogRectangle.Location = new Point(0, 0);
            dogRectangle.Size = new Size(60, 30);
            SaveNamesButton.Visible = false;
        }

        private void GreyhoundRacingForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawIamges(g);

        }

        private void DrawIamges(Graphics g)
        {
            if (motionTimer.Enabled)
            {
                if ((dogs.CheckWinner()) && race)
                {
                    motionTimer.Enabled = false;
                    race = false;
                    Winer();
                    RaceButton.Enabled = true;
                    SetNamesButton.Enabled = true;
                }
                else
                {
                    dogs.CurentLocation();
                }
            }
            foreach (Greyhound dog in dogs)
            {
                dogRectangle.Location = dog.CurrentLocation;
                g.DrawImage(dogImage, dogRectangle);
            }
        }

        private void SaveNamesButton_Click(object sender, EventArgs e)
        {
            LabelSave();
            LabelVisible(false);
            RaceButton.Enabled = true;
            SetNamesButton.Enabled = true;
            SaveNamesButton.Visible = false;
        }

        private void SetNamesButton_Click(object sender, EventArgs e)
        {
            SetNamesButton.Enabled = false;
            RaceButton.Enabled = false;
            SaveNamesButton.Visible = true;
            LabelVisible(true);
        }

        private void RaceButton_Click(object sender, EventArgs e)//nevalja
        {
            SetNamesButton.Enabled = false;
            race = true;

            dogs.Initial();

            motionTimer.Enabled = true;
            RaceButton.Enabled = false;
        }

        private void motionTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Winer()
        {
            
            MessageBox.Show("Poredak:\n  " + dogs[0].Name + "\n  "
                + dogs[1].Name + "\n  " + dogs[2].Name + "\n  " + dogs[3].Name);
        }

        public void LabelVisible(bool visible)
        {
            for (int i = 0; i < 4; i++)
            {
                this.tableLayoutPanel1.Controls["dogMTB" + i].Visible = visible;
            }
        }

        public void LabelSave()
        {
            int i = 0;
            foreach (Greyhound dog in dogs)
            {
                dog.Name = this.tableLayoutPanel1.Controls["dogMTB" + i].Text;
                //ode je dosta bija problem zbog indeksiranja
                this.Controls["Doglabel" + dog.LabelPosition].Text = dog.Name; 
                i++;
            }

        }
    }
}
