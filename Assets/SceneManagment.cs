using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(2); // 2. sahnenin indexi 1'dir (0’dan başlar)
    }
}
