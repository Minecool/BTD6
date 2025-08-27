namespace GestureSystem;

public interface IGestureDetector
{

	public void Detect(Gesture[] gestures) { }

	public void GestureEnd(Gesture gesture) { }

}

