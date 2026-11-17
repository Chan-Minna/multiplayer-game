using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot(InputValue input)
    {
        Vector2 shootDirection = input.Get<Vector2>(); ;
        GameObject bullet = Object.Instantiate(bulletPrefab, shootDirection, transform.rotation);
    }
}
