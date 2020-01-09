//List of weapon scriptable objects on enemy script
public List<WeaponData> WeaponDropTypes;

//List of all items dropped by the enemy
[HideInInspector]
public List<Object> DroppedItems;

//enemy drops random weapon into dropped items list from its available weapon types.
for (int i = 0; i < WeaponDropTypes.Count; i++)
  {
    x = Random.Range(0, 2);
    for (int z = 0; z < x; z++)
      DroppedItems.Add(WeaponDropTypes[i]);
  }
