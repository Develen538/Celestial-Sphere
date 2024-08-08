using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Plane component))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.TryGetComponent(out PlayerController component1))
        {
            Destroy(gameObject);
        }
    }

}
