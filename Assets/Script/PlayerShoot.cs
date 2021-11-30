using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerShoot : MonoBehaviour
{
    public float shootSpeed, shootTimer;
    public int maxAmmo;
    
    private bool isShooting;
    private int currentAmmo;

    public Transform shootPos;
    public GameObject bullet;

    public TextMeshProUGUI ammoText;


    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !isShooting && currentAmmo > 0)
        {
            StartCoroutine(Shoot());
            currentAmmo--;
            ammoText.text =  currentAmmo.ToString();
        }
    }

    IEnumerator Shoot()
{
    
        int direction()
        {
            if(transform.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            } 
        }
    
    isShooting = true;
    GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
    newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * direction() * Time.fixedDeltaTime, 0f);
    newBullet.transform.localScale = new Vector2(newBullet.transform.localScale.x * direction(), newBullet.transform.localScale.y); 
    yield return new WaitForSeconds(shootTimer);
    isShooting = false;
}
}


