using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed = 0.1f; 
    public Renderer backgroundRenderer; // Renderer, not a float!

    void Update()
    {
        // Offsets the texture to create a scrolling effect
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
