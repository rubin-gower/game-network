using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class playerscr : NetworkBehaviour
{


    [SerializeField] private Vector3 movment = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
       
    }
    [Client]
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.W) && hasAuthority)
        {
            transform.Translate(movment); 
        }
    }
}
