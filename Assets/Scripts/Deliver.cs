using UnityEngine;
using TMPro;

public class Deliver : MonoBehaviour
{
    [SerializeField] TMP_Text deliverText;

    bool isPicked;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Package") && !isPicked)
        {
            isPicked = true;
            deliverText.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("Customer"))
        {
            isPicked = false;
            deliverText.gameObject.SetActive(false);
        }
    }
}
