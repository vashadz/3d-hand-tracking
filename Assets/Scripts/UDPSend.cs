using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class UDPSend : MonoBehaviour
{
    UdpClient client;
    public string serverIP = "127.0.0.1"; // localhost
    public int port = 5052;

    void Start()
    {
        client = new UdpClient();
    }

    void Update()
    {
        string data = "YourDataToSend";
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);
        client.Send(dataBytes, dataBytes.Length, serverIP, port);
    }

    void OnApplicationQuit()
    {
        client.Close();
    }
}
