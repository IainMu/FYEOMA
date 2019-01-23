/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;
using System;


public class BarcodeReader : MonoBehaviour {



private WebCamTexture camTexture;
private Rect screenRect;
void Start() {
  screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture
        {
            requestedHeight = Screen.height,
            requestedWidth = Screen.width
        };
        if (camTexture != null) {
    camTexture.Play();
  }
}

void Update(){
        if (Screen.orientation != ScreenOrientation.LandscapeLeft)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
    void OnGUI () {
  // drawing the camera on screen
  GUI.DrawTexture (screenRect, camTexture, ScaleMode.ScaleToFit);
  // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
  try {
            IBarcodeReader barcodeReader = (IBarcodeReader) new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(camTexture.GetPixels32(),
      camTexture.width, camTexture.height);
    if (result != null) {
                GUI.Box(new Rect(Screen.width/2-20, Screen.height / 2 - 20,40,40),Decode.decode(3,result.Text));
    }
  } catch(Exception ex) { Debug.LogWarning (ex.Message); }
}
}
*/