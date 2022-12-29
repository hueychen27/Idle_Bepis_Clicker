using BreakInfinity;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{

    public Data data;

    [SerializeField] private TMP_Text bepisText;

    private void Start()
    {
        data = new Data();
    }

    private void Update()
    {
        bepisText.text = data.bepis + " Bepis Cans";
    }

    public void ProduceBepis()
    {
        data.bepis += 1;
    }

    public void RemoveBepis()
    {
        data.bepis -= 1;
    }
}
