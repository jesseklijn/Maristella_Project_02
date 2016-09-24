using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public bool front = false, downForward = false;
    public bool isMoving = false;
    public int side = 1, //1,2,3,4,5,6
                direction = 1; //1,2,3,4
    public GameObject playerSphere;
    public GameObject cameraPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //rotate left
            rotateTable(true);
            isMoving = true;

        }
        else
           if (Input.GetKeyDown(KeyCode.D))
        {
            //rotate right
            rotateTable(false);
            isMoving = true;

        }
        else
           if (Input.GetKeyDown(KeyCode.W))
        {
            isMoving = true;
            if (downForward == true)
            {
                gameObject.transform.Translate(-1, 0, 0, Space.Self);
            }
            else if (downForward == false || front == false)
            {
                downTable();
                //gameObject.transform.Translate(-1, 0, 0, Space.Self);
            }

        }
        isMoving = false;
    }
    void downTable()
    {
        #region camera angles
        //1.1:(0,90,0) 1.1 -> 2.1
        //1.2:(0,0,0) 1.2 -> 6.1
        //1.3:(0,-90,0) 1.3 -> 4.3
        //1.4:(0,180,0) 1.4 -> 5.1

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
        #endregion

        #region if statements
        #region side1
        if (side == 1)
        {
            if (direction == 1)
            {
                side = 2; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(0, 90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y - 1, playerSphere.transform.position.z + 1);
            }
            else if (direction == 2)
            {
                side = 6; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(0, 0, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y - 1, playerSphere.transform.position.z);
            }
            else if (direction == 3)
            {
                side = 4; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(0, -90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y - 1, playerSphere.transform.position.z - 1);
            }
            else if (direction == 4)
            {
                side = 5; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(0, 180, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y - 1, playerSphere.transform.position.z);
            }
        }
        #endregion
        #region side2
        else if (side == 2)
        {
            if (direction == 1)
            {
                side = 3; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(180, -90, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y - 1, playerSphere.transform.position.z - 1);
            }
            else if (direction == 2)
            {
                side = 6; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(90, 0, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y, playerSphere.transform.position.z - 1);
            }
            else if (direction == 3)
            {
                side = 1; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(0, -90, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y + 1, playerSphere.transform.position.z - 1);
            }
            else if (direction == 4)
            {
                side = 5; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(-90, 180, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y, playerSphere.transform.position.z - 1);
            }
        }
        #endregion
        #region side3
        else if (side == 3)
        {
            if (direction == 1)
            {
                side = 2; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(180, 90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y + 1, playerSphere.transform.position.z + 1);
            }
            else if (direction == 2)
            {
                side = 6; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(180, 0, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y + 1, playerSphere.transform.position.z);
            }
            else if (direction == 3)
            {
                side = 4; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(180, -90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y + 1, playerSphere.transform.position.z - 1);
            }
            else if (direction == 4)
            {
                side = 5; direction = 3; cameraPanel.transform.eulerAngles = new Vector3(180, 180, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y + 1, playerSphere.transform.position.z);
            }
        }
        #endregion
        #region side4
        else if (side == 4)
        {
            if (direction == 1)
            {
                side = 1; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(0, 90, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y + 1, playerSphere.transform.position.z + 1);
            }
            else if (direction == 2)
            {
                side = 6; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(-90, 0, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y, playerSphere.transform.position.z + 1);
            }
            else if (direction == 3)
            {
                side = 3; direction = 1; cameraPanel.transform.eulerAngles = new Vector3(180, 90, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x, playerSphere.transform.position.y - 1, playerSphere.transform.position.z + 1);
            }
            else if (direction == 4)
            {
                side = 5; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(90, 180, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y, playerSphere.transform.position.z + 1);
            }

        }
        #endregion
        #region side5
        else if (side == 5)
        {
            if (direction == 1)
            {
                side = 3; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(180, 0, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y - 1, playerSphere.transform.position.z);
            }
            else if (direction == 2)
            {
                side = 2; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(90, 90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y, playerSphere.transform.position.z + 1);
            }
            else if (direction == 3)
            {
                side = 1; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(0, 0, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y + 1, playerSphere.transform.position.z);
            }
            else if (direction == 4)
            {
                side = 4; direction = 2; cameraPanel.transform.eulerAngles = new Vector3(-90, -90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x - 1, playerSphere.transform.position.y, playerSphere.transform.position.z - 1);
            }
        }
        #endregion
        #region side6
        else if (side == 6)
        {
            if (direction == 1)
            {
                side = 3; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(180, 180, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y - 1, playerSphere.transform.position.z);
            }
            else if (direction == 2)
            {
                side = 2; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(-90, 90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y, playerSphere.transform.position.z + 1);
            }
            else if (direction == 3)
            {
                side = 1; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(0, -180, 0);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y + 1, playerSphere.transform.position.z);
            }
            else if (direction == 4)
            {
                side = 4; direction = 4; cameraPanel.transform.eulerAngles = new Vector3(90, -90, 90);
                playerSphere.transform.position = new Vector3(playerSphere.transform.position.x + 1, playerSphere.transform.position.y, playerSphere.transform.position.z - 1);
            }
        }
        #endregion
    }
    void rotateTable(bool isLeft)
    {
        Vector3 vector3;
        if (side == 1)
        {
            if (direction == 1)
            {
                if (isLeft == true) { vector3 = new Vector3(0, 0, 0); direction = 2; }
                else { vector3 = new Vector3(0, 180, 0); direction = 4; }
                cameraPanel.transform.eulerAngles = vector3;

            }
            else if (direction == 2)
            {
                if (isLeft == true) { vector3 = new Vector3(0, 180, 0); direction = 3; }
                else { vector3 = new Vector3(180, -90, 0); direction = 3; }
                cameraPanel.transform.eulerAngles = vector3;
            }
            else if (direction == 3)
            {
                if (isLeft == true) { vector3 = new Vector3(0, 0, 0); direction = 3; }
                else { vector3 = new Vector3(180, -90, 0); direction = 3; }
                cameraPanel.transform.eulerAngles = vector3;
            }
            else if (direction == 4)
            {
                if (isLeft == true) { vector3 = new Vector3(0, 90, 0); direction = 3; }
                else { vector3 = new Vector3(180, -90, 0); direction = 3; }
                cameraPanel.transform.eulerAngles = vector3;
            }

        }

    }

    #endregion


}