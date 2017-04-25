using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addGold : MonoBehaviour {
	
	public void Clicked() {
		value_gold value_gold = GetComponent<value_gold>();
		int int_gold = value_gold.int_value_gold;
		int_gold = int_gold + 1;
		GetComponent<Text>().text = int_gold.ToString();
		value_gold.int_value_gold = int_gold;
	}
}