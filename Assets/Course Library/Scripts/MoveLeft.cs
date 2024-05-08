using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float speed = 10;
    private PlayerControls playerControlsScripts;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControlsScripts = GameObject.Find("Player").GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
       if (playerControlsScripts.doubleSpeed)
        {
            transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }


        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) 
        {
            Destroy(gameObject);
        }


    }
}
