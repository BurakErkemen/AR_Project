using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class tutorialScript : MonoBehaviour
{
    //Degiskenler, Diziler Ve Objeler
    public int puan;
    public TextMeshProUGUI puanim;
    public Button anasayfa;
    public GameObject text;
    public int eski;
    public AudioClip[] sesler;
    public static Collider col = new Collider();
    public int randomTagNumber;
    public AudioSource audioSource;
    public AudioSource tebriklerSes, bitis, hosgeldin,sayı1,sayı2;

    void Start()
    {
        tebriklerSes.mute = true; bitis.mute = true; hosgeldin.mute = true;
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        StartCoroutine(KodAdi()); // KodAdi, yukarıdaki kodunuzun bulunduğu bir coroutine fonksiyonunun adı olmalıdır.
        randomTagNumber = 5;
        
    }
    private IEnumerator KodAdi()
    {
        hosgeldin.mute = false;
        hosgeldin.Play();

        yield return Beklet(2f);
        yield return new WaitForSeconds(hosgeldin.clip.length); // Hosgeldin sesinin tamamlanmasını bekle

        tebriklerSes.mute = false;
        tebriklerSes.Play();

        yield return Beklet(1f);
        yield return new WaitForSeconds(tebriklerSes.clip.length);

        sayı1.mute = false;
        sayı1.Play();

        yield return Beklet(7f);
        yield return new WaitForSeconds(sayı1.clip.length);
        
        tebriklerSes.mute = false;
        tebriklerSes.Play();

        yield return Beklet(1f);
        yield return new WaitForSeconds(tebriklerSes.clip.length);

        sayı2.mute = false;
        sayı2.Play();

        yield return Beklet(7f);
        yield return new WaitForSeconds(sayı2.clip.length);

        tebriklerSes.mute = false;
        tebriklerSes.Play();

        yield return Beklet(1f);
        yield return new WaitForSeconds(tebriklerSes.clip.length);

        bitis.mute = false;
        bitis.Play();

        yield return Beklet(3f);
        yield return new WaitForSeconds(bitis.clip.length);

        Menu();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Hedeflere ulaşıldığında hedefleri 3 saniye gizleyip yeni hedef oluşturuyor
        if (other.gameObject.tag == 8.ToString() || other.gameObject.tag == 5.ToString())
        {

            other.gameObject.SetActive(false);  // Objeyi 3 saniyeliğine kapat        
            StartCoroutine(ActivateAfterDelay(other.gameObject, 3f));  // 3 saniye sonra objeyi geri aç
        }
        IEnumerator ActivateAfterDelay(GameObject obj, float delay) // 3 saniye sonra objeyi geri açan işlem
        {
            yield return new WaitForSeconds(delay);
            obj.SetActive(true);

        }
    }
    public Transform target; // Kameranın takip edeceği hedef nesnenin transformu
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Kamera ve hedef nesne arasındaki mesafe

    void LateUpdate()
    {
        if (target != null)
        {
            // Hedef nesnenin pozisyonu ile offset arasındaki farkı kullanarak kamerayı konumlandır
            transform.position = target.position + offset;

            // Hedef nesneye bakacak şekilde kamerayı döndür
            transform.LookAt(target);
        }
    }
    IEnumerator Beklet(float sure)
    {
        // Belirtilen süre kadar beklet
        yield return new WaitForSeconds(sure);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
