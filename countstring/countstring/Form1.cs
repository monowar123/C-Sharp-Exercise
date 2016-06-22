using System;
using System.Windows.Forms;

namespace countstring
{
    public partial class gggg
    {
        public gggg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vcount=0,ccount=0,dcount=0,spcount=0;
            string s = inputtext.Text;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    vcount++;
                else if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                    ccount++;
                else if (s[i] >= '0' && s[i] <= '9')
                    dcount++;
                else
                    spcount++;
            }
            vshow.Text = Convert.ToString(vcount);
            cshow.Text = Convert.ToString(ccount);
            dshow.Text = Convert.ToString(dcount);
            spshow.Text = Convert.ToString(spcount);

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
