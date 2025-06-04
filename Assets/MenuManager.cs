using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    void Start()
    {
        // Start butonunu bul ve fonksiyon ata
        GameObject startBtn = GameObject.FindGameObjectWithTag("StartButton");
        if (startBtn != null)
        {
            startBtn.GetComponent<Button>().onClick.AddListener(StartGame);
        }

        // Quit butonunu bul ve fonksiyon ata
        GameObject quitBtn = GameObject.FindGameObjectWithTag("QuitButton");
        if (quitBtn != null)
        {
            quitBtn.GetComponent<Button>().onClick.AddListener(QuitGame);
        }
    }

    public void StartGame()
    {
        Debug.Log("Oyun başlıyor...");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("Oyun kapatılıyor...");
        Application.Quit();
    }

}
