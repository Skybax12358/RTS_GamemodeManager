using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotChange : MonoBehaviour
{
    public GameObject Parent;
    public Text DefaultboxText;
    public string NewString;


    public void OnClick()
    {
        DefaultboxText.text = NewString;
    }
}