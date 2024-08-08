using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TVGo : MonoBehaviour
{
    
    void Update()
    {
        // 检测按键是否按下，这里使用了 "space" 键
        if (Input.GetKeyDown(KeyCode.P))
        {
            // 加载目标场景
            SceneManager.LoadScene("Vi");
            // SceneManager.LoadScene(sceneIndex); // 或者使用场景索引
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 加载目标场景
            SceneManager.LoadScene("Room");
            // SceneManager.LoadScene(sceneIndex); // 或者使用场景索引
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // 加载目标场景
            SceneManager.LoadScene("Street");
            // SceneManager.LoadScene(sceneIndex); // 或者使用场景索引
        }
    }
}
