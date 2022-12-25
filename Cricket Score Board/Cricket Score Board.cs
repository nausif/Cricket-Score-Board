using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Score_Board
{
    public partial class Cricket_Score_Board : Form
    {
        public Cricket_Score_Board()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("AAG TAPE BALL CRICKET TOURNAMENT\nVERSION 1.0\nDEVELOPED BY: NAUSIF MOMIN", "ABOUT SOFTWARE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new StartMatch().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }
    }
}
