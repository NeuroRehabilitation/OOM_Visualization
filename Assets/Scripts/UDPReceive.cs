using UnityEngine;
using System.Collections;

using System;
using System.Globalization;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPReceive : MonoBehaviour
{

    // receiving Thread
    Thread receiveThread;

    // udpclient object
    UdpClient client;

    // public
    // public string IP = "127.0.0.1"; default local
    public int port; // define > init

    public Quaternion Rotation;
    char[] delimiterChars = { ',', '(', ')',' '};

    // start from unity3d
    public void Start()
    {
        init();
    }

    // init
    private void init()
    {
        // define port
        port = 1202;


        receiveThread = new Thread(ReceiveData);
        receiveThread.IsBackground = true;
        receiveThread.Start();

    }

    // receive thread
    private void ReceiveData()
    {

        client = new UdpClient(port);
        while (true)
        {

            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = client.Receive(ref anyIP);

                string text = Encoding.UTF8.GetString(data);

                string[] words = text.Split(delimiterChars);
                //Debug.Log(words[1] + " " + words[3]+" " + words[5]);
                
                print(">> " + text);

                Rotation.x = float.Parse(words[1], CultureInfo.InvariantCulture.NumberFormat);
                Rotation.y = float.Parse(words[3], CultureInfo.InvariantCulture.NumberFormat);
                Rotation.z = float.Parse(words[5], CultureInfo.InvariantCulture.NumberFormat);
                Rotation.w = float.Parse(words[7], CultureInfo.InvariantCulture.NumberFormat);
                //allReceivedUDPPackets = allReceivedUDPPackets + text;

            }
            catch (Exception err)
            {
                print(err.ToString());
            }
        }
    }

    private void OnApplicationQuit()
    {
        if (receiveThread != null)
        {
            receiveThread.Abort();
            client.Close();
        }
    }
}

