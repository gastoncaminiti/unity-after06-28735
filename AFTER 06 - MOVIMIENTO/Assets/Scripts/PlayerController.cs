using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float speed;
   [SerializeField] float speedRotation = 10f;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);\

        }
        */
        MovePlayerAxis();
        RotatePlayerAxis();
    }

    private void MovePlayer(Vector3 direction){
        transform.Translate(speed * direction * Time.deltaTime);
    }

    private void MovePlayerAxis(){
        float vAxis =Input.GetAxisRaw("Vertical");
        Debug.Log(vAxis);
        transform.Translate(speed * new Vector3(0,0,-vAxis) * Time.deltaTime);
    }

    private void RotatePlayerAxis(){
        float hAxis =Input.GetAxisRaw("Horizontal");
        Debug.Log(hAxis);
        transform.Rotate(Vector3.up, hAxis * speedRotation * Time.deltaTime);
       // transform.Translate(speed * new Vector3(0,0,haxis) * Time.deltaTime);
    }


}
