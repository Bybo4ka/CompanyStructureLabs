﻿using System.Runtime.Serialization;

namespace TRPZ
{
    [DataContract]
    public abstract class Employee
    {
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public double Wage { get; set; }

    }
}