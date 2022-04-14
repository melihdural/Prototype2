using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;
    
    private float xRange = 20f;

    private float zRange = 10f;

    [SerializeField]
    private float speed, normalSpeed, runSpeed;

    [SerializeField]
    private GameObject projectilePrefab;
    
    void Update()
    {
        KeepPlayerInBounds();
        RunPlayer();
        SpawnProjectile();
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horizontalInput, 0, verticalInput);
        
        transform.Translate(playerMovement * Time.deltaTime * speed);

    }

    private void KeepPlayerInBounds()
    {
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }

    private void RunPlayer()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = normalSpeed;
        }
        
    }

    private void SpawnProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        }
    }

    

}
