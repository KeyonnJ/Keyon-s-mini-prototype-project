using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerFreeze : MonoBehaviour
{
    public float Timer;
    public float elapsedTime = 0f;
    private bool isTimerRunning = true;
    public GameObject player;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        CheckCollision(collision.gameObject);

    }
    private void CheckCollision(GameObject hitObject)
    {
                // Check if the collision involves the target objects
        if (hitObject.CompareTag("Player") || hitObject.CompareTag("Enemy"))
        {
            isTimerRunning = false; // Freezes the timer
        }

    }
}
