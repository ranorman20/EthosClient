﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EthosClient.EthosInput
{
    public class EthosKeybind
    {
        public EthosFeature Target { get; set; }

        public KeyCode FirstKey { get; set; }

        public KeyCode SecondKey { get; set; }

        public bool MultipleKeys = false;
    }
}
