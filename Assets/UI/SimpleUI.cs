using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class SimpleUI : MonoBehaviour
{
    UIDocument btnDoc;
    Button atkBtn;
    Label consoleOut;

    private int fps;

    void OnEnable()
    {
        btnDoc = GetComponent<UIDocument>();

        if(btnDoc == null )
        {
            Debug.LogError("No button document found");
        }

        atkBtn = btnDoc.rootVisualElement.Q("LeftAttackButton") as Button;
        consoleOut = btnDoc.rootVisualElement.Q("Console") as Label;

        if (atkBtn != null)
        {
            Debug.Log("Button Found!");
        }

        atkBtn.RegisterCallback<ClickEvent>(OnButtonClick);
    }

    public void OnButtonClick(ClickEvent click)
    {
        consoleOut.text = "The Button has been clicked!";
    }

    void Start()
    {
        
    }

    void Update()
    {
        // Calculate the FPS value using Time.deltaTime
        //  fps = (int)(1f / Time.deltaTime);



        // Update the text value with the FPS value converted to string
        //consoleOut.text = fps.ToString();

    }
}
