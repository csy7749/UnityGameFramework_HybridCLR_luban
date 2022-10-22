using GameFramework;
using GameFramework.Event;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI��ͨ���¼�
/// </summary>
public class NormalUIEventArgs : GameEventArgs
{
    public static readonly int EventId = typeof(NormalUIEventArgs).GetHashCode();

    /// <summary>
    /// ��ʼ���򿪽���ʱ����������Դ�¼�����ʵ����
    /// </summary>
    public NormalUIEventArgs()
    {
        EventName = "";
        UserData = null;
    }

    /// <summary>
    /// ��ȡ�򿪽���ʱ����������Դ�¼���š�
    /// </summary>
    public override int Id
    {
        get
        {
            return EventId;
        }
    }

    /// <summary>
    /// ��ȡ�¼����ơ�
    /// </summary>
    public string EventName
    {
        get;
        private set;
    }

    /// <summary>
    /// ��ȡ�û��Զ������ݡ�
    /// </summary>
    public object UserData
    {
        get;
        private set;
    }

    /// <summary>
    /// �����򿪽���ʱ����������Դ�¼���
    /// </summary>
    /// <param name="e">�ڲ��¼���</param>
    /// <returns>�����Ĵ򿪽���ʱ����������Դ�¼���</returns>
    public static NormalUIEventArgs Create(string eventName,object userData = null)
    {
        NormalUIEventArgs normalUIEventArgs = ReferencePool.Acquire<NormalUIEventArgs>();
        normalUIEventArgs.EventName = eventName;
        normalUIEventArgs.UserData = userData;

        return normalUIEventArgs;
    }

    public override void Clear()
    {
        EventName = "";
    }
}
