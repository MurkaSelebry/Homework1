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
    public partial class SecondLevel : Form
    {
        public SecondLevel()
        {
            InitializeComponent();
        }
        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Position = new Point(790, 430);
        }

        private void SecondLevel_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Position = new Point(790, 430);
        }

        private void finish_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ура, вы прошли игру!", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
        
    }
}
