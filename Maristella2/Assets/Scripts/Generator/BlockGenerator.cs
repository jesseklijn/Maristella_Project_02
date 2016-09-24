using UnityEngine;
using System.Collections;

public class BlockGenerator : MonoBehaviour
{

    #region variables

    //Prefabs)
    public GameObject borderBoxPrefab;
    public GameObject gridBoxPrefab;

    //Parent Object)
    public GameObject borderList;

    //Generator starting positions)
    public Vector3 startingPos = new Vector3(0, 0, 0);

    //Volume amount of the box, x,y,z)
    public int HeightAmount = 10, WidthAmount = 10, DepthAmount = 10;

    //Distance per cube)
    public int CubeDistanceHeight = 1, CubeDistanceWidth = 1, CubeDistanceDepth = 1;

    //For loop values)
    int x, y, z;
    #endregion

    //When the scene starts)
    void Start()
    {

        for (x = 0; x < WidthAmount; x++)
        {
            for (y = 0; y < HeightAmount; y++)
            {
                for (z = 0; z < DepthAmount; z++)
                {
                    //Initialize gameObject
                    GameObject gameObject = gridBoxPrefab;

                    //Do the math for positioning
                    gameObject.transform.position = new Vector3(startingPos.x + (CubeDistanceDepth * x), startingPos.y + (CubeDistanceHeight * y), startingPos.z + (CubeDistanceWidth * z));

                    //Change the name to remove '(clone)' And instantiate
                    if (y == 0 || y == HeightAmount - 1 || x == 0 || x == WidthAmount - 1 || z == 0 || z == DepthAmount - 1)
                    {
                        gameObject = (GameObject)Instantiate(borderBoxPrefab, gameObject.transform.position, Quaternion.identity, transform);
                        gameObject.name = "Border: " + ((startingPos.x + (CubeDistanceWidth * x)).ToString() + "/" + (startingPos.y + (CubeDistanceHeight * y)).ToString() + "/" + (startingPos.z + (CubeDistanceDepth * z)).ToString());
                    }
                    else
                    {
                        gameObject = (GameObject)Instantiate(gridBoxPrefab, gameObject.transform.position, Quaternion.identity, borderList.transform);
                        gameObject.name = "Grid: " + ((startingPos.x + (CubeDistanceWidth * x)).ToString() + "/" + (startingPos.y + (CubeDistanceHeight * y)).ToString() + "/" + (startingPos.z + (CubeDistanceDepth * z)).ToString());
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
