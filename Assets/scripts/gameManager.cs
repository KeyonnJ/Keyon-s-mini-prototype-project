using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPrefab;
    public GameObject Enemy;
    public float Timer;
    // Start is called before the first frame update
     void Start()
    {
        //an independent method that runs without interrupting the main game.
        // this code starts it, and it runs multiple frames without affecting the main game loop.
        StartCoroutine(LogTimeCoroutine());
    }
    //Enumerator allows you to use time stamps within the code/game. 
    IEnumerator LogTimeCoroutine()
    {
        while (true)
        {
            //debug.log displays a message within the console in unity
            //Time.time is just a timer. specifically runs in decimals(float)
            Debug.Log("you survived for " + Time.time +" seconds.");
            if(player.gameObject == null)
            {
                Debug.Log("ggs");
            }
            

            //how many seconds this code waits before playing again(within the () shown below, 1f
            yield return new WaitForSeconds(1f);
        }
    }
    // Update is called once per frame
    void Update()
    {


    }
    void LateUpdate()
    {/*
        if(Enemy.CompareTag("Enemy") == null)
        {
            Instantiate(enemyPrefab, new Vector3(5f, 0f, 10f), Transform.rotation(0,0,0));
        }*/
    }
    
}
