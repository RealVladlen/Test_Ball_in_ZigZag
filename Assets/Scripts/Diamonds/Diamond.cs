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
            Unsubscribe();
            Destroy(gameObject);
            
        }
    }

    private void OnDestroy()
    {
        Unsubscribe();
    }

}
