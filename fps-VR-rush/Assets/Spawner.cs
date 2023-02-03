using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Vector3> all_pos;
    public GameObject cible;
    private float time_atm;

    void Start()
    {
        time_atm = Time.time;
    }

    void Update()
    {
        if (Time.time - time_atm >= 1F) {
            time_atm = Time.time;
            all_pos.Add(new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)));
            all_pos.Reverse();
            Instantiate(cible, all_pos[0], Quaternion.identity);
            all_pos.Reverse();
        }
    }
}
