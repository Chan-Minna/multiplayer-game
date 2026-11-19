using UnityEngine;

public class FindObject : MonoBehaviour
{
    public LayerMask raycastLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 100);
        if (hit)
        {
            Debug.Log(hit.transform.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector2.right * 100);

    }
}
