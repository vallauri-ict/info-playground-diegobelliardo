﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaccia
{
    internal class Tromba:Strumento
    {
        public override void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Sono una tromba che suona");
        }
    }
}
