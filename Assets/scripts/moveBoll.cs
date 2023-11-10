using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoll : MonoBehaviour
{
    
    private CharacterController characterController;

   
    public float moveSpeed = 5.0f;

    
    private Vector3 moveDirection;

   
    void Start()
    {
        // Obt�m a refer�ncia ao CharacterController anexado ao objeto
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        // Obt�m as entradas de teclado para movimento horizontal e vertical
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

        
        moveDirection = transform.TransformDirection(moveDirection);

        // Multiplica a dire��o pelo valor de moveSpeed para controlar a velocidade
        moveDirection *= moveSpeed;

        // Aplica a for�a da gravidade ao movimento vertical
        moveDirection.y += Physics.gravity.y * Time.deltaTime;

        // Move o personagem usando o Character Controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}