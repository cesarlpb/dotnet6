using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spin.Base.BaseController;
using Spin.Base.Socket;
using Spin.WebSite.Spin.Module.Chat.Core.Entity;
using Spin.Helper.Extend;
using System.Linq;

namespace Spin.WebSite.Spin.Module.Chat.Api.Controllers
{
    public class ChatWebSocketController : SpinControllerSocket
    {
        public static Dictionary<string, string> Names { get; set; } = new Dictionary<string, string>();

        public override Task Listen()
        {
            Names.Add(this.Key, this.Context.Request.Query["name"]);

            foreach (var ItemSocket in SpinWebSocketManager.InternalListSocket)
                SpinWebSocketManager.SendMessage(ItemSocket.Key,
                    (new Response()
                    {
                        CodeResponse = 100,
                        Message = Names.Where(a => a.Key != ItemSocket.Key).Select(a => a.Value).ToList()
                    }).ToSerializeJSON());

            return base.Listen();
        }

        public override string ReciveHandler(string Message)
        {
            Request Data = Message.ToDeserializeJSON<Request>();


            if (Names.ContainsValue(Data.Name))
            {
                var ItemSocket = Names.FirstOrDefault(a => a.Value == Data.Name);
                SpinWebSocketManager.SendMessage(ItemSocket.Key,
                    (new Response()
                    {
                        CodeResponse = 0,
                        Message = new List<string>() { Data.Message },
                        Name = ItemSocket.Value
                    }).ToSerializeJSON());
            }

            //this.Send($"{ Names[this.Key]} says:" + Message);
            return base.ReciveHandler(Message);
        }
    }
}
