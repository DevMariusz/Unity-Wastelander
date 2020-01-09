//In drop pile script
public List<Object> DroppedItems;

//In Player stats script
[HideInInspector]
public Dictionary<WeaponData, int> MyWeaponsInInventory;

//In player move script when player moves over drop pile.
foreach (Object item in pileInRoom.DroppedItems)
{
  else if (item.GetType().ToString() == "WeaponData")
    {
      WeaponData weapon = item as WeaponData;
      bool weaponFound = false;
      if (MyWeaponsInInventory.Count > 0)
      {
        foreach (WeaponData weaponInInventory in MyWeaponsInInventory.Keys)
        {
          if (weaponInInventory.WeaponName == weapon.WeaponName)
          {
            MyWeaponsInInventory[weaponInInventory] += 1;
            weaponInInventory.WeaponQty = MyWeaponsInInventory[weaponInInventory];
            weaponFound = true;
            break;
          }
        }
        if (!weaponFound)
        {
          MyWeaponsInInventory.Add(weapon, 1);
          weapon.WeaponQty = 1;
        }
      }
      else
      {
        MyWeaponsInInventory.Add(weapon, 1);
        weapon.WeaponQty = 1;
      }
    }
}
