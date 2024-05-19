using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeSpawn = 0.5f;
    private float defaultTimeSpawn;

    void Start ()
    {
        defaultTimeSpawn = timeSpawn;
        timeSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime;
        if(timeSpawn < 0)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeSpawn = defaultTimeSpawn;
            }
        }
    }
}
