using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float score;
    private PlayerControls PlayerControlsScripts;
    // Start is called before the first frame update
    void Start()
    {
        PlayerControlsScripts =
        GameObject.Find("Player").GetComponent<PlayerControls>();
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerControlsScripts.gameOver)
        {
            if(PlayerControlsScripts.doubleSpeed)
            {
                score += 2;
            }
            else
            {
                score++;
            }
            Debug.Log("Score: " + score);
        }

    }
}
