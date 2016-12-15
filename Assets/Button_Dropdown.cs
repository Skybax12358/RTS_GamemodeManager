using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class Button_Dropdown : MonoBehaviour
{
    public static Button_Dropdown Instance;

    public RectTransform Container;
    public bool isOpen;

    void Awake()
        {
        Instance = this;
        }
   

    // Use this for initialization
    void Start()
    {
            Container = transform.FindChild("Container").GetComponent<RectTransform>();
            isOpen = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isOpen)
        {
            //open dropdown
            Vector3 scale = Container.localScale;
            scale.y = Mathf.Lerp(scale.y, -1, Time.deltaTime * 12);
            Container.localScale = scale;
        }
        else
        {
            //close it
            Vector3 scale = Container.localScale;
            scale.y = Mathf.Lerp(scale.y, 0, Time.deltaTime * 12);
            Container.localScale = scale;
        }
    }

    //close the menu
   public void OnClick()
    {
        if (!isOpen)
            isOpen = true;
        else if (isOpen)
            isOpen = false;
    }

    

  
}
