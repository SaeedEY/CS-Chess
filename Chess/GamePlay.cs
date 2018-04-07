using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class GamePlay : Form
    {
        private PlayChess chess;
        private Vectors vectors;
        private PictureBox[][] table;
        private bool hasStarted = false;
        public GamePlay(string name)
        {
            InitializeComponent();
            vectors = new Vectors();
            chess = new PlayChess();
            chess.setPlayerName(name);
            gp_stat.Text = name;
            table = new PictureBox[8][];
            table[0] = new PictureBox[8];
            table[1] = new PictureBox[8];
            table[2] = new PictureBox[8];
            table[3] = new PictureBox[8];
            table[4] = new PictureBox[8];
            table[5] = new PictureBox[8];
            table[6] = new PictureBox[8];
            table[7] = new PictureBox[8];
            Defination();
        }
        private void Defination()
        {
            table[0][0] = box_a1;
            table[0][1] = box_a2;
            table[0][2] = box_a3;
            table[0][3] = box_a4;
            table[0][4] = box_a5;
            table[0][5] = box_a6;
            table[0][6] = box_a7;
            table[0][7] = box_a8;
            table[1][0] = box_b1;
            table[1][1] = box_b2;
            table[1][2] = box_b3;
            table[1][3] = box_b4;
            table[1][4] = box_b5;
            table[1][5] = box_b6;
            table[1][6] = box_b7;
            table[1][7] = box_b8;
            table[2][0] = box_c1;
            table[2][1] = box_c2;
            table[2][2] = box_c3;
            table[2][3] = box_c4;
            table[2][4] = box_c5;
            table[2][5] = box_c6;
            table[2][6] = box_c7;
            table[2][7] = box_c8;
            table[3][0] = box_d1;
            table[3][1] = box_d2;
            table[3][2] = box_d3;
            table[3][3] = box_d4;
            table[3][4] = box_d5;
            table[3][5] = box_d6;
            table[3][6] = box_d7;
            table[3][7] = box_d8;
            table[4][0] = box_e1;
            table[4][1] = box_e2;
            table[4][2] = box_e3;
            table[4][3] = box_e4;
            table[4][4] = box_e5;
            table[4][5] = box_e6;
            table[4][6] = box_e7;
            table[4][7] = box_e8;
            table[5][0] = box_f1;
            table[5][1] = box_f2;
            table[5][2] = box_f3;
            table[5][3] = box_f4;
            table[5][4] = box_f5;
            table[5][5] = box_f6;
            table[5][6] = box_f7;
            table[5][7] = box_f8;
            table[6][0] = box_g1;
            table[6][1] = box_g2;
            table[6][2] = box_g3;
            table[6][3] = box_g4;
            table[6][4] = box_g5;
            table[6][5] = box_g6;
            table[6][6] = box_g7;
            table[6][7] = box_g8;
            table[7][0] = box_h1;
            table[7][1] = box_h2;
            table[7][2] = box_h3;
            table[7][3] = box_h4;
            table[7][4] = box_h5;
            table[7][5] = box_h6;
            table[7][6] = box_h7;
            table[7][7] = box_h8;
        }
        private void onStart()
        {
            lbl_color.Text = chess.getColorName();
            gp_color.Enabled = false;
            btn_str.Text = "Stop";
            hasStarted = true;
            vectors.onStart(chess.getColor());
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    table[i][j].Image = vectors.getTable()[i][j];
                }
            }
        }
        private void onStop()
        {
            lbl_color.Text = "";
            gp_color.Enabled = true;
            btn_str.Text = "Start";
            hasStarted = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i][j].Image = vectors.emptyImage();
                }
            }
        }
        private void rd_bk_CheckedChanged(object sender, EventArgs e)
        {
            chess.setColor(1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            if (hasStarted)
                onStop();
            else
                onStart();
        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            if (hasStarted)
                onStop();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gp_color_EnabledChanged(object sender, EventArgs e)
        {
          
        }

        private void rd_wt_CheckedChanged(object sender, EventArgs e)
        {
            chess.setColor(0);
        }
    }
}
