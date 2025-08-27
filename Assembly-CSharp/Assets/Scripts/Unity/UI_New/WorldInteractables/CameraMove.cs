namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

internal class CameraMove
{
	private Camera camera; //Field offset: 0x10
	public bool active; //Field offset: 0x18
	private float progress; //Field offset: 0x1C
	private AnimationCurve curve; //Field offset: 0x20
	private Vector3 start; //Field offset: 0x28
	private Vector3 end; //Field offset: 0x34
	private float duration; //Field offset: 0x40

	public CameraMove(Camera camera, AnimationCurve curve) { }

	public void Cancel() { }

	public void Go(Vector3 start, Vector3 end, float duration) { }

	public void Update() { }

}

