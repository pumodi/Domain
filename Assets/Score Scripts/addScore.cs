using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addScore : MonoBehaviour {

	public void Clicked() {
		value_score value_score = GetComponent<value_score>();
		int int_score = value_score.int_value_score;
		int_score = int_score + 1;
		GetComponent<Text>().text = int_score.ToString();
		value_score.int_value_score = int_score;
	}
}
