using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace P___G_Grid_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ibrahimAgrud-2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Generate Random number
        //______________________________
        private static Random random;
        private static void Init()
        {
            if (random == null) random = new Random();
        }
        public static int Random(int min, int max)
        {
            Init();
            return random.Next(min, max);
        }
        //______________________________


  
        //To get a better dispersal, just a certain number of X points is  allowed  
        List<int> Xs = new List<int> { 1, 29, 57, 85, 113, 141, 169, 197, 225, 253, 281, 309, 337, 365, 393, 421, 449, 477, 505, 533, 561, 589, 617, 645, 673, 701, 729, 757, 785, 813, 841, 869, 897, 925, 953, 981, 1009, 1037, 1065, 1093, 1110 };


        int getXPoint()
        {
            int var = Xs[Random(0, Xs.Count)];
            Xs.Remove(var);

            return var;
        }


        int getYPoint()
        {
            int var = Random(9, 420);
            return var;
        }

       
        //Create a single checkbox
        Guna2CustomCheckBox createRadioButton()
        {
            Guna2CustomCheckBox rb = new Guna2CustomCheckBox();

            //----Create checkboxes------
            rb.CheckedState.FillColor = System.Drawing.Color.White;
            rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            rb.AutoSize = false;
            rb.Size = new System.Drawing.Size(22, 22);
           //---------------------------------
          
            
            rb.Location = new Point(getXPoint(), getYPoint());
   
            return rb;
        }



        //Place created the checkbox in the panel
        void placeCreatedCheckbox()
        {
            for (int i = 0; i < 30; i++)
            {
                panel1.Controls.Add(createRadioButton());

            }
       
        }

        struct stRoundInfo
        {
           public Guna2CustomCheckBox cb;

        }

        private Guna2CustomCheckBox selectRandomCheckbox()
        {
            if (panel1.Controls.Count>0)
            {
                Guna2CustomCheckBox cb = (Guna2CustomCheckBox)panel1.Controls[Random(0, panel1.Controls.Count)];

                if (cb != null)
                {
                    cb.Checked = true;
                    return cb; ;
                }
            }
            return null;
           
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            
           placeCreatedCheckbox();
           
        }

    }
}
