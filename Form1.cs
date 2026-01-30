using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Threading;

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


        //[EN]
        //Generates a random number within a given range using a single static Random instance
        //------------------------------
        //[TR]
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



        //[EN]
        //To prevent overlapping and clustering, only predefined X points are allowed and selected randomly
        //------------------------------
        //[TR]
        //Normalde her box için konumu panel1'de rastgele seçtirecektim ancak rastgele seçmede çok fazla üst üste veya kümelenme oluyor. Bu
        //yüzden rastgele seçmek yerine, ben bazı çakışmayacak X-Y noktaları belirledim, program oradan rastgele seçsin. Önce hem X hem de Y
        //koordinatlarını ayrı ayrı listeye ekledim. Listeye koordinatları hiçbir şekilde çakışmayacak formatta hesaplayarak ekledim. Sonra
        //program o koordinatlardan rastgele bir X ve rastgele bir Y sayısı seçip oraya box yerleştirdi. Ama sonra fark ettim ki Y
        //koordinatları rastgele seçilse de neredeyse hiç üst üste gelmiyor. Bu yüzden sadece X koordinatlarını ben belirledim.

        List<int> Xs = new List<int> { 1, 29, 57, 85, 113, 141, 169, 197, 225, 253, 281, 309, 337,
            365, 393, 421, 449, 477, 505, 533, 561, 589, 617, 645, 673, 701, 729, 757, 785, 813, 841,
            869, 897, 925, 953, 981, 1009, 1037, 1065, 1093, 1110 };

        //[EN]
        //Selects a random X coordinate from the predefined list and removes it to prevent reuse
        //------------------------------
        //[TR]
        //Panel1 sınırları içinden seçilmiş X koordinatları listesinde rastgele bir X noktası seç ve seçtiğin elemanı listeden çıkar
        int getXPoint()
        {
            int var = Xs[Random(0, Xs.Count)];
            Xs.Remove(var);

            return var;
        }


        //[EN]
        //Selects a random Y coordinate within the panel boundaries
        //------------------------------
        //[TR]
        //Panel1 sınırları içinde rastgele Y noktası seç
        int getYPoint()
        {
            int var = Random(9, 420);
            return var;
        }


        //[EN]
        //Creates a checkbox with the desired visual format and random position
        //------------------------------
        //[TR]
        //İstediğim formatta bir box üret
        //Create a single checkbox
        Guna2CustomCheckBox createCheckbox()
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

        //[EN]
        //Places the created checkboxes randomly into the panel
        //------------------------------
        //[TR]
        //Oluşturulan box'ları bu kısımda rastgele panel'e yerleştirdik.
        void placeCreatedCheckbox()
        {
            for (int i = 0; i < 30; i++)
            {
                pnlCheckBoxes.Controls.Add(createCheckbox());

            }

        }

       


        //[EN]
        //Stores selected boxes in a list for later use
        //------------------------------
        //[TR]
        //Seçilen box'lar daha sonra kullanacağımız için onları listeye ekledim.
        private List<Guna2CustomCheckBox> SelectedCheckboxes = new List<Guna2CustomCheckBox>();

        //[EN]
        //Selects a random checkbox from the placed boxes and marks it as selected
        //------------------------------
        //[TR]
        //placeCreatedCheckbox fonksiyonu ile yerleştirilen box'lardan rastgele birini seçme fonksiyonu
        private Guna2CustomCheckBox selectRandomCheckbox()
        {
            if (pnlCheckBoxes.Controls.Count > 0)
            {
                Guna2CustomCheckBox cb = (Guna2CustomCheckBox)pnlCheckBoxes.Controls[Random(0, pnlCheckBoxes.Controls.Count)];

                while (SelectedCheckboxes.Contains(cb))
                {

                    cb = (Guna2CustomCheckBox)pnlCheckBoxes.Controls[Random(0, pnlCheckBoxes.Controls.Count)];
                }
                cb.Checked = true;
                SelectedCheckboxes.Add(cb);
                return cb;
            }
            return null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCheckBoxes.Enabled = false;
            placeCreatedCheckbox();
            timer1.Start();


        }



        //[EN]
        //Unselects previously selected boxes before selecting a new one
        //------------------------------
        //[TR]
        //Bir box seçildi. Daha sonra bir sonraki seçilmeden önceki unselect yapılmalı. Bu fonksiyon o işlevi görür.
        void unselectBoxes()
        {
            foreach (Guna2CustomCheckBox item in SelectedCheckboxes)
            {
                item.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            /*[EN]
            //First, unselect the previously selected boxes, then select a new one
            //Selection logic: [Select → wait → unselect]
            //Waiting time is determined by the timer tick interval
            //------------------------------
            //[TR]
            //İlk önce seçilmiş olan box'ları unselect yap, sonra diğerini seç.
            //Box seçme mantığı şu şekilde ilerler: [Seç - bekle - seçileni kaldır]
            //Bekleme süresi timer'ın tick süresine göre belirlenir*/
           
            unselectBoxes();

            /*[EN]
            //Stop selecting if 3 boxes have been selected
            //------------------------------
            //[TR]
            //Eğer 3 buton seçilmişse seçme işlemini durdur*/
          
            if (SelectedCheckboxes.Count == 3)
            {
                timer2.Stop();
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                return;
            }
            selectRandomCheckbox();
            timer2.Start();


        }



        byte counter = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            guna2ProgressBar1.Value = counter;

            if (counter==guna2ProgressBar1.Maximum)
            {
                counter = 0;
                guna2ProgressBar1.Value = 0;
            }
        }

   
    }
}
