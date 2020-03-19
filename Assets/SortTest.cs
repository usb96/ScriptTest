using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {30,100,50,20,70};

		//昇順に並び替え
		for(int i = 0; i < array.Length; i++){
			
			for(int j = 0; j < array.Length - 1; j++){
				
				if(array[j] > array[j + 1]){
					
					int num = array[j + 1];
					array[j + 1] = array[j];
					array[j] = num;

				}

			}

		}

		//昇順のままLogに表示
		for(int k = 0; k < array.Length; k++){
			Debug.Log(array[k]);
		}

		//降順で表示
		for(int l = array.Length - 1;l >= 0; l--){
			Debug.Log(array[l]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
