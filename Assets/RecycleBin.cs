using UnityEngine;
using UnityEngine.EventSystems;

public class RecycleBin : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null && dropped.CompareTag("Recycle"))
        {
            Debug.Log("Geri dönüşüm kutusuna doğru atıldı.");
            Destroy(dropped);
            TrashManager.Instance.TrashCleaned();
        }
        else
        {
            Debug.Log("Yanlış kutu! Bu geri dönüşüme ait değil.");
        }
    }
}
