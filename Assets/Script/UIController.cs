using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    Player player;
    TextMeshProUGUI distanceText;

    GameObject hasil;
    TextMeshProUGUI hasilAkhir;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<TextMeshProUGUI>();

        hasilAkhir = GameObject.Find("HasilAkhir").GetComponent<TextMeshProUGUI>();
        hasil = GameObject.Find("Hasil");
        hasil.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + "M";

        if (player.isDead)
        {
            hasil.SetActive(true);
            hasilAkhir.text = distance + "M";
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Gamez");
    }
}
