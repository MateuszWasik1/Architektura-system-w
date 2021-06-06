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

        int[] memory = new int[65536];

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

            int[] value = new int[8];
            string[] value2 = new string[8];

            for (int i = 0; i < value.Length; i++)
            {
                
                value[i] = random.Next(0, 255);
                  
            }
            for (int j = 0; j < value.Length; j++)
            {
                if (value[j]<16)
                {
                   value2[j] = "0"+ Convert.ToString(value[j], 16).ToUpper();
                }
                else
                {
                    value2[j] = Convert.ToString(value[j], 16).ToUpper();
                }
                
            }


            string a1 = value2[0];
            string b1 = value2[1];
            string c1 = value2[2];
            string d1 = value2[3];
            string a2 = value2[4];
            string b2 = value2[5];
            string c2 = value2[6];
            string d2 = value2[7];


            AX_text.Text = a1 + a2;
            BX_text.Text = b1 + b2;
            CX_text.Text = c1 + c2;
            DX_text.Text = d1 + d2;

            AX_text_2.Text = a1 + a2;
            BX_text_2.Text = b1 + b2;
            CX_text_2.Text = c1 + c2;
            DX_text_2.Text = d1 + d2;
        }

        private void Random2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] value = new int[10];
            string[] value2 = new string[10];

            for (int i = 0; i < value.Length; i++)
            {

                value[i] = random.Next(0, 255);

            }
            for (int j = 0; j < value.Length; j++)
            {
                if (value[j] < 16)
                {
                    value2[j] = "0" + Convert.ToString(value[j], 16).ToUpper();
                }
                else
                {
                    value2[j] = Convert.ToString(value[j], 16).ToUpper();
                }

            }

            string a1 = value2[0];
            string b1 = value2[1];
            string c1 = value2[2];
            string d1 = value2[3];
            string e1 = value2[4];
            string a2 = value2[5];
            string b2 = value2[6];
            string c2 = value2[7];
            string d2 = value2[8];
            string e2 = value2[9];

            SI_text.Text = a1 + a2;
            DI_text.Text = b1 + b2;
            BP_text.Text = c1 + c2;
            SP_text.Text = d1 + d2;
            DISP_text.Text = e1 + e2;


        }

        private void Mem_move_Click(object sender, EventArgs e)
        {
            if (Mem_To_Reg.Checked == true)
            {

            }
            if (Reg_To_Mem.Checked == true)
            {



            }
        }

        private void Mem_Xchg_Click(object sender, EventArgs e)
        {

        }
    }
}
