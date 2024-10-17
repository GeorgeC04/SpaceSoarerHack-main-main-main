using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    public float rockSpeed = 1.0f;   // Speed at which rocks move from right to left
    private float offset;
    private Material mat;
    private float distanceMoved = 0f;
    public float spawnDistance = 10f;
 
 
    void Start()
    {
        mat = GetComponent<Renderer>().material;
 
    }
 
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
 
        distanceMoved += Time.deltaTime * scrollSpeed * 10f;
 
 
    }
 
 
 
 
}