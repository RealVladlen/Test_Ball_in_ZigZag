using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void Start()
    {
        GlobalEventManager.GameOver += DestroyDiamond;
    }

    public void Unsubscribe()
    {
        GlobalEventManager.GameOver -= DestroyDiamond;
    }

    private void DestroyDiamond()
    {
        if (gameObject != null)
        {
            Destroy(gameObject);

            Unsubscribe();
        }
    }
}
