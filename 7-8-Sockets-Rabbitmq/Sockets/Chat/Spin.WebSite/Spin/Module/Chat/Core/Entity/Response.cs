using System;
using System.Collections;
using System.Collections.Generic;

namespace Spin.WebSite.Spin.Module.Chat.Core.Entity
{
    public class Response
    {
        public int CodeResponse { get; set; }
        public List<string> Message { get; set; }
        public string Name { get; set; }
    }
}
