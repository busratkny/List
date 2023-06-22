using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ListeA = new List<string>() { "Ayşe-33", "Ali Hakan-28", "Fatma Nur-40", "Numan-27","Büşra-27","Pınar-30","Mustafa Deniz-35","Ayça-18","Barış-45" ,"Mehmet-32"};
            var ListeB = new List<string>();
            var ListeC = new List<string>();
            var yas = 30;

            for (int i = 0; i < ListeA.Count; i++)
            {
                var a = ListeA[i].Split('-');
                int b = Convert.ToInt16(a[1]);

                if (b >= yas)
                {
                    ListeB.Add(ListeA[i]);
                }
                else
                {
                    ListeC.Add(ListeA[i]);
                }
            }

            foreach (var item in ListeA)
            {
                listBoxA.Items.Add(item);
            }

            foreach (var item in ListeB)
            {
                listBoxB.Items.Add(item);
            }

            foreach (var item in ListeC)
            {
                listBoxC.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
