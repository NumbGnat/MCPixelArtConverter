﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPixelArtConverter
{
    public partial class MCTextureShower : Form
    {
        public MCTextureShower()
        {
            InitializeComponent();
        }

        public void setImage(Bitmap image)
        {
            pictureBox1.Image = image;
        }
    }
}
