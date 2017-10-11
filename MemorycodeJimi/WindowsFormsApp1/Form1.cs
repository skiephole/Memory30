using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            List<MemoryCard> list = MakeList();
            MemoryCard[] catalog = MakeCatalog();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                AssignRandomTag(control, list);
            }

        }

        private void ImageClick(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            if (picturebox.BackColor != Color.Black)
                picturebox.BackColor = Color.Black;
        }

        private List<MemoryCard> MakeList()     //maakt een lijst met memorycardobjecten.
        {
            List<MemoryCard> paartjesLijst = new List<MemoryCard>();
            for (int i = 0; i < 8; i++)
            {
                paartjesLijst.Add(new MemoryCard(i));
                paartjesLijst.Add(new MemoryCard(i));
            }
            return paartjesLijst;
        }

        private MemoryCard[] MakeCatalog()      //maakt een catalogus voor de picturebox om zijn info in op te zoeken.
        {
            MemoryCard[] catalog = new MemoryCard[8];
            for (int i = 0, l = catalog.Length; i < l; i++)
            {
                catalog[i] = new MemoryCard(i);
            }
            return catalog;
        }

        private void AssignRandomTag(Control control, List<MemoryCard> list)
        {
            int i = rnd.Next(0, list.Count);
            control.Tag = list[i].Pair;
            list.RemoveAt(i);
        }


    }
}
