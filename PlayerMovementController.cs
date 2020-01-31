using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] GameObject playerModel;
    Animator anim;
    [SerializeField] float speed = 1f;

    void Awake()
    {
        anim = playerModel.GetComponent<Animator>();
    }

    void Start()
    {
        Debug.Log("PlayerMovementController script starting");
    }

    void Update()
    {
        anim.SetFloat("speed multiplier", speed);
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("walk", v);
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);

        float h = Input.GetAxis("Horizontal");
        anim.SetFloat("strafe", h);
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }

}
