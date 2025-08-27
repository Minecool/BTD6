//Type is in global namespace

public class CustomMoveAnimator : CustomAnimationComponent
{
	[SerializeField]
	private Vector3 startOffset; //Field offset: 0x58
	[SerializeField]
	private Vector3 endOffset; //Field offset: 0x64
	private Vector3 homePosition; //Field offset: 0x70

	public CustomMoveAnimator() { }

	private void Start() { }

	protected virtual void UpdateAnimation(float currentTime) { }

}

