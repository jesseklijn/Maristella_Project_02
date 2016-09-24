using UnityEngine;
using System.Collections;

public class CollisionSensors : MonoBehaviour
{

    public GameObject player;
    PlayerMovement playerMovement;

    public enum Sensors
    {
        None,
        Front,
        DownForward
    };
    public Sensors sensor;



    // Use this for initialization
    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Block")
        {
            Debug.Log("Collision is geraakt: " + sensor.ToString());
            collider.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            if (sensor == Sensors.Front) { playerMovement.front = true; }
            if (sensor == Sensors.DownForward) { playerMovement.downForward = true; }
        }

    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Block")
        {
            Debug.Log("Collision is weg: " + sensor.ToString());
            collider.gameObject.GetComponent<Renderer>().material.color = Color.white;
            if (sensor == Sensors.Front) { playerMovement.front = false; }
            if (sensor == Sensors.DownForward) { playerMovement.downForward = false; }
        }
    }
}
