using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public GameObject cameraPanel;

    //1.1:(0,90,0) 1.1 -> 2.1
    //1.2:(0,0,0) 1.2 -> 6.1
    //1.3:(0,-90,0) 1.3 -> 3.4
    //1.4:(0,-180,0) 1.4 -> 5.1

    //2.1:(0,90,90) 2.1 -> 3.3
    //2.2:(90,90,90) 2.2 -> 6.4
    //2.3:(180,90,90) 2.3 -> 1.3
    //2.4:(-90,90,90) 2.4 -> 5.4

    //3.1:(180,90,0) 3.1 -> 2.3
    //3.2:(180,0,0)   3.2 -> 6.3
    //3.3:(180,-90,0) 3.3 -> 4.1
    //3.4:(180,180,0) 3.4 -> 5.3

    //4.1:(180,-90,90) 4.1 -> 1.1
    //4.2:(-90,-90,90) 4.2 -> 6.2
    //4.3:(0,-90,90)  4.3 -> 3.1
    //4.4:(90,-90,90) 4.4 -> 5.2

    //5.1:(0,180,90) 5.1 -> 3.2
    //5.2:(90,180,90) 5.2 -> 2.2
    //5.3:(180,180,90) 5.3 -> 1.2
    //5.4:(-90,180,90) 5.4 -> 4.2

    //6.1:(0,0,90) 6.1 -> 3.4
    //6.2:(-90,0,90) 6.2 -> 2.4
    //6.3:(180,0,90) 6.3 -> 1.4
    //6.4:(90,0,90) 6.4 -> 4.4




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        cameraPanel.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }
}
