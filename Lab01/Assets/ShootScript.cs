using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject BulletObject;
    public Vector2 Offset;
    public float FireTime = 0.0f;

    private void Update()
    {
        if (Time.time > this.FireTime)
        {
            this.FireTime = Time.time + (float)Random.Range(this.Offset.x, this.Offset.y);
            GameObject bulletClone = (GameObject)Instantiate(this.BulletObject, this.transform.position, this.transform.rotation);
        }
    }
}
