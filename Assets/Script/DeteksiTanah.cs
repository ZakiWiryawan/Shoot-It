using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteksiTanah : MonoBehaviour
{
    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);
        
    }
}
