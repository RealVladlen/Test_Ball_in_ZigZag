using UnityEngine;
using UnityEngine.UI;

public class DiamondText : MonoBehaviour
{
    private int _totalDiamonds;

    private Text _totalDiamondsText;

    void Start()
    {
        ResetText();

        GlobalEventManager.DiamondPickUp += PickUpDiamond;
        GlobalEventManager.GameOver += ResetText;

        _totalDiamondsText = GetComponent<Text>();
    }

    private void ResetText()
    {
        _totalDiamonds = 0;
        _totalDiamondsText.text = _totalDiamonds.ToString();
    }

    private void PickUpDiamond()
    {
        _totalDiamonds++;
        GlobalEventManager.SpeedUp();
        _totalDiamondsText.text = _totalDiamonds.ToString();
    }

    private void Unsubscribe()
    {
        GlobalEventManager.DiamondPickUp -= PickUpDiamond;
        GlobalEventManager.GameOver -= ResetText;
    }

    private void OnDestroy()
    {
        Unsubscribe();
    }
}
