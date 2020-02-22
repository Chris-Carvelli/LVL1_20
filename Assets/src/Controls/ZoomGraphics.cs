using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomGraphics : MonoBehaviour
{
    public float speed = 1;
    public Vector2 bounds;

    private Graphic[] _graphics;
    // Start is called before the first frame update
    void Start()
    {
        _graphics = GetComponents<Graphic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
            foreach (var graphic in _graphics) {
                float newScale = Mathf.Clamp(graphic.rectTransform.localScale.x + (Input.mouseScrollDelta.y * speed), bounds.x, bounds.y);
                graphic.rectTransform.localScale = Vector3.one * newScale;
            }
                
    }
}
