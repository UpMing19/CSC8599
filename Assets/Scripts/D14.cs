using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class D14 : MonoBehaviour
{



    public GameObject dialogueBox;
    public Text dialogueText;
    // public string[] npcTexts = { "Hello, I'm a doctor here. I can tell you something about COVID-19 and how to prevent it. Would you like to hear it?",
    //  "Common symptoms of COVID-19 include fever, cough and fatigue. Severe cases can lead to breathing difficulties, pneumonia and even death",
    //  "You get one Mask successful...." };

    private string[] npcTexts = { "Hello, I'm a doctor here. I can tell you something about COVID-19 and how to prevent it. Would you like to hear it?",
    "Eat more healthy foods to stay strong and strengthen your immunity",
     "You have got a Mask successful!" };


    private int index = 0;
    private int end = 3;
    private int mask = 0;

    [SerializeField] private Text maskText;
    [SerializeField] private GameObject talkContainer;
    private Text textField;
    void Start()
    {
        dialogueBox.SetActive(false);
        // npcText = "Hello I am Doctor";
        index = 0;
        dialogueText.text = npcTexts[index];


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

    }
    public void Interact()
    {
        dialogueBox.SetActive(true);
    }


    public void Interact2()
    {
        dialogueBox.SetActive(false);
    }

    public void Interact3()
    {
        Debug.Log("Index = " + index);
        if (index == end - 1)
        {
            dialogueText.text = " You have got Mask from here ......";
        }
        else
        {
            index++;
            dialogueText.text = npcTexts[index];
            if (index == end - 1)
            {
                mask++;
                maskText.text = "Mask:" + mask;
            }
        }
    }


}
