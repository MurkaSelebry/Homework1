using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Homework1
{
    public partial class Labirint : Form
    {
        public Labirint()
        {
            InitializeComponent();
        }
        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Position = new Point(625, 385);
        }

        private void Labirint_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Position = new Point(625, 385);

        }

        private void finish_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ура, вы прошли 1 уровень!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            SecondLevel sl= new SecondLevel();
            sl.ShowDialog();
            this.Close();
            
        }

        //private void start_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Text = CoordinatesToString(e);
        //    this.Cursor = new Cursor(Cursor.Current.Handle);
        //    MessageBox.Show($"{Cursor.Position.X} and {Cursor.Position.Y}");
        //}
    }
}
