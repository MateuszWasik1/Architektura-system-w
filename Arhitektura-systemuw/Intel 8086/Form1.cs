using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Reset1_Click(object sender, EventArgs e)
        {

            AX_text.Text = "";
            BX_text.Text = "";
            CX_text.Text = "";
            DX_text.Text = "";

            AX_text_2.Text = "";
            BX_text_2.Text = "";
            CX_text_2.Text = "";
            DX_text_2.Text = "";

        }

        private void Reset2_Click(object sender, EventArgs e)
        {

            SI_text.Text = "";
            DI_text.Text = "";
            BP_text.Text = "";
            SP_text.Text = "";
            DISP_text.Text = "";

            SI_text_2.Text = "";
            DI_text_2.Text = "";
            BP_text_2.Text = "";
            SP_text_2.Text = "";
            DISP_text_2.Text = "";

        }

        private void BX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = BX_text.Text;

        }

        private void CX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = CX_text.Text;

        }

        private void DX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = DX_text.Text;

        }

        private void AX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = AX_text.Text;

        }

        private void CX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = CX_text.Text;

        }

        private void DX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = DX_text.Text;

        }

        private void AX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = AX_text.Text;

        }

        private void BX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = BX_text.Text;

        }

        private void DX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = DX_text.Text;

        }

        private void AX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = AX_text.Text;

        }

        private void BX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = BX_text.Text;

        }

        private void CX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = CX_text.Text;

        }

        private void XCHG_AX_BX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_AX_CX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_AX_DX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_BX_AX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_BX_CX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_BX_DX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_CX_AX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_CX_BX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_CX_DX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_DX_AX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_DX_BX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_DX_CX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] value = new int[4];

            for (int i = 0; i < 4; i++)
            {
                
                value[i] = random.Next(0, 255);
               
            }
            

            AX_text.Text = Convert.ToString(value[0],16).ToUpper();
            BX_text.Text = Convert.ToString(value[1],16).ToUpper();
            CX_text.Text = Convert.ToString(value[2],16).ToUpper();
            DX_text.Text = Convert.ToString(value[3],16).ToUpper();

            AX_text_2.Text = Convert.ToString(value[0],16).ToUpper();
            BX_text_2.Text = Convert.ToString(value[1],16).ToUpper();
            CX_text_2.Text = Convert.ToString(value[2],16).ToUpper();
            DX_text_2.Text = Convert.ToString(value[3],16).ToUpper();
        }

        private void Random2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] value = new int[5];

            for (int i = 0; i < 5; i++)
            {

                value[i] = random.Next(0, 255);

            }


            SI_text.Text = Convert.ToString(value[0], 16).ToUpper();
            DI_text.Text = Convert.ToString(value[1], 16).ToUpper();
            BP_text.Text = Convert.ToString(value[2], 16).ToUpper();
            SP_text.Text = Convert.ToString(value[3], 16).ToUpper();
            DISP_text.Text = Convert.ToString(value[4], 16).ToUpper();


        }

    }
}
