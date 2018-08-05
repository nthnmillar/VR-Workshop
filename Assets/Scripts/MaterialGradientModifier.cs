using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class MaterialGradientModifier : MonoBehaviour
{
    Renderer _renderer;

    // public Color myColor;
    [SerializeField] Gradient gradient;

    float gradientPosition;
    void SetGradientPosition(float position)
    {
        if (position == gradientPosition)
            return;
        gradientPosition = position;

        _renderer.material.color = gradient.Evaluate(gradientPosition);		
    }

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Use this for initialization
    void Start ()
    {
        SetGradientPosition(0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        SetGradientPosition(Mathf.Sin ((Time.time) * 0.5f) + 0.5f);
	}
}
