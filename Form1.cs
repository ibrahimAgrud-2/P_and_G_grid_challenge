using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
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
        public static int GetInt32(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
                throw new ArgumentOutOfRangeException();

            int diff = maxValue - minValue;
            byte[] uint32Buffer = new byte[4];

            using (var rng = RandomNumberGenerator.Create())
            {
                while (true)
                {
                    rng.GetBytes(uint32Buffer);
                    uint rand = BitConverter.ToUInt32(uint32Buffer, 0);

                    long max = (1L + uint.MaxValue) / diff * diff;

                    if (rand < max)
                        return (int)(minValue + (rand % diff));
                }
            }
        }
        //______________________________

        int[] Xs = new int[50];
        int[] Ys = new int[50];

 
        Guna2CustomRadioButton createRadioButton()
        {
            Guna2CustomRadioButton rb = new Guna2CustomRadioButton();


            rb.CheckedState.FillColor = System.Drawing.Color.White;
            rb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(64, 0, 0);
            rb.AutoSize = false;
            rb.Size = new System.Drawing.Size(27, 27);

            //_____________________________

        //    rb.Location = new Point(11, 111);
   
            return rb;
        }


        void testForAddRadioButtonsInLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                panel1.Controls.Add(createRadioButton());

            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            testForAddRadioButtonsInLoop();
        }

    
    }
}
