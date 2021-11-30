/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public float xMargin = 0.1f;
    public float yMargin = 0.1f;
    public float xSmooth = 4f;
    public float ySmooth = 4f;
    public Vector2 maxXAndY;
    public Vector2 minXAndY;
    private Transform player;

    void Awake()
    {
        player=GameObject.FindGameObjectWithTag("Player").transform;
    }
    bool CheckXMargin()
    {
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }
    bool CheckYMargin()
    {
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }

   void FixedUpdate() 
   {
       TrackPlayer();
   }
   void TrackPlayer()
   {
    float targetX = transform.position.x;
    float targetY = transform.position.y;
    if(CheckXMargin())
        targetX=Mathf.Lerp(transform.position.x, player.position.x, xSmooth*Time.deltaTime);
    if(CheckYMargin())
        targetY=Mathf.Lerp(transform.position.y, player.position.y, ySmooth*Time.deltaTime);
        targetX=Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY=Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);
        transform.position=new Vector3(targetX, targetY, transform.position.z);
    }
} */
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

 public float MarginX = 0.5f;  
 public float MarginY = 0.5f;  
 public float SmoothX = 4f;  
 public float SmoothY = 4f; 
 public Vector2 MaxXAndY; 
 public Vector2 MinXAndY;

 private Transform player;

 void Awake () {
  player = GameObject.FindGameObjectWithTag("Player").transform;
 }

 bool CheckXMargin() {
  return Mathf.Abs(transform.position.x - player.position.x) > MarginX;
 }

 bool CheckYMargin() {
  return Mathf.Abs(transform.position.y - player.position.y) > MarginY;
 }

 void FixedUpdate () {
  TrackPlayer();
 }

 void TrackPlayer () {
  float targetX = transform.position.x;
  float targetY = transform.position.y;

  if(CheckXMargin())
   targetX = Mathf.Lerp(transform.position.x, player.position.x, SmoothX * Time.deltaTime);

  if(CheckYMargin())
   targetY = Mathf.Lerp(transform.position.y, player.position.y, SmoothY * Time.deltaTime);

  targetX = Mathf.Clamp(targetX, MinXAndY.x, MaxXAndY.x);
  targetY = Mathf.Clamp(targetY, MinXAndY.y, MaxXAndY.y);

  transform.position = new Vector3(targetX, targetY, transform.position.z);
 }
 
}
