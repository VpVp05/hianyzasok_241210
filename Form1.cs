namespace hianyzasok_241210
{
    public partial class Form1 : Form
    {
        List<Hianyzasok> lista = new List<Hianyzasok>();

        void betoltes()
        {
            lista.Clear();
            dgvtabla.Rows.Clear();
            FileStream fs = new FileStream("szeptember.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            { 
                string sor = sr.ReadLine();
                Hianyzasok h = new Hianyzasok(sr.ReadLine());
                lista.Add(h);
                dgvtabla.Rows.Add(h.Nev,h.Osztaly,h.Hanyadika,h.Igazolt,h.Nigazolt,h.NapiHianyzasSzamolas());
                rtbadatok.Text = rtbadatok.Text + sor + "\n";
            }

            sr.Close();
            fs.Close();

            int max = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].NapiHianyzasSzamolas() > lista[max].NapiHianyzasSzamolas())
                {
                    i = max;
                }
            }
            lborak.Text = "Órák száma: " + max;
        }
        public Form1()
        {
            InitializeComponent();
            betoltes();
        }
    }
}
