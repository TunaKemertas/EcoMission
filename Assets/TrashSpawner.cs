using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trashPrefab; // UI Image prefab
    public RectTransform spawnArea; // Canvas üzerindeki alan
    public int trashCount = 5;

    void Start()
    {
        for (int i = 0; i < trashCount; i++)
        {
            SpawnTrash();
        }
    }

    void SpawnTrash()
    {
        GameObject newTrash = Instantiate(trashPrefab, spawnArea);
        RectTransform rt = newTrash.GetComponent<RectTransform>();

        float x = Random.Range(0f, spawnArea.rect.width);
        float y = Random.Range(0f, spawnArea.rect.height);

        rt.anchoredPosition = new Vector2(x - spawnArea.rect.width / 2, y - spawnArea.rect.height / 2);
    }
}
