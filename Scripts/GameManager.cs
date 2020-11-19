using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score;

    private CubeSpawner[] spawners;
    private int spawnerIndex;
    private CubeSpawner currentSpawner;

    private void Awake()
    {
        spawners = FindObjectsOfType<CubeSpawner>();
        score = 0;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (MovingCube.CurrentCube != null)
            {
                score++;
                MovingCube.CurrentCube.Stop();
            }
                
            spawnerIndex = spawnerIndex == 0 ? 1 : 0;
            currentSpawner = spawners[spawnerIndex];

            currentSpawner.CubeSpawn();

            scoreText.text = "Score : " + score;
        }
    }

}
