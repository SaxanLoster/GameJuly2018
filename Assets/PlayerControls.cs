using UnityEngine;
using System;
using System.Collections;

public class PlayerControls : MonoBehaviour {

  private float moveSpeed = 10f;
  private bool mousemoved = false;
  private float moveX = 0;
  private float moveY = 0;
  public Rigidbody rb;

  void Start () {}

  void OnGUI () {
    Event ev = Event.current;
    if (ev.type == EventType.MouseUp) {
      moveX = 0;
      moveY = 0;
      mousemoved = false;
      }
    else if ( !mousemoved && ev.type == EventType.MouseDrag ) {
      moveX = ev.delta[ 0 ] != 0 ? ( ev.delta[ 0 ] > 0 ? 1 : -1 ) : 0;
      moveY = ev.delta[ 1 ] != 0 ? ( ev.delta[ 1 ] > 0 ? 1 : -1 ) : 0;
      mousemoved = true;
      }
    }

  void FixedUpdate () {
    float transX = 0f;
    float transY = 0f;
    float transZ = 0f;
    if ( moveX != 0 ) transX = moveSpeed * moveX * Time.deltaTime;
    if ( moveY != 0 ) transY = moveSpeed * moveY * Time.deltaTime;
    transZ = moveSpeed * Time.deltaTime;
    transform.Translate( transX , transY , transZ );
    }

  void Update () {}

  }