using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Item", menuName="Inventory/Item")]
public class Item : ScriptableObject {
	public new string name;
	public string description;
	public Sprite picture;
	public int baseValue;
}
