using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BlackScreen : MonoBehaviour
{
    BlackScreen blackscreen;
    float timer = 2f;

    void Awake()
    {
        blackscreen = GameObject.FindGameObjectWithTag("T_Timer").GetComponent<BlackScreen>();   
    }

    void Update()
    {
        print(timer);
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SceneManager.LoadScene("Scene1");
        }
    }

}
