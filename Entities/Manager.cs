﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TRPZ
{
    [DataContract]
    class Manager : Employee, ICommandable, ICommander
    {
        [DataMember]
        public List<ICommandable> DirectSubordinates { get; set; }

        public Manager()
        {
            DirectSubordinates = new List<ICommandable>();
        }
        public void AddSubordinate(ICommandable subordinate)
        {
            if(subordinate!=null) DirectSubordinates.Add(subordinate);
        }
    }
}