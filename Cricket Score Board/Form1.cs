using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Score_Board
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public string Team1;
        public string Team2;

        public List<PictureBox> pb = new List<PictureBox>();
        List<BackTracking> ListBackTracking = new List<BackTracking>();
        

        public Form1(string Team1, string Team2)
        {
            try
            { 
            InitializeComponent();
            DoubleBuffered = true;
            this.Team1 = Team1;
            this.Team2 = Team2;
            panel1.BackColor = Color.FromArgb(230, 3, 61, 9);
            panel2.BackColor = Color.Blue;
            panel3.BackColor = Color.Blue;
            pictureBoxTeam1.BackColor = Color.FromArgb(3, 61, 9);
            pictureBoxTeam2.BackColor = Color.FromArgb(3, 61, 9);
            pictureBoxbat.BackColor = Color.FromArgb(3, 61, 9);
            pictureBoxball.BackColor = Color.FromArgb(3, 61, 9);
            pictureBoxTeam1.Image = Image.FromFile(Team1 + ".png");
            pictureBoxTeam2.Image = Image.FromFile(Team2 + ".png");
            fillAllimages();
            fillAllpanel1Labels();
            fillAllpanel2Labels();
            LoadListofTeam1();
            LoadListofTeam2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Label> panel1Labels = new List<Label>();
        List<Label> panel2Labels = new List<Label>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        void fillAllpanel1Labels()
        {
            for (int i = 0; i < 11; i++)
            {
                panel1Labels.Add((Label)Controls.Find("lbl_panel1_player" + (i + 1).ToString(), true)[0]);
            }
        }
        void LoadListofTeam1()
        {
            String[] arrteam1 = File.ReadAllLines(Team1 + ".txt");
            for (int i = 0; i < 11; i++)
            {
                panel1Labels[i].Text = arrteam1[i];
            }
        }

        void fillAllpanel2Labels()
        {
            for (int i = 0; i < 11; i++)
            {
                panel2Labels.Add((Label)Controls.Find("lbl_panel2_player" + (i + 1).ToString(), true)[0]);
            }
        }
        void LoadListofTeam2()
        {
            String[] arrteam2 = File.ReadAllLines(Team2 + ".txt");
            for (int i = 0; i < 11; i++)
            {
                panel2Labels[i].Text = arrteam2[i];
            }
        }

        void fillAllimages()
        {
            for (int i = 0; i < 8; i++)
            {
                pictureBoxes.Add((PictureBox)Controls.Find("pictureBox" + (i + 1).ToString(), true)[0]);
            }
        }
        void clearimages()
        {
            for (int i = 0; i < 8; i++)
            {
                pictureBoxes[i].Image = null;
            }
        }
        int overs = 0;
        int balls = 0;
        int wickets = 0;
        int runs = 0;
        int target = 0;
        int remainballs = 0;
        int remainruns = 0;
        public int totalovers = 7;
        bool targetset = false;
        int firstballwideorno = 0;
        bool IsMatchisNotOver = true;
        bool ballisvalid = false;
        //bool targetset_clear = false;
        void update_over_pics()
        {

            if (ballisvalid)
            {
                if (balls == 5)
                {
                    overs += 1;
                    balls = 0;
                    firstballwideorno = 0;
                }
                //else if (targetset_clear == true)
                //{
                //    balls = 0;
                //    targetset_clear = false;
                //}
                else
                    balls += 1;
                ballisvalid = false;
                lblOver.Text = overs.ToString() + "." + balls.ToString();
            }
            checkOutandOver();
        }
        void update_over()
        {
            ballisvalid = true;
            //if (balls == 5)
            //{
            //    overs += 1;
            //    balls = 0;
            //    firstballwideorno = 0;
            //}
            //else
            //    balls += 1;
            //if (balls == 1 && overs != 0)
            //{
            //    pic_counter = 1;
            //    clearimages();
            //}
            if (targetset)
            {
                remainballs--;
                lblremainsballs.Text = remainballs.ToString();
            }
            //if ((wickets == 10 || overs == totalovers) && targetset == false)
            //{
            //    overs = 0;
            //    wickets = 0;
            //    balls = 0;
            //    target = runs + 1;
            //    remainruns = target;
            //    remainballs = totalovers * 6;
            //    lblremainsballs.Text = remainballs.ToString();
            //    lblremainruns.Text = remainruns.ToString();
            //    lbltarget.Text = target.ToString();
            //    runs = 0;

            //    targetset = true;
            //    PictureBox p = new PictureBox();
            //    p.Image = pictureBoxbat.Image;
            //    pictureBoxbat.Image = pictureBoxball.Image;
            //    pictureBoxball.Image = p.Image;
            //}


        }

        void checkfirstballwideorno()
        {
            if (balls == 0)
            {
                firstballwideorno++;
            }
        }

        void checkOutandOver()
        {
            if ((wickets == 10 || overs == totalovers) && targetset == false)
            {
                overs = 0;
                wickets = 0;
                balls = 0;
                target = runs + 1;
                remainruns = target;
                remainballs = totalovers * 6;
                lblremainsballs.Text = remainballs.ToString();
                lblremainruns.Text = remainruns.ToString();
                lbltarget.Text = target.ToString();
                runs = 0;
                targetset = true;
                //targetset_clear = true;
                PictureBox p = new PictureBox();
                p.Image = pictureBoxbat.Image;
                pictureBoxbat.Image = pictureBoxball.Image;
                pictureBoxball.Image = p.Image;
                clearimages();
                pic_counter = 0;
                lblOver.Text = overs.ToString() + "." + balls.ToString();
                lblScore.Text = runs.ToString() + "/" + wickets.ToString();
               
            }
        }
        void runsremaincalculate(int run)
        {
            if (IsMatchisNotOver)
            {
                if (balls == 0 && firstballwideorno <= 1 && pic_counter != 1)
                {
                    pic_counter = 0;
                    clearimages();
                }
                pic_counter++;
                if (pic_counter == 9)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        pictureBoxes[i].Image = pictureBoxes[i + 1].Image;
                    }
                    pic_counter--;
                }
                if (targetset)
                {
                    remainruns -= run;
                    lblremainruns.Text = remainruns.ToString();
                }
                //if ((wickets == 10 || overs == totalovers) && targetset == false)
                //{
                //    overs = 0;
                //    wickets = 0;
                //    balls = 0;
                //    target = runs + 1;
                //    remainruns = target;
                //    remainballs = totalovers * 6;
                //    lblremainsballs.Text = remainballs.ToString();
                //    lblremainruns.Text = remainruns.ToString();
                //    lbltarget.Text = target.ToString();
                //    runs = 0;
                //    targetset = true;
                //    targetset_clear = true;
                //    PictureBox p = new PictureBox();
                //    p.Image = pictureBoxbat.Image;
                //    pictureBoxbat.Image = pictureBoxball.Image;
                //    pictureBoxball.Image = p.Image;
                //    clearimages();
                //    lblOver.Text = overs.ToString() + "." + balls.ToString();
                //    lblScore.Text = runs.ToString() + "/" + wickets.ToString();
                //}
                checkOutandOver();
            }
            if (targetset)
            {
                if (((target - 1) == this.runs && remainballs == 0) || ((target - 1) == this.runs && wickets == 10))
                {
                    clearimages();
                    lbl_WonDraw.Text = "Match has been drawn";
                    lbl_WonDraw.Visible = true;
                    IsMatchisNotOver = false;
                }
                else if (target <= this.runs)
                {
                    clearimages();
                    lblremainruns.Text = "0";
                    lbl_WonDraw.Text = Team2 + " Won By " + Math.Abs((10 - wickets)) + " Wickets";
                    lbl_WonDraw.Visible = true;
                    IsMatchisNotOver = false;
                    
                }
                else if (wickets == 10 || remainballs == 0)
                {
                    clearimages();
                    lbl_WonDraw.Text = Team1 + " Won By " + Math.Abs((target - runs) - 1) + " Runs";
                    lbl_WonDraw.Visible = true;
                    IsMatchisNotOver = false;
                }
            }
        }

        void KeyPressEvents(KeyEventArgs e)
        {
            try
            {
                if (IsMatchisNotOver)
                {
                    if (e.KeyData == (Keys.NumPad0) || e.KeyData.Equals(Keys.D0))
                    {
                        runs += 0;
                        update_over();
                        runsremaincalculate(0);

                        setimages("simplezero.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad6) || e.KeyData.Equals(Keys.D6))
                    {
                        runs += 6;
                        update_over();
                        runsremaincalculate(6);

                        setimages("simplesix.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad4) || e.KeyData.Equals(Keys.D4))
                    {
                        runs += 4;
                        update_over();
                        runsremaincalculate(4);
                        setimages("simplefour.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad1) || e.KeyData.Equals(Keys.D1))
                    {
                        runs += 1;
                        update_over();
                        runsremaincalculate(1);
                        setimages("simpleone.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad2) || e.KeyData.Equals(Keys.D2))
                    {
                        runs += 2;
                        update_over();
                        runsremaincalculate(2);
                        setimages("simpletwo.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad3) || e.KeyData.Equals(Keys.D3))
                    {
                        runs += 3;
                        update_over();
                        runsremaincalculate(3);
                        setimages("simplethree.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad5) || e.KeyData.Equals(Keys.D5))
                    {
                        runs += 5;
                        update_over();
                        runsremaincalculate(5);
                        setimages("simplefive.png");
                        update_over_pics();
                    }

                    else if (e.KeyData.Equals(Keys.NumPad7) || e.KeyData.Equals(Keys.D7))
                    {
                        runs += 7;
                        update_over();
                        runsremaincalculate(7);
                        setimages("simpleseven.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad8) || e.KeyData.Equals(Keys.D8))
                    {
                        runs += 8;
                        update_over();
                        runsremaincalculate(8);
                        setimages("simpleeight.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.NumPad9) || e.KeyData.Equals(Keys.D9))
                    {
                        runs += 9;
                        update_over();
                        runsremaincalculate(9);
                        setimages("simplenine.png");
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.F))
                    {
                        runs += 4;
                        update_over();
                        runsremaincalculate(4);
                        setimages("four.png");
                        // 4 image
                        update_over_pics();
                    }
                    else if (e.KeyData.Equals(Keys.S))
                    {
                        runs += 6;
                        update_over();
                        runsremaincalculate(6);
                        setimages("six.png");
                        // 6 image
                        update_over_pics();
                    }
                    //else if (e.KeyData == Keys.O)
                    //{
                    //    wickets += 1;
                    //    update_over();
                    //}
                    //else if (e.KeyData.Equals(Keys.W))
                    //{
                    //    runs += 1;
                    //}
                    //else if (e.KeyData.Equals(Keys.N))
                    //{
                    //    runs += 1;
                    //}
                    lblScore.Text = runs.ToString() + "/" + wickets.ToString();
                }
            
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}






        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                KeyPressEvents(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }


        }
        bool isCtrlWPressed;
        bool isCtrlNPressed;
        bool isCtrlOPressed;
        bool isShiftWPressed;
        bool isShiftNPressed;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 

            if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.Shift)
            {
                this.Hide();
                this.Dispose();
                new Cricket_Score_Board().Show();
            }
            if (IsMatchisNotOver)
            {
                    if(e.KeyCode == Keys.Back)
                    {
                        if (pic_counter != 0)
                            pic_counter--;
                        pictureBoxes[pic_counter].Image = null;
                      
                    }
                    if (e.KeyCode == Keys.Oemplus)
                    {

                        runs += 1;
                        if (targetset)
                        {
                            remainruns -= 1;
                            lblremainruns.Text = remainruns.ToString();
                        }
                    }
                    else if (e.KeyCode == Keys.Add)
                    {
                        if(wickets < 10)
                        {
                            wickets += 1;
                        }
                    }
                    else if (e.KeyCode == Keys.Subtract)
                    {

                        if (wickets > 0)
                        {
                            wickets -= 1;
                        }
                    }
                    else if (e.KeyCode == Keys.OemMinus)
                    {
                        bool a = false;
                        if (runs != 0)
                        {
                            runs -= 1;
                            a = true;
                        }
                        if (targetset && a)
                        {
                            a = false;
                            remainruns += 1;
                            lblremainruns.Text = remainruns.ToString();
                        }
                    }
                    else if (e.KeyCode == Keys.OemCloseBrackets)
                    {
                        if (balls >= 5)
                        {
                            overs += 1;
                            balls = 0;
                        }
                        else
                        {
                            balls += 1;
                        }

                        lblOver.Text = overs.ToString() + "." + balls.ToString();
                       

                        if (targetset)
                        {
                            remainballs -= 1;
                            lblremainsballs.Text = remainballs.ToString();
                        }
                        
                    }
                    else if (e.KeyCode == Keys.OemOpenBrackets)
                    {
                        if (balls == 0 && overs != 0)
                        {
                            overs -= 1;
                            balls = 6;
                        }
                        bool a = false;
                        if (overs == 0 && balls == 0)
                        {
                            // BLANK SPACE
                        }
                        else
                        {
                            a = true;
                            balls -= 1;
                        }

                        
                     
                        

                        lblOver.Text = overs.ToString() + "." + balls.ToString();
                        if (targetset && a)
                        {
                            a = false;
                            remainballs += 1;
                            lblremainsballs.Text = remainballs.ToString();
                        }
                    }
                    if (isCtrlWPressed && e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 1;
                        wickets += 1;
                        runsremaincalculate(1);
                        setimages("wd+w.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D0 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 1;
                        runsremaincalculate(1);
                        setimages("wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D4 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 5;
                        runsremaincalculate(5);

                        setimages("4wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 2;
                        runsremaincalculate(2);

                        setimages("1wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D2 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 3;
                        runsremaincalculate(3);

                        setimages("2wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D5 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 6;
                        runsremaincalculate(6);

                        setimages("5wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D6 && e.Modifiers == Keys.Control)
                    {

                        checkfirstballwideorno();
                        runs += 7;
                        runsremaincalculate(7);

                        setimages("6wd.png");
                    }
                    else if (isCtrlWPressed && e.KeyCode == Keys.D3 && e.Modifiers == Keys.Control)
                    {

                        checkfirstballwideorno();
                        runs += 4;
                        runsremaincalculate(4);

                        setimages("3wd.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
                    {

                        checkfirstballwideorno();
                        runs += 1;
                        wickets += 1;
                        runsremaincalculate(1);

                        setimages("nbwicket.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D0 && e.Modifiers == Keys.Control)
                    {

                        checkfirstballwideorno();
                        runs += 1;
                        runsremaincalculate(1);
                        setimages("nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D4 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 5;
                        runsremaincalculate(5);
                        setimages("4nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 2;
                        runsremaincalculate(2);

                        setimages("1nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D2 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 3;
                        runsremaincalculate(3);

                        setimages("2nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D3 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 4;
                        runsremaincalculate(4);

                        setimages("3nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D5 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 6;
                        runsremaincalculate(6);

                        setimages("5nb.png");
                    }
                    else if (isCtrlNPressed && e.KeyCode == Keys.D6 && e.Modifiers == Keys.Control)
                    {
                        checkfirstballwideorno();
                        runs += 7;
                        runsremaincalculate(7);

                        setimages("6nb.png");
                    }

                    else if (isCtrlOPressed && e.KeyCode == Keys.D0 && e.Modifiers == Keys.Control)
                    {
                        runs += 0;
                        wickets += 1;
                        update_over();
                        runsremaincalculate(0);
                        setimages("wicket.png");
                        update_over_pics();
                    }

                    else if (isCtrlOPressed && e.KeyCode == Keys.D4 && e.Modifiers == Keys.Control)
                    {
                        runs += 4;
                        wickets++;
                        update_over();

                        runsremaincalculate(4);


                        setimages("wicket+4.png");
                        update_over_pics();
                    }
                    else if (isCtrlOPressed && e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
                    {
                        runs += 1;
                        wickets++;

                        update_over();
                        runsremaincalculate(1);

                        setimages("wicket+1.png");
                        update_over_pics();
                    }
                    else if (isCtrlOPressed && e.KeyCode == Keys.D2 && e.Modifiers == Keys.Control)
                    {
                        runs += 2;
                        wickets++;
                        update_over();
                        runsremaincalculate(2);

                        setimages("wicket+2.png");
                        update_over_pics();
                    }
                    else if (isCtrlOPressed && e.KeyCode == Keys.D3 && e.Modifiers == Keys.Control)
                    {
                        runs += 3;
                        wickets++;
                        update_over();
                        runsremaincalculate(3);


                        setimages("wicket+3.png");
                        update_over_pics();
                    }

                    // NO BALL RUN OUT + TAKEN RUNS
                    else if (isShiftNPressed && e.KeyCode == Keys.D1 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // No ball pe 1 Run or Wicket
                        runs += 2;
                        wickets++;
                        runsremaincalculate(2);


                        setimages("nbwicket+1.png");
                    }
                    else if (isShiftNPressed && e.KeyCode == Keys.D2 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // No ball pe 2 Run or Wicket
                        runs += 3;
                        wickets++;
                        runsremaincalculate(3);


                        setimages("nbwicket+2.png");
                    }
                    else if (isShiftNPressed && e.KeyCode == Keys.D3 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // No ball pe 3 Run or Wicket
                        runs += 4;
                        wickets++;
                        runsremaincalculate(4);


                        setimages("nbwicket+3.png");
                    }

                    // Wide + Runs + RunOut 
                    else if (isShiftWPressed && e.KeyCode == Keys.D1 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // wide pe 1 Run or Wicket
                        runs += 2;
                        wickets++;
                        runsremaincalculate(2);


                        setimages("1wd+w.png");
                    }
                    else if (isShiftWPressed && e.KeyCode == Keys.D2 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // wide pe 2 Run or Wicket
                        runs += 3;
                        wickets++;
                        runsremaincalculate(3);


                        setimages("2wd+w.png");
                    }
                    else if (isShiftWPressed && e.KeyCode == Keys.D3 && e.Modifiers == Keys.Shift)
                    {
                        checkfirstballwideorno();
                        // wide pe 3 Run or Wicket
                        runs += 4;
                        wickets++;
                        runsremaincalculate(4);
                        setimages("3wd+w.png");
                    }
                isCtrlWPressed = (e.KeyCode == Keys.W && e.Modifiers == Keys.Control);
                isCtrlNPressed = (e.KeyCode == Keys.N && e.Modifiers == Keys.Control);
                isCtrlOPressed = (e.KeyCode == Keys.O && e.Modifiers == Keys.Control);
                isShiftNPressed = (e.KeyCode == Keys.N && e.Modifiers == Keys.Shift);
                isShiftWPressed = (e.KeyCode == Keys.W && e.Modifiers == Keys.Shift);
                lblScore.Text = runs.ToString() + "/" + wickets.ToString();
               // lblOver.Text = overs.ToString() + "." + balls.ToString();
                //lblremainruns.Text = remainballs.ToString();
                //lblremainsballs.Text = remainruns.ToString();


            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}
        int pic_counter = 0;
        public void setimages(string Image_Name)
        {
            PictureBox p = new PictureBox();
            switch (pic_counter)
            {
                case 1:
                    p = pictureBox1;
                    break;
                case 2:
                    p = pictureBox2;
                    break;
                case 3:
                    p = pictureBox3;
                    break;
                case 4:
                    p = pictureBox4;
                    break;
                case 5:
                    p = pictureBox5;
                    break;
                case 6:
                    p = pictureBox6;
                    break;
                case 7:
                    p = pictureBox7;
                    break;
                case 8:
                    p = pictureBox8;
                    break;
                default:
                    break;
            }
            if (pic_counter <= 8)
                p.Image = Image.FromFile(Image_Name);

        }

        void OpenProfileandHighlight(Label lbl, string teamName)
        {
            if (lbl.BackColor == Color.Transparent)
            {
                lbl.BackColor = Color.Black;
            }
            else
            {
                lbl.BackColor = Color.Transparent;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_panel1_player1_Click(object sender, EventArgs e)
        {
            try
            { 
            OpenProfileandHighlight(lbl_panel1_player1, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player2, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player3, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player4, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player5, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player6, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player7, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player8_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player8, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player9, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player10_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player10, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel1_player11_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel1_player11, Team1);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player1, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player2, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player3, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player4, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player5, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player6_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player6, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player7, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player8_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player8, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player9, Team2);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
}

        private void lbl_panel2_player10_Click(object sender, EventArgs e)
        {
                try
            { 
            OpenProfileandHighlight(lbl_panel2_player10, Team2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        private void lbl_panel2_player11_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProfileandHighlight(lbl_panel2_player11, Team2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }
        }

        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                // Set the value of the double-buffering style bits to true.
                this.SetStyle(ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint,
                true);

                this.UpdateStyles();
            }
        }





        private void pictureBoxClosePanel_Click(object sender, EventArgs e)
        {
            try
            {

                panel_Display_Profiles.Visible = false;
                panel_Display_Profiles.BackgroundImage.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + " this exception occured");
            }

        }

        private void pictureBoxTeam1_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBoxTeam2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
    



