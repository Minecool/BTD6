//Type is in global namespace

public class CustomColorAnimator : CustomAnimationComponent
{
	[SerializeField]
	private Color color1; //Field offset: 0x58
	[SerializeField]
	private Color color2; //Field offset: 0x68
	private SpriteRenderer targetSprite; //Field offset: 0x78
	private Image img; //Field offset: 0x80

	public CustomColorAnimator() { }

	private void Init() { }

	private void Start() { }

	protected virtual void UpdateAnimation(float currentTime) { }

}

