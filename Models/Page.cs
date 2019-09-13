

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace sorteio.models
{
    [DataContract]
    public class Page
    {
        [DataMember(Name = "number")]
        public int Number { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        [DataMember(Name = "total")]
        public int Total { get; set; }

        [DataMember(Name = "paged")]
        public bool Paged { get; set; }

        [DataMember(Name = "first")]
        public bool First { get; set; }

        [DataMember(Name = "last")]
        public bool Last { get; set; }

        [DataMember(Name = "limits")]
        public List<int> Limits { get; }
        public Page()
        {
            this.Limits = PageRequest.PageLimits;
        }
    }

}

