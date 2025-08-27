//Type is in global namespace

public class CustomScaleAnimator : CustomAnimationComponent
{
	private float lastSetScale; //Field offset: 0x58
	private Vector3 RootScale; //Field offset: 0x5C

	public CustomScaleAnimator() { }

	public void SetRootScale(Vector3 scale) { }

	public void StopPlaying() { }

	protected virtual void UpdateAnimation(float currentTime) { }

	private void UpdateScale(float scale, Vector3 rootScale) { }

}

