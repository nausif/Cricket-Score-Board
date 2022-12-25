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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TextFiles.Teams.ToString() + ".txt"))
            {
                File.Create(TextFiles.Teams.ToString() + ".txt");
            }
            if (!(txtTeamName.Text == String.Empty) && txtTeamName.Text.Length >= 3)
            {
                StreamWriter sw = new StreamWriter(TextFiles.Teams.ToString() + ".txt", true);
                sw.WriteLine(txtTeamName.Text);
                sw.Close();
                MessageBox.Show("Team Name Added Successfully");
            }
            else
            {
                MessageBox.Show("Team Name Should not be Empty & Greater than 3 words","Alert");
            }
            
        }

        private void radioAddTeam_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAddTeam.Visible = true;
            groupBoxEditTeam.Visible = false;
        }
        List<string> editteamsarr = new List<string>();
        private void radioEditTeam_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAddTeam.Visible = false;
            groupBoxEditTeam.Visible = true;
            if (File.Exists(TextFiles.Teams.ToString() + ".txt"))
            {
                updateComboBoxItems();
                
            }
        }

        void updateComboBoxItems()
        {
            
            ComboBoxEdit.Items.Clear();
            editteamsarr.Clear();
            editteamsarr = File.ReadAllLines(TextFiles.Teams.ToString() + ".txt").ToList();
            for (int i = 0; i < editteamsarr.Count; i++)
            {
                ComboBoxEdit.Items.Add(editteamsarr[i]);
            }
        }

        public enum TextFiles
        {
            Teams,TeamsPlayers
        }
        
        private void ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxEdit.Items.Count != 0)
            {
                txtBox_EditTeam.Text = ComboBoxEdit.Text;
               
            }
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if (ComboBoxEdit.Items.Count != 0)
            {
                if (!(txtBox_EditTeam.Text == String.Empty) &&  txtBox_EditTeam.Text.Length >= 3)
                {
                    for (int i = 0; i < editteamsarr.Count; i++)
                    {
                        if (ComboBoxEdit.Text == editteamsarr[i])
                        {
                            editteamsarr.RemoveAt(i);
                            editteamsarr.Insert(i, txtBox_EditTeam.Text);
                            MessageBox.Show("Team Name Edit Successfully");
                            break;
                        }
                    }
                    File.WriteAllLines(TextFiles.Teams.ToString() + ".txt", editteamsarr.ToArray());
                    updateComboBoxItems();
                }
                else
                    MessageBox.Show("Team Name Should not be Empty & Greater than 3 words", "Alert");
            }
        }
    }
}
