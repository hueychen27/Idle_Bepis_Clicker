using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine;

public class UpgradesStuff : MonoBehaviour
{
    public static UpgradesStuff instance;
    private void Awake() => instance = this;
    public Upgrades clickUpgrade;

    public string clickUpgradeName;

    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMultiplier;

    public void Start()
    {
        clickUpgradeName = "Bepis Cans Per Click";
        clickUpgradeBaseCost = 12;
        clickUpgradeCostMultiplier = 1.5;
        UpdateClickUpgradeUI();
    }

    public void UpdateClickUpgradeUI()
    {
        var data = Controller.instance.data;
        clickUpgrade.LvlTxt.text = data.clickUpgradeLvl.ToString();
        clickUpgrade.CostTxt.text = "It Costs " + Cost() + " Bepis Cans";
        clickUpgrade.NameTxt.text = "1 More " + clickUpgradeName;

    }

    public BigDouble Cost() => clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMultiplier, Controller.instance.data.clickUpgradeLvl);

    public void BuyUprade()
    {
        var data = Controller.instance.data;
        if (data.bepis >= Cost())
        {
            data.bepis -= Cost();
            data.clickUpgradeLvl += 1;
        }

        UpdateClickUpgradeUI();
    }
}
