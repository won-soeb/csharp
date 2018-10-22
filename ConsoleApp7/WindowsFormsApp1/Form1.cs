using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var font = FontFamily.Families;
            foreach(FontFamily f in font)
            {
                comfont.Items.Add(f.Name);
            }
        }
        enum Sports : int
        {
            축구, 야구, 농구, 태권도
        }
        private void rdoSoccer_CheckedChanged(object sender, EventArgs e)
        {
            this.seletedSports = (sports)0;
            IblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }
        private void rdoBaseball_CheckedChanged(object sender, EventArgs e)
        {
            this.seletedSports = (sports)1;
            IblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }
        private void rdoBasketball_CheckedChanged(object sender, EventArgs e)
        {
            this.seletedSports = (sports)2;
            IblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }
        private void rdoTkd_CheckedChanged(object sender, EventArgs e)
        {
            this.seletedSports = (sports)3;
            IblSports.Text = selectedSports + "(을)를 선택했습니다.";
        }
        void ChangeFont()
        {
            if(comfont.SelectedIndex < 0)
            {
                return;
            }
            FontStyle fs = FontStyle.Regular;
            if (chkBold.Checked)
            {
                fs |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                fs |= FontStyle.Italic;
            }
            txtMessage.Font = new Font((string)comfont.SelectedItem, 10, fs);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkBold_ChechkedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkItalic_ChechkedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void IblSports_Click(object sender, EventArgs e)
        {

        }
    }
}
