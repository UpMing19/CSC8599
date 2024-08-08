using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // 目标场景的名字或索引
    public string sceneName = "Vi"; // 替换为目标场景的名字
    // public int sceneIndex = 1; // 也可以使用场景索引来切换

    void Update()
    {
        // 检测按键是否按下，这里使用了 "space" 键
        if (Input.GetKeyDown(KeyCode.P))
        {
            // 加载目标场景
            SceneManager.LoadScene(sceneName);
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
