using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Yarn.Unity;

public class ConversationController : MonoBehaviour
{
    public float openDuration = 1;
    public float closeDuration = 1;
    
    public Vector3 openPos;
    public Vector3 closePos;

    void Start() {
        openPos = transform.position;
    }

    void Update() {
        if (Input.GetButtonDown("Fire1"))
            NextLine();
    }

    [ContextMenu("Test open")]
    public void OpenPanel() {
        transform.DOMoveX(openPos.x, 1);
    }

    [ContextMenu("Test close")]
    public void ClosePanel() {
        transform.DOMoveX(closePos.x, 1);
    }

    [ContextMenu("Print World Position")]
    public void PrintWorldPos() {
        print(transform.position);
    }

    [ContextMenu("Next line")]
    public void NextLine() {
        DialogueUI.Instance.MarkLineComplete();
    }
}
