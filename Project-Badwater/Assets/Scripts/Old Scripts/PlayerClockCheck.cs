using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClockCheck : MonoBehaviour
{
    public bool hasClock;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
