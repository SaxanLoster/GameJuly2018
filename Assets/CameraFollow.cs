using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

  public Transform player;
  private Vector3 offset = new Vector3( 0f , 2f , -10f );

  void Start () {
    
  }

  void Update () {
    transform.position = player.position + offset;
    }
  }