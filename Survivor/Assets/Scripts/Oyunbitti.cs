using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Oyunbitti : MonoBehaviour
{
    public TextMeshProUGUI puan;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        puan.text = "Puanýnýz:" + PlayerPrefs.GetInt("puan");
    }

    // Update is called once per frame
    public void YenidenOyna()
    {
        SceneManager.LoadScene("Oyun");
    }
}
