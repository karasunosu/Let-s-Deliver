using UnityEngine;

public class Deliver : MonoBehaviour
{
    bool isPicked;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Package") && !isPicked)
        {
            isPicked = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("Customer"))
        {
            isPicked = false;
        }
    }
}
