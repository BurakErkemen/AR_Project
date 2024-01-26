using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameLevel : MonoBehaviour
{
    int puan;
    public TextMeshProUGUI scoreText;
    public Text text;
    public GameObject Player;
    public static Collider col = new Collider();
    public Button Anasayfa;
    public int[] dizi = new int[0];
    public int randomTagNumber;
    public int randoma;
    //Sesler
    public AudioSource tebrikler, GameMusic;
    public AudioSource audioSource;
    public AudioClip[] ses;
    void Start()
    {
        tebrikler.mute = true; GameMusic.mute = true;
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        // E�er bir Collision de�erine ihtiyac�n�z yoksa, null olarak b�rakabilirsiniz.
        //OnTriggerEnter();
    }
    /* private void OnTriggerEnter()
     {//Hedeflere ula��ld���nda hedefleri 3 saniye gizleyip yeni hedef olu�turuyor
         if (player.gameObject.tag == "1")
         {


             Destroy(GameObject.FindWithTag("1"));

         }

     }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject,1f);
        }
    }


    public void Don_Anasayfa()
    {
        SceneManager.LoadScene(0);
    }

}
