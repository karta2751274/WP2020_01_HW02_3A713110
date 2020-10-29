using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP2020_01_HW02_3A713110.Properties;

namespace WP2020_01_HW02_3A713110
{
   
    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();
        public frmGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int index = 3;//模擬隨機產生 一個值;
            picResult.Image = list[index];
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            list.Add(Resources._001);
            list.Add(Resources._002);
            list.Add(Resources._003);
      
        }

        private void picResult_Click(object sender, EventArgs e)
        {

        }
    }
}
