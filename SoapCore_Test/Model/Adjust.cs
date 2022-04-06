using System.Runtime.Serialization;

namespace SoapCore_Test.Model
{
    public class Adjust
    {
        [DataMember]
        public int? FirstID { get; set; }

        [DataMember]
        public int? SecondID { get; set; }

        [DataMember]
        public int? ThirdID { get; set; }

    }
}
