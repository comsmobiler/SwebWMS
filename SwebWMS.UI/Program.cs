using Swebui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwebWMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SwebServer server = new SwebServer();
            server.StartUpForm = typeof(FrmLogon);
            //端口修改
            //server.Setting.HttpServerPort = 2380;
            server.SessionStart += new SwebSessionEventHandler(SwebGlobal.OnSessionStart);
            server.SessionStop += new SwebSessionEventHandler(SwebGlobal.OnSessionStop);
            server.SessionConnect += new SwebSessionEventHandler(SwebGlobal.OnSessionConnect);
            server.StartServer();
            SwebGlobal.OnServerStart(server);
            Console.WriteLine($"Swebui running at port {server.Setting.HttpServerPort}, any key to stop!");
            Console.ReadKey();
            SwebGlobal.OnServerStop(server);
        }
    }
}
