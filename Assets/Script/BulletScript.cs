using UnityEngine;
using System.Collections;
public class BulletScript : MonoBehaviour {
	public int lifetime = 2;
	private float timer;
	void OnCollisionEnter2D(Collision2D target){ //cek tabrakan tanpa is trigger
		if (target.gameObject.tag=="Enemy"){ //jika tabrakan dgn enemy
			Destroy(target.gameObject); //hancurkan enemy tsb
		}
		Destroy (gameObject); //destroy diri sendiri
	}

	void Update(){
		timer += Time.deltaTime; //count waktu kemunculan
		if(timer > lifetime){ //bila sudah mencapai lifetime			
			timer = 0; //reset timer
			Destroy(gameObject); //hancurkan diri sendiri
		}
	}
}
