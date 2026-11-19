using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot(InputValue input)
    {
        Vector2 shootDirection = input.Get<Vector2>();
        RaycastHit2D hit = Physics2D.Raycast(transform.position, shootDirection, 10);

        if(shootDirection != Vector2.zero)
        {
            GameObject bullet = Object.Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(shootDirection * bulletSpeed, ForceMode2D.Impulse);
        }
        
        //spawn bullet on press
        //bullet travels in direction pressed to raycast length (end point)
        //disable GameObject after length is reached
        
        if (hit)
        {
            Debug.Log(hit.transform.name);
            Debug.DrawRay(transform.position, shootDirection * 10);
        }
    }
}
