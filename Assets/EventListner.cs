using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListner : MonoBehaviour
{
    public Renderer _renderer;

    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer> ();
    }

    public void Colorchange()
    {
        if (_renderer.material.color == Color.white)
            _renderer.material.color = Color.red;
        else
            _renderer.material.color = Color.white;
    }

    public void dest()
    {
        Destroy(gameObject);
    }
}
