﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Il2CppDumper
{
    class Config
    {
        public bool dumpmethod = true;
        public bool dumpfield = true;
        public bool dumpproperty = false;
        public bool dumpattribute = false;
        public bool dumpfieldoffset = true;
        public bool forceil2cppversion = false;
        public int forceversion = 16;
    }
}
