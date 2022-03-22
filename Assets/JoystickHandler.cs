using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Joystick))]
public class JoystickHandler : MonoBehaviour {

    [SerializeField] Joystick joystick;

	public void OnDrag(BaseEventData data) {
		joystick.OnDrag(data as PointerEventData);
	}

	public void OnPointerUp(BaseEventData data) {
		joystick.OnPointerUp(data as PointerEventData);
	}

	public void OnPointerDown(BaseEventData data) {
		joystick.OnPointerDown(data as PointerEventData);
	}

}
