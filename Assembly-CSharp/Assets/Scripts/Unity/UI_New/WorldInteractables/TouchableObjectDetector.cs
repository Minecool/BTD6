namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

public class TouchableObjectDetector : IGestureDetector
{
	public Action<TouchableObject> OnTouchedObject; //Field offset: 0x10

	public TouchableObjectDetector() { }

	public override void Detect(Gesture[] gestures) { }

	private bool DetectTouch(Gesture gesture) { }

	public void GestureBegin(Gesture gesture) { }

	public override void GestureEnd(Gesture gesture) { }

}

