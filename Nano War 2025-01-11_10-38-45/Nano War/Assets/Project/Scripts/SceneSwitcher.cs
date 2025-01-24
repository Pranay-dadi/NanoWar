using UnityEngine;
using UnityEngine.SceneManagement;

//Scene switching between scenes other than main menu.
namespace NanoWar
{
    public class SceneSwitcher : MonoBehaviour
    {
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    }
}
