using UnityEngine;

public class InheritedClass : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (Roll.isRollEnd)
        {
            if (collision.tag == "Cursor")
            {
                Debug.Log(gameObject.name);
            }
        }
    }
}
