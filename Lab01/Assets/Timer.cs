using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text counterText;
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        counterText.text =seconds.ToString("f2");

        if(seconds == 10)
        {
            GameWin();
        }
    }

    private void GameWin()
    {
        Time.timeScale = 0f;
    }
}
