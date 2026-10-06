using System.Runtime.InteropServices.Marshalling;

namespace ParalimpiaGUI
{
    public partial class Form1 : Form
    {
        List<Paralimpia> paralimpias = new List<Paralimpia>();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            read();
            write();
        }

        private void write()
        {
            foreach(var p in paralimpias) 
            {
                dataGridView1.Rows.Add(p.Id, p.Orszag, p.Varos, p.Ev, p.Arany, p.Ezust, p.Bronz);
            }
        }

        private void read()
        {
            using (StreamReader r = new StreamReader("../../../forras/ermek.txt"))
            {
                while (!r.EndOfStream) 
                {
                    string line = r.ReadLine();
                    paralimpias.Add(new Paralimpia(line));
                }
            }
        }
    }
}
