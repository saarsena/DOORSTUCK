using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    UIDocument document;

    private void OnEnable()
    {
        document = GetComponent<UIDocument>();

        if (document != null)
        {
            Debug.LogError("UIDocument document is equal to null");
        }
    }
}
