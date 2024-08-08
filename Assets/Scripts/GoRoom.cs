using UnityEngine;
using UnityEngine.SceneManagement;

public class GoRoom : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        /*if (pl != null)
        {
            Debug.Log("Have Foundd PlayerArmature");
        }*/

        // 检查是否与另一个游戏对象发生碰撞
        if (collision.gameObject.name.Equals("PlayerArmature"))
        {
            // 在这里编写切换场景的逻辑
            Debug.Log(" SwitchScene();");
            SwitchScene();
        }
    }


    private void SwitchScene()
    {
        // 加载新的场景
        SceneManager.LoadScene("Room"); // 将"NewScene"替换为你要切换到的场景名称
    }
}