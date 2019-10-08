using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SurvivalBoard;

namespace SurvivalUI
{
    public partial class Savannah : Form
    {
        Random gen = new Random();
        SurvivalController sc = new SurvivalController();
        Lion l = new Lion();
        Rabbit r = new Rabbit();
        PictureBox[,] pb = new PictureBox[20, 20];
        public Savannah()
        {
            InitializeComponent();
            sc.PlaceOneAnimal(l, 4, 4);
            sc.PlaceOneAnimal(l, 6, 4);
            sc.PlaceOneAnimal(l, 5, 4);


            sc.PlaceOneAnimal(r, 1, 1);
            sc.PlaceOneAnimal(r, 1, 3);
            sc.PlaceOneAnimal(r, 1, 7);
            sc.PlaceOneAnimal(r, 2, 6);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    pb[i, j] = new PictureBox();
                    pb[i, j].Location = new Point(i * 25 + 100, j * 25 + 100);
                    pb[i, j].Width = 25;
                    pb[i, j].Height = 25;
                    pb[i, j].Tag = null;
                    pb[i, j].Visible = true;
                    pb[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pb[i, j].BringToFront();
                    Controls.Add(pb[i, j]);
                }
            }

            FillBoard();
        }
        private void FillBoard()
        {
            foreach (Tile t in sc.GetAllTiles())
            {

                if (t.Animal == null)
                {
                    pb[t.Row, t.Column].BackColor = Color.LightGoldenrodYellow;
                    if (t.Grass == true)
                        pb[t.Row, t.Column].BackColor = Color.Green;
                    
                }

                if (t.Animal != null)
                {
                    if (t.Animal.Species == 'L')
                    {                      
                        pb[t.Row, t.Column].BackColor = Color.Red; //hvis et animal er en lion sker dette
                    }

                    if (t.Animal.Species == 'R')
                    {
                        pb[t.Row, t.Column].BackColor = Color.LightGray; //hvis et animal er en rabbit sker dette
                    }
                }
                //else //overskriver linje 46-52 cirka
                //{
                //    pb[t.Row, t.Collum].BackColor = Color.White;
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.OneGameTurn();
            FillBoard();
        }
    }
}
