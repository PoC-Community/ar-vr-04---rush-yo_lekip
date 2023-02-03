using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_and_destroy : MonoBehaviour
{
    public int Score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Destroy(gameObject, 0);
    }
}
