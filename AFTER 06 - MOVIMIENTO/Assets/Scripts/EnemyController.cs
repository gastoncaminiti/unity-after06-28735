using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   [SerializeField] private float speedEnemy;
   [SerializeField] private GameObject rotationObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAround(rotationObject);
    }

    private void MoveAround(GameObject AroundObject){
        transform.RotateAround(AroundObject.transform.position,Vector3.up,speedEnemy * Time.deltaTime);
    }
}
