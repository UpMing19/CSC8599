using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DecreaseMask : MonoBehaviour
{


    private int mask = 0;

    [SerializeField] private Text maskText;
    private Text textField;
    // Start is called before the first frame update
    void Start()
    {
        textField = maskText;
        if (textField != null)
        {
            // 获取 Text 组件中的文本内容
            string text = textField.text;

            // 分割字符串
            string[] parts = text.Split(':');

            // 确保成功分割，检查数组长度是否为2
            if (parts.Length == 2)
            {
                // 提取数字部分
                string numberString = parts[1];

                // 尝试将字符串转换为整数
                if (int.TryParse(numberString, out int number))
                {
                    // 打印提取出的数字
                    Debug.Log("提取到的Mask数字是：" + number);
                    mask = number;
                }
                else
                {
                    Debug.LogError("无法将字符串转换为整数：" + numberString);
                }
            }
            else
            {
                Debug.LogError("无法解析字符串：" + text);
            }
        }
        else
        {
            Debug.LogError("Text 组件未分配！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        textField = maskText;
        if (textField != null)
        {
            // 获取 Text 组件中的文本内容
            string text = textField.text;

            // 分割字符串
            string[] parts = text.Split(':');

            // 确保成功分割，检查数组长度是否为2
            if (parts.Length == 2)
            {
                // 提取数字部分
                string numberString = parts[1];

                // 尝试将字符串转换为整数
                if (int.TryParse(numberString, out int number))
                {
                    // 打印提取出的数字
                    //    Debug.Log("提取到的Mask数字是：" + number);
                    mask = number;
                }
                else
                {
                    Debug.LogError("无法将字符串转换为整数：" + numberString);
                }
            }
            else
            {
                Debug.LogError("无法解析字符串：" + text);
            }
        }
        else
        {
            Debug.LogError("Text 组件未分配！");
        }
        if (mask < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("碰" + collision.gameObject);

        if (collision.gameObject.CompareTag("Older"))
        {

            Light spotlight = collision.gameObject.GetComponentInChildren<Light>();
            if (spotlight != null && spotlight.color == Color.green)
            {
                return;
            }
            Debug.Log("Older碰撞");
            // Destroy(collision.gameObject); // 如果需要销毁对象，可以取消注释

            if (spotlight != null)
            {
                //  Debug.Log("聚光灯改");
                spotlight.color = Color.green;  // 将红光变为绿光
            }
            else
            {
                Debug.Log("聚光灯空");
            }

            mask--;
            maskText.text = "Mask:" + mask;
        }
    }



}
