using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class nesneyoketme : MonoBehaviour
{
    //Degiskenler, Diziler Ve Objeler
    public int puan;
    public TextMeshProUGUI puanim;
    public Button anasayfa;
    public GameObject text;
    TextMeshProUGUI textim;
    public int eski;
    public AudioClip[] sesler;
    public static Collider col = new Collider();
    public int randomTagNumber;
    public int randoma;
    public AudioSource audioSource;
    public AudioSource tebriklerSes;
    public int[] dizi = new int[0];

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        text = GameObject.FindWithTag("puan");
        textim = text.GetComponent<TextMeshProUGUI>();

        randoma = Random.Range(0, 10); // 0 ile 9 arasında rastgele bir sayı oluşturur.
        dizi = new int[] { randoma }; // Diziyi oluşturur ve ilk elemanı randoma değeri yapar
        randomTagNumber = randoma;
        sayiKontrol();
    }


    private void OnTriggerEnter(Collider other)
    {
        //Hedeflere ulaşıldığında hedefleri 3 saniye gizleyip yeni hedef oluşturuyor
        if (other.gameObject.tag == randomTagNumber.ToString())
        {
            puan += 2;
            puanim.GetComponent<TextMeshProUGUI>();
            textim.text = puan.ToString();
            sayiOlustur();
            other.gameObject.SetActive(false);  // Objeyi 3 saniyeliğine kapat        


            StartCoroutine(ActivateAfterDelay(other.gameObject, 3f));  // 3 saniye sonra objeyi geri aç
        }
        IEnumerator ActivateAfterDelay(GameObject obj, float delay) // 3 saniye sonra objeyi geri açan işlem
        {
            yield return new WaitForSeconds(delay);
            obj.SetActive(true);

        }
    }

    public void sayiOlustur()
    {
        eski = randomTagNumber;

        do
        {
            randomTagNumber = Random.Range(0, 10);

            if (!dizi.Contains(randomTagNumber))
            {
                Array.Resize(ref dizi, dizi.Length + 1);
                dizi[dizi.Length - 1] = randomTagNumber;
                if (dizi.Length == 10)
                {
                    // Yeni Sayfa yüklenecek
                    tebriklerSes.Play();
                    StartCoroutine(Beklet(2f));
                    Menu();
                }
                break;
            }
        } while (true);

        sescal();
    }

    IEnumerator Beklet(float sure)
    {
        // Belirtilen süre kadar beklet
        yield return new WaitForSeconds(sure);
    }


    public void sayiKontrol()
    {
        foreach (var item in dizi)
        {
            if (eski == item)
            {
                sayiOlustur();
            }
        }
        sescal();
    }

    public void sescal()
    {//ses dosyasını çalıyoruz

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = sesler[randomTagNumber];
        audioSource.Play();

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
