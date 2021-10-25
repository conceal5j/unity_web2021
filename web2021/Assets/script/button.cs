
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject loadingbar;

    public void OnDestroy()
    {
        Destroy(loadingbar);
    }
}
