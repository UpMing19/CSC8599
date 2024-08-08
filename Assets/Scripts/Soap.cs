using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soap : MonoBehaviour
{
    private int soap = 0;

    [SerializeField] private Text soapText;
    private Text textField;
    // Start is called before the first frame update
    void Start()
    {
        textField = soapText;
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
                    Debug.Log("提取到的Soap数字是：" + number);
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

    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Triggered with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("soap"))
        {
            Debug.Log("Soap detected");
            Destroy(collision.gameObject);
            soap++;
            soapText.text = "SoapDispenser:" + soap;
        }
    }

}
