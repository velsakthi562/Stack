using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private MovingCube cubePrefab;




    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void CubeSpawn()
    {
        var cube = Instantiate(cubePrefab);

    }
}
