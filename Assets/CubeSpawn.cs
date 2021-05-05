using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject obj = Instantiate(Box, new Vector2(worldPosition.x, worldPosition.y), Quaternion.identity);
        }
    }
 
}
