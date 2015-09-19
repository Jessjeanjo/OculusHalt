using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class led: MonoBehavior {

private string portStr = "COM4";
private int portNumb = 9400;
	
	public SerialPort serial = new SerialPort(portStr, portNumb);
	private bool lightState = false;
	public GameObject light = null;
	public AudioClip clip;
	public void OnMouseDown(){
		if (serial.IsOpen == false){
			serial.Write = "A";
			lightState = true;
		if (light != null && light.light != null){
			light.light.enabled = lightState;
			light.audio.PlayOneShot(clip);
			}

		} else {
			serial.Write("a");
			lightState = false;
			if (light != null && light.light != null){
				light.light.enabled = lightState;
				light.audio.PlayOneShot(clip);

			}		
	
		}

	}

}
