using BreakInfinity;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public UpgradesStuff upgradesStuff;
    public Data data;

    [SerializeField] private TMP_Text BepisText;
    [SerializeField] private TMP_Text ClickValueTxt;

    public BigDouble ClickValue() => 1 + data.clickUpgradeLvl;


    private void Start()
    {
        data = new Data();
        upgradesStuff.Start();
    }

    private void Update()
    {
        BepisText.text = data.bepis + " Bepis Cans";
        ClickValueTxt.text = "+" + ClickValue() + " Bepis Cans";
    }

    public void ProduceBepis()
    {
        data.bepis += ClickValue();
    }
}
