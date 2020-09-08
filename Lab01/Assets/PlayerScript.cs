using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            GameOver();
        }
    }
   public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("GAMEOVER");
    }
}
