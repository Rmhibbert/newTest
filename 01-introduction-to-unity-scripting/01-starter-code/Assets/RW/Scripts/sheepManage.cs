using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepManage : MonoBehaviour
{

    public GameObject sheepPrefab;
    public Transform sheepSpawnPoint;
    public float interval;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawner();
    }

    void spawner()
    {
        timer -= Time.deltaTime;
        if (timer > interval)
        {
            sheepJoin();
            timer = interval;
        }
    }

    private void sheepJoin()
    {
        Instantiate(sheepPrefab, sheepSpawnPoint.position, Quaternion.identity);
    }
}
