using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Score_Board
{
    public partial class StartMatch : Form
    {
        public StartMatch()
        {
            InitializeComponent();
        }

        List<string> teamslist = new List<string>();
        private void StartMatch_Load(object sender, EventArgs e)
        {
            try
            {
                teamslist = File.ReadAllLines(@"Teams.txt").ToList();
                for (int i = 0; i < teamslist.Count; i++)
                {
                    comboBoxBattingTeam.Items.Add(teamslist[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        private void comboBoxBattingTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxBowlingTeam.Items.Clear();
                for (int i = 0; i < teamslist.Count; i++)
                {
                    if (teamslist[i] != comboBoxBattingTeam.Text)
                        comboBoxBowlingTeam.Items.Add(teamslist[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }

        }
        Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBattingTeam.Text == "SELECT" || comboBoxBowlingTeam.Text == "SELECT" || numericUpDown1.Value < 1)
                {
                    MessageBox.Show("Please select any team to start or minimum over should be greater than 0", "WARNING");
                }
                else
                {
                    f1 = new Form1(comboBoxBattingTeam.Text, comboBoxBowlingTeam.Text);
                    f1.totalovers = Convert.ToInt32(numericUpDown1.Value);
                    f1.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }
    }
}
