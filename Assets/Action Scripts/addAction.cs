using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addAction : MonoBehaviour {

	public void Clicked() {
		value_action value_action = GetComponent<value_action>();
		int int_action = value_action.int_value_action;
		int_action = int_action + 1;
		GetComponent<Text>().text = int_action.ToString();
		value_action.int_value_action = int_action;
	}
}
