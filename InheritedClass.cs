using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InheritedClass : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI showClass, descriptonLinkClass;
    [SerializeField] Button choiseSkill, nameClassLink;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Roll.isRollEnd)
        {
            if (collision.tag == "Cursor")
            {
                showClass.text = gameObject.name;
                ShowNextUI();
            }
        }
    }

    void ShowNextUI()
    {
        descriptonLinkClass.gameObject.SetActive(true);
        choiseSkill.gameObject.SetActive(true);
        nameClassLink.gameObject.SetActive(true);
    }
}
