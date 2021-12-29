﻿using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
