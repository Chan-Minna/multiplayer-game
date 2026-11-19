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
        if (hit)
        {
            Debug.Log(hit.transform.name);
            Debug.DrawRay(transform.position, shootDirection * 10);
        }
    }
}
