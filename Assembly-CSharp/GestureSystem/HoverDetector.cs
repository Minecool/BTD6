namespace GestureSystem;

public class HoverDetector : RaycastingDetector, IGestureDetector
{

	public HoverDetector(BoxCollider groundCollider, Camera camera) { }

	public override void Detect(Gesture[] gestures) { }

	public override void GestureEnd(Gesture gesture) { }

}

