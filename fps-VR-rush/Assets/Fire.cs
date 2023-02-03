using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform SpawnPoint;
    public float BulletSpeed = 5F;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    void Update()
    {

    }

    public void FireBullet(ActivateEventArgs args)
    {
        GameObject new_bullet = Instantiate(bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        new_bullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 10);
        Destroy(new_bullet, 7F);
    }
}
