using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject RedBorder;
    public GameObject Woodman;
    bool isCreated;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Woodman.transform.position == new Vector3(0, 0 ,0) & !isCreated) {
            Instantiate(RedBorder, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(RedBorder, 0.5f);
            isCreated = true;
        }
     
    }
}
