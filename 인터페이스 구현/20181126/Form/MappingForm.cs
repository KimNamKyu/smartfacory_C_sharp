﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181123
{
    public partial class MappingForm : Form
    {
        private object oDB;

        public MappingForm(Object oDB)
        {
            InitializeComponent();
            Load load = new Load(this, oDB);
            Load += load.GetHandler("mapping");
        }

    }
}
