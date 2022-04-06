using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapCore_Test.Model
{
    [DataContract]
    //[DataContract(Namespace = "CalculatorRequest")]
    public class CalculatorRequest
    {
        [DataMember]
        public AdvancedKeys Keys { get; set; }
        [DataMember]
        public string ProfileType { get; set; }
        [DataMember]
        public Adjust Adjustment { get; set; }
        [DataMember]
        public Gender? Gender { get; set; }
        [DataMember]
        public DateTime? DateOfBirth { get; set; }
    }
}
