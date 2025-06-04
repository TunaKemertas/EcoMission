using UnityEngine;
using UnityEngine.EventSystems;

public class TrashBin : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null && dropped.CompareTag("Trash"))
        {
            Debug.Log("Çöp kutusuna doğru çöp atıldı.");
            Destroy(dropped);
            TrashManager.Instance.TrashCleaned();
        }
        else
        {
            Debug.Log("Yanlış çöp kutusu! Bu buraya ait değil.");
        }
    }
}
