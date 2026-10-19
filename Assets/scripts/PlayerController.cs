using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //make a variable to use throughout your project
    public float horizontalInput;
    public float forwardInput;
    //identify your player throughout different scripts
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.left * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
       /*
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        transform.Translate(Vector3.back * Time.deltaTime * verticalInput);
        */
    }
}
