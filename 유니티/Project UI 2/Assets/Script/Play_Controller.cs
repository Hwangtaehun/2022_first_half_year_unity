using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move_Left()
    {
        transform.Translate(1.0f, 0.0f, 0.0f);
    }
}
