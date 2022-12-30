using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine;

public class UpgradesStuff : MonoBehaviour
{
    public Controller controller;

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
        clickUpgrade.LvlTxt.text = controller.data.clickUpgradeLvl.ToString();
        clickUpgrade.CostTxt.text = "It Costs " + Cost() + " Bepis Cans";
        clickUpgrade.NameTxt.text = "1 More " + clickUpgradeName;

    }

    public BigDouble Cost() => clickUpgradeBaseCost * BigDouble.Pow(clickUpgradeCostMultiplier, controller.data.clickUpgradeLvl);

    public void BuyUprade()
    {
        if (controller.data.bepis >= Cost())
        {
            controller.data.bepis -= Cost();
            controller.data.clickUpgradeLvl += 1;
        }

        UpdateClickUpgradeUI();
    }
}
