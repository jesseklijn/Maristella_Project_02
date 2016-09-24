using UnityEngine;
using System.Collections;

public class CollisionBorderTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log(collider.gameObject.name + " / " + this.gameObject.GetComponent<Collider>().gameObject.name);

            collider.gameObject.transform.position = new Vector3(5, 6, 5);
            collider.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }

}
