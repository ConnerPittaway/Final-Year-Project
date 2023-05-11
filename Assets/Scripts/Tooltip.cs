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

    public RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        layoutElement.enabled = Math.Max(header.preferredWidth, content.preferredWidth) >= layoutElement.preferredWidth ? true : false;

        Vector2 mousePosition = Input.mousePosition;
        transform.position = mousePosition;
    }

    public void SetToolTipText(string contentText, string headerText)
    {
        header.text = headerText;
        content.text = contentText;
    }
}
