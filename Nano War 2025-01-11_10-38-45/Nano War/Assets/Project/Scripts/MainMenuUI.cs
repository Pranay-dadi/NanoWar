using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

//Movement between scenes based on buttons in main menu.
namespace NanoWar {
    public class MainMenuUI : MonoBehaviour {
        [SerializeField] SceneReference startingLevel;
        [SerializeField] Button playButton;

        void Awake() {
            playButton.onClick.AddListener(() => Loader.Load(startingLevel));
            Time.timeScale = 1f;
        }
    }
}