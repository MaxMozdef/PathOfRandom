using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Roll.isRollEnd = false;
        InheritedClass.nameClass = "";
    }
}
