using UnityEngine;
using UnityEngine.UI;

public class TrashManager : MonoBehaviour
{
    public static TrashManager Instance;

    private int totalTrash = 0;
    private int cleanedTrash = 0;

    public GameObject nextButton; // UI'deki "Next" butonu

    private void Awake()
    {
        // Singleton: Başka bir instance varsa bu nesneyi yok et
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        // Başta buton gizli olsun
        if (nextButton != null)
        {
            nextButton.SetActive(false);
        }

        // Otomatik sayım da yapılabilir (eğer çöpler tag'li ise)
        // totalTrash = GameObject.FindGameObjectsWithTag("Trash").Length;
        // Debug.Log("Başlangıçta çöp sayısı: " + totalTrash);
    }

    public void RegisterTrash()
    {
        totalTrash++;
        Debug.Log("Çöp eklendi. Toplam: " + totalTrash);
    }

    public void TrashCleaned()
    {
        cleanedTrash++;
        Debug.Log("Temizlenen: " + cleanedTrash + " / " + totalTrash);

        if (cleanedTrash >= totalTrash && totalTrash > 0)
        {
            Debug.Log("Tüm çöpler temizlendi!");
            if (nextButton != null)
                nextButton.SetActive(true);
        }
    }
}
