using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI header, content;
    public LayoutElement layoutElement;
    public int characterWrapLimit;

    private void Update()
    {
        int headerLength = header.text.Length;
        int contentLength = content.text.Length;

        if(headerLength > characterWrapLimit || contentLength > characterWrapLimit)
        {
            layoutElement.enabled = false;
        }
        else
        {
            layoutElement.enabled = true;
        }
    }
}
