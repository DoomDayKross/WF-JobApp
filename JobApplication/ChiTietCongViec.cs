﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class ChiTietCongViec : Form
    {
        public ChiTietCongViec()
        {
            InitializeComponent();
        }
        int intImgNum = 0;
        private void tmrChangeImage_Tick(object sender, EventArgs e)
        {
            pbxCompanyAva.Image = imageListJobImage.Images[intImgNum];
            if (intImgNum == imageListJobImage.Images.Count -1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}