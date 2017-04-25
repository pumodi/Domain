using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gold : MonoBehaviour {
	public int int_value_gold = 0;

	public void ClickedMinus() {
		value_gold value_gold = GetComponent<value_gold>();
		int int_gold = value_gold.int_value_gold;
		int_gold = int_gold - 1;
		if (int_gold < 0) {
			int_gold = 0;
		}
		GetComponent<Text>().text = int_gold.ToString();
		value_gold.int_value_gold = int_gold;
	}
	public void ClickedAdd() {
		value_gold value_gold = GetComponent<value_gold>();
		int int_gold = value_gold.int_value_gold;
		int_gold = int_gold + 1;
		GetComponent<Text>().text = int_gold.ToString();
		value_gold.int_value_gold = int_gold;
	}
}
