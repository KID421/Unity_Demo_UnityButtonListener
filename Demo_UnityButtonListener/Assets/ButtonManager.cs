using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button btnA;
    public Button btnB;

    private void Awake()
    {
        btnA.onClick.AddListener(Print);
        btnB.onClick.AddListener(() => { print("�ΦW�禡~"); });
    }

    private void Print()
    {
        print("�١A�ڬO��X��k~");
    }
}
