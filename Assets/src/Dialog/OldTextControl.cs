using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class OldTextControl : MonoBehaviour
{
    public Text currentDialog;

    private Text _text;

    void Start () {
        _text = GetComponent<Text>();
        ClearText();
    }

    public void FetchText() {
        _text.text += currentDialog.text;
    }

    public void ClearText() {
        _text.text = "";
    }
}
