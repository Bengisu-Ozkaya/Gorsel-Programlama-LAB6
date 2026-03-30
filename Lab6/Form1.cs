namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] renkler = { "sarý", "kýrmýzý", "mavi", "beyaz", "turuncu" };
            label1.Text = "RENKLER: " + renkler[4];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            sayilar.Add(40);

            label2.Text = "SAYILAR: " + sayilar.ElementAt(0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar_dizi = new int[10];
            int dizi_toplam = 0;

            listBox1.Items.Clear();
            for (int i = 0; i < sayilar_dizi.Length; i++)
            {
                sayilar_dizi[i] = i;
                listBox1.Items.Add(sayilar_dizi[i]);
            }

            foreach (int x in sayilar_dizi)
            {
                dizi_toplam += x;

            }

            listBox1.Items.Add("Toplam");
            listBox1.Items.Add(dizi_toplam.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");

            List<int> sayilar_liste = new List<int>();
            int liste_toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                sayilar_liste.Add(2 * i);
                listBox1.Items.Add(sayilar_liste.ElementAt(i));
            }

            foreach (int x in sayilar_liste)
            {
                liste_toplam += x;
            }
            listBox1.Items.Add("Toplam");
            listBox1.Items.Add(liste_toplam);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayac = 1;

            listBox1.Items.Clear();

            while (sayac <= 10)
            {
                listBox1.Items.Add(sayac);
                sayac++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayac = 6;

            do
            {
                listBox1.Items.Add("Merhaba");
                sayac++;

            } while (sayac <= 5);

        }
    }
}
