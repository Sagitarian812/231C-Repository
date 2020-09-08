using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerScript : MonoBehaviour
{
    public bool win;
    public bool lose;
    public GameObject winCanvas;
    public GameObject loseCanvas;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
           if (win == true)
            {
                winCanvas.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("WIN");
            }
           if (lose == true)
            {
                loseCanvas.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("LOSE");
            }
        }
    }
}
