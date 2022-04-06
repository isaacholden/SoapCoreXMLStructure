using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapCore_Test.Model
{
    public class AdvancedKeys
    {
        [DataMember]
        public int? MoneyOne { get; set; }
        [DataMember]
        public int? TestMoney { get; set; }
        [DataMember]
        public int? Lot { get; set; }
        [IgnoreDataMember]
        public int Total { get; }
    }
}
