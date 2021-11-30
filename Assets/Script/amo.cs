using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amo : MonoBehaviour
{
   
    gerak KomponenGerak; // Variabel gerak dan Semua komponennya di Script Gerak
    // Start is called before the first frame update
    void Start()
    {
        KomponenGerak = GameObject.Find("Player").GetComponent<gerak>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Fungsi ketika Player menyentuh Amo
    void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "Player")
        {
            KomponenGerak.Amo+=10; //TAmbahkan Nilai +10 ke Variabel Amo
            Destroy(gameObject);
        }
    }
}
