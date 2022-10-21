using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour
{
    public float startingOffset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Mathf.Sin((Time.time) - (Mathf.PI/2f) + 2f*Mathf.PI - 2f*Mathf.PI*(startingOffset / 10f)) + 1, 0, 0);
    }
}
