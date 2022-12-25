using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Score_Board
{
    class BackTracking
    {
        public int overs = 0;
        public int balls = 0;
        public int wickets = 0;
        public int runs = 0;
        public int target = 0;
        public int remainballs = 0;
        public int remainruns = 0;
        public int totalovers = 0;
        public bool targetset = false;
        public int firstballwideorno = 0;
        public bool IsMatchisNotOver = true;
        public bool ballisvalid = false;
        public bool targetset_clear = false;
        public int pic_counter = 0;
        public List<PictureBox> pb = new List<PictureBox>();
        public BackTracking(int overs,int balls, int wickets, int runs, int 
            target, int remainballs, int remainruns, int totalovers,int firstballwideorno,
            bool targetset,int firstballwideorbom,bool IsMatchisNotOver, bool ballisvalid, bool taretset_Clear,
            int pic_counter,List<PictureBox> pb)
        {
            this.overs = overs;
            this.balls = balls;
            this.wickets = wickets;
            this.runs = runs;
            this.target = target;
            this.remainballs = remainballs;
            this.totalovers = totalovers;
            this.targetset = targetset;
            this.firstballwideorno = firstballwideorno;
            this.IsMatchisNotOver = IsMatchisNotOver;
            this.ballisvalid = ballisvalid;
            this.targetset_clear = targetset;
            this.pic_counter = pic_counter;
            this.pb = pb;
        }

        
    }
}
