using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addBuy : MonoBehaviour {

	public void Clicked() {
		value_buy value_buy = GetComponent<value_buy>();
		int int_buy = value_buy.int_value_buy;
		int_buy = int_buy + 1;
		GetComponent<Text>().text = int_buy.ToString();
		value_buy.int_value_buy = int_buy;
	}
}