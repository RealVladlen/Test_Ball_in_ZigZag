using UnityEngine;
using UnityEngine.UI;

public class DiamondText : MonoBehaviour
{
    private int _totalDiamonds;

    void Start()
    {
        ResetText();

        GlobalEventManager.DiamondPickUp += PickUpDiamond;
        GlobalEventManager.GameOver += ResetText;
    }

    private void ResetText()
    {
        _totalDiamonds = 0;
        GetComponent<Text>().text = _totalDiamonds.ToString();
    }

    private void PickUpDiamond()
    {
        _totalDiamonds++;
        GlobalEventManager.SpeedUp();
        GetComponent<Text>().text = _totalDiamonds.ToString();
    }
}
