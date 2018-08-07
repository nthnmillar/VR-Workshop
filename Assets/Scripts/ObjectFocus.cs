using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFocus : MonoBehaviour
{
    [SerializeField] Transform referance;

    private float _fadeAmount;
    public float fadeAmount
    {
        get { return _fadeAmount; }
        set
        {
            if (value != _fadeAmount)
            {
                _fadeAmount = value;
            }
        }
    }

	void Awake ()
    {
        //  referance = GameObject.FindGameObjectWithTag("MainCamera").transform;
        if (!referance)
           referance = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
