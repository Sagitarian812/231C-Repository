using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    public float speed =10f;
    public float lifeTimer = 2f;
    PlayerScript Player;

    private void Start()
    {
        Player = gameObject.GetComponent<PlayerScript>();
    }
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Bullet was destroyed");
            GameOver();
        }
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("GAMEOVER");
    }
}
