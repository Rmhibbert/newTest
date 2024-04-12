using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;
    public GameObject hay;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * -speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider hay)
    {
        Destroy(gameObject);
    }


}
