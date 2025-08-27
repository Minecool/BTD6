//Type is in global namespace

public class CustomFlyoverAnimator : CustomAnimationComponent
{
	private Vector3 startPoint; //Field offset: 0x58
	private Vector3 endPoint; //Field offset: 0x64
	private float approachDistance; //Field offset: 0x70

	public CustomFlyoverAnimator() { }

	protected virtual void Awake() { }

	protected void OnDisable() { }

	protected virtual void Reset() { }

	private void SetInitialPosition() { }

	protected virtual void UpdateAnimation(float currentTime) { }

}

