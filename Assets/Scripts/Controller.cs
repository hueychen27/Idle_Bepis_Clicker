using BreakInfinity;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public static Controller instance;
    private void Awake() => instance = this;
    public Data data;

    [SerializeField] private TMP_Text BepisText;
    [SerializeField] private TMP_Text ClickValueTxt;

    public BigDouble ClickValue() => 1 + data.clickUpgradeLvl;


    private void Start()
    {
        data = new Data();
        UpgradesStuff.instance.Start();
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
