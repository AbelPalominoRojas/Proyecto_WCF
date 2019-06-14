using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Sise.WcfService.Entity
{
    [DataContract]
    public class Response<T>
    {
        [DataMember]
        public bool IsSuccess { get; set; } = false;
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string MessageDev { get; set; }
        [DataMember]
        public List<T> Items { get; set; }
        [DataMember]
        public T Item { get; set; }
    }
}