using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Homework
{
    public partial class Clicker : Form
    {
        private Image[] images;
        private int currentIndex = 0;
        public Clicker()
        {
            InitializeComponent();
        }
        public static void UpdateScore(int clickerScore)
        {
            using var context = new YourDbContext();
            Count userScore;
            if (context.Count.Count(
                x => x.UserId.Equals(Program.Session.UserId)) == 0)
            {
                userScore = new Count()
                {
                    UserId = Program.Session.UserId,
                    Score = clickerScore
                };
                context.Count.Add(userScore);
            }
            else
            {
                userScore = context.Count.FirstOrDefault(
                    x => x.UserId.Equals(Program.Session.UserId));

                userScore.Score = clickerScore;
            }

            Program.Click = userScore;
            context.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var button = (PictureBox)sender;

            var images = new List<Image>()
    {
        Properties.Resources.kopatich,
        Properties.Resources.Sovunya,
        Properties.Resources.pin
    };
            images.Remove(button.BackgroundImage);
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.BackgroundImage = images[new Random().Next(images.Count)];

            (Program.Click.Score)++;
            label1.Text = $"{Program.Click.Score} нажатий";
        }

        private void Form1111_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateScore(Program.Click.Score);
            Application.Exit();
        }
    }
}
