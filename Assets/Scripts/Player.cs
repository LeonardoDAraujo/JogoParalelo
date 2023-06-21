using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
       // Start is called before the first frame update
        public float moveSpeed = 5f;
        public float entradaHorizontal;
        public float entradaVertical;

        public GameObject pfLaser;

        void Start(){

        }
       void Update(){

       if ( Input.GetKeyDown(KeyCode.Space)){

       Instantiate(pfLaser,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);


       }



       { // Movimentação horizontal
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal,0,0) * moveSpeed * Time.deltaTime;

        //Movimentação vertical
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,vertical,0) * moveSpeed * Time.deltaTime;
       }
     }
}


