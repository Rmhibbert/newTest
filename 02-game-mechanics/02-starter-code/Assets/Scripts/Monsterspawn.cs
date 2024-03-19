using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsterspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject MonsterPrefab;
    private GameObject placedMonster = null;
    void OnMouseUp()
    {
        if (placedMonster == null)
        {
            placedMonster = Instantiate(MonsterPrefab, transform.position, Quaternion.identity);
        }
        
    }
}
