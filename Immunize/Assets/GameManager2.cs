using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class GameManager2 : MonoBehaviour
{
    // Having data sent and recieved in a seperate thread to the main game thread stops unity from freezing
    Thread IOThread = new Thread(DataThread);
    private static SerialPort sp;
    // If the serial port class does not exist open your NuGet package manager Project->Manage NuGet Packages->Browse and search for
    // Serial Port. Install System.IO.Ports by Microsoft

    // Stores any data that comes in via the serial port
    private static string incomingMsg = "";
    // Stores the data to be sent to the arduino via the serial port
    private static string outgoingMsg = "";


    private static GameManager2 _instance;
    public static GameManager2 Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is Null!");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this; //self referencing term to allow a script to address some part of itself or what it is attached to
    }

    private static void DataThread()
    {
        // Opens the serial port for reading and writing data
        sp = new SerialPort("COM3", 9600); // Alter the first value to be whatever port the arduino is connected to within the arduino IDE; Alter the second value to be the same as Serial.beign at the start of the arduino program
        sp.Open();

        // Every 200ms, it checks if there is a message stores in the output buffer string to be sent to the arduino,
        // Then recieves any data being sent to the project via the arduino 
        while (true)
        {
            if (outgoingMsg != "")
            {
                Debug.Log("outcoming test : " + outgoingMsg);
                sp.Write(outgoingMsg);
                outgoingMsg = "";
                
            }

            incomingMsg = sp.ReadExisting();
            Thread.Sleep(200);
        }
    }

    private void OnDestroy()
    {
        // Closes the thread and serial port when the game ends
        IOThread.Abort();
        sp.Close();
    }

    // Start is called before the first frame update
    void Start()
    {
        IOThread.Start();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (incomingMsg != "")
        {
            Debug.Log(incomingMsg);
        }*/

        //heat pad, heat lowers with less bacteria
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
       

        if (gameObjects.Length == 4)
            outgoingMsg = "4";
        else if (gameObjects.Length == 3)
            outgoingMsg = "3";
        else if (gameObjects.Length == 2)
            outgoingMsg = "2";
        else if (gameObjects.Length == 1)
            outgoingMsg = "1";
        else if (gameObjects.Length == 0)
            outgoingMsg = "0";

        Debug.Log(outgoingMsg);
    }

    public void Vibrate()
    {
        Debug.Log("test");
        outgoingMsg = "5";
        sp.Write(outgoingMsg);
        Debug.Log("value after vibrate : " + outgoingMsg);
    }
}




