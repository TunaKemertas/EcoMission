using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab; // Prefab (UI Image)
    public RectTransform spawnArea; // Spawn edilecek alan
    public int trashCount = 5;

    void Start()
    {
        SpawnAllTrash();
    }

    void SpawnAllTrash()
    {
        for (int i = 0; i < trashCount; i++)
        {
            SpawnSingleTrash();
        }
    }

    void SpawnSingleTrash()
    {
        GameObject newTrash = Instantiate(trashPrefab, spawnArea);
        RectTransform rt = newTrash.GetComponent<RectTransform>();

        float x = Random.Range(0f, spawnArea.rect.width);
        float y = Random.Range(0f, spawnArea.rect.height);

        rt.anchoredPosition = new Vector2(
            x - spawnArea.rect.width / 2f,
            y - spawnArea.rect.height / 2f
        );

        // Oluşturulan her çöp için TrashManager'a bildirim
        TrashManager.Instance.RegisterTrash();
    }
}
