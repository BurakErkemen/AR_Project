using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject basla, cikis, ogretici;
    public AudioSource menuMusic;
    void Start()
    {
        menuMusic.Play();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartGameLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void Ogretici()
    {
        SceneManager.LoadScene(2);
    }
}
