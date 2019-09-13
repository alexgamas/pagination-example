using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace sorteio.controller.viewmodels
{
    [DataContract]
    public class SearchAreaResponse
    {

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        public SearchAreaResponse() { }

        public SearchAreaResponse(long Id, string Name) : this()
        {
            this.Id = Id;
            this.Name = Name;
        }

    }

}
