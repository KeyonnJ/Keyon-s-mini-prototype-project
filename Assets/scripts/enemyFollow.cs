using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public GameObject player;
    public GameObject enemyPrefab;
    void Start()
    {



    }
    void Update()
    {
        // Calculate the step size for this frame
        float step = speed * Time.deltaTime;

        // Move the object closer to the target position
        //the code MoveTowards travels at a constant rate. 
        //theres also Vector3.Lerp, which slows down the gameobject as it gets closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    

}
