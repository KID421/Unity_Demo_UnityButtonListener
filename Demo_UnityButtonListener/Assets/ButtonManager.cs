using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button btnA;
    public Button btnB;

    private void Awake()
    {
        btnA.onClick.AddListener(Print);
        btnB.onClick.AddListener(() => { print("匿名函式~"); });
    }

    private void Print()
    {
        print("嗨，我是輸出方法~");
    }
}
