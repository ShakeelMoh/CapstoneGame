using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureChecker : MonoBehaviour {

	// Use this for initialization
	public GameObject tile1;
	public GameObject tile2;
	public GameObject tile3;
	public GameObject tile4;
	public GameObject tile5;
	public GameObject tile6;
	public GameObject tile7;
	public GameObject tile8;
	public GameObject tile9;
	public GameObject tile10;
	public GameObject tile11;
	public GameObject tile12;
	public GameObject tile13;
	public GameObject tile14;
	public GameObject tile15;

	public GameObject door;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (tile1.GetComponent<PictureTile> ().correct) {
			if (tile2.GetComponent<PictureTile> ().correct) {
				if (tile3.GetComponent<PictureTile> ().correct) {
					if (tile4.GetComponent<PictureTile> ().correct) {
						if (tile5.GetComponent<PictureTile> ().correct) {
							if (tile6.GetComponent<PictureTile> ().correct) {
								if (tile7.GetComponent<PictureTile> ().correct) {
									if (tile8.GetComponent<PictureTile> ().correct) {
										if (tile9.GetComponent<PictureTile> ().correct) {
											if (tile10.GetComponent<PictureTile> ().correct) {
												if (tile11.GetComponent<PictureTile> ().correct) {
													if (tile12.GetComponent<PictureTile> ().correct) {
														if (tile13.GetComponent<PictureTile> ().correct) {
															if (tile14.GetComponent<PictureTile> ().correct) {
																if (tile15.GetComponent<PictureTile> ().correct) {
																	door.GetComponent<OpenDoor> ().autoOpen = true;
																} else {
																	door.GetComponent<OpenDoor> ().autoOpen = false;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
