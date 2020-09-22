using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScaler : MonoBehaviour
{
    [SerializeField]  GameObject[] trackingObjects;
    Vector3 upperLeft;
    Vector3 upperRight;
    Vector3 lowerLeft;
    Vector3 lowerRight;
    // Start is called before the first frame update
    void Start()
    {
         upperLeft = trackingObjects[3].transform.position;
         upperRight = trackingObjects[2].transform.position;
         lowerLeft = trackingObjects[0].transform.position;
         lowerRight = trackingObjects[1].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var x = lowerRight.x - upperLeft.x;
        var y = upperLeft.y - lowerRight.y;
        transform.position= new Vector3((upperRight.x+upperLeft.x)/2,(upperLeft.y+lowerLeft.y)/2,transform.position.z);
        transform.localScale = new Vector3((upperRight.x - upperLeft.x), (upperLeft.y - lowerLeft.y),1);

    }
}
