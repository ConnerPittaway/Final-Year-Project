using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

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

        layoutElement.enabled = Math.Max(header.preferredWidth, content.preferredWidth) >= layoutElement.preferredWidth ? true : false;
    }
}
