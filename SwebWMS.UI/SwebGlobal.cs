using Swebui;
using SwebWMS.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 全局类
/// </summary>
public class SwebGlobal
{
    //设置成类库后，原来Main中需要调用的方法放到SwebGlobal的静态构造函数中执行
    static SwebGlobal()
    {
AutomapperConfig.Init();
    }

    /// <summary>
    /// 在服务启动时触发
    /// </summary>
    /// <param name="server"></param>
    public static void OnServerStart(SwebServer server)
    {
      

    }
    /// <summary>
    /// 在服务停止时触发
    /// </summary>
    /// <param name="server"></param>
    public static void OnServerStop(SwebServer server)
    {

    }

    /// <summary>
    /// 在会话第一次开始时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionStart(object sender, SwebSessionEventArgs e)
    {
    }

    /// <summary>
    /// 在会话结束时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionStop(object sender, SwebSessionEventArgs e)
    {

    }
    /// <summary>
    /// 在会话重新连接时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionConnect(object sender, SwebSessionEventArgs e)
    {
        e.Client.ReStart();
    }
}

