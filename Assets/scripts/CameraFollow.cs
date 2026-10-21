using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float camRotate = 1000.0f;
    public GameObject player;
    
    public GameObject Cam;
    private Vector3 offset = new Vector3(0.0f,2f,-4f);
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * -camRotate);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * -camRotate);
        }
    }
}
