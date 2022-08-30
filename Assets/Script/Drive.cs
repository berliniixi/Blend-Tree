using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {

    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 100.0f;
    [SerializeField] private float currentSpeed = 0f;
    Animator anim;

    void Start() {

        anim = GetComponent<Animator>();
    }
    
    void Update() {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        currentSpeed += translation;
        anim.SetFloat("Speed" , currentSpeed);
        transform.Rotate(0.0f, rotation, 0.0f);

        if(translation != 0) {

            anim.SetBool("isWalking", true);
        } else {

            anim.SetBool("isWalking", false);
        }
    }
}
