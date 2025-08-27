//Type is in global namespace

public class VolumeControl : MonoBehaviour
{
	private const float kVolumePrefToSliderMultiplier = 100; //Field offset: 0x0
	public Slider slider; //Field offset: 0x20
	public Image buttonImage; //Field offset: 0x28
	public SpriteReference mutedImage; //Field offset: 0x30
	public SpriteReference unMutedImage; //Field offset: 0x38
	protected string volumeModifierKey; //Field offset: 0x40

	protected bool IsMuted
	{
		 get { } //Length: 762
	}

	public VolumeControl() { }

	protected bool get_IsMuted() { }

	protected override void OnButtonPressed() { }

	private void OnDestroy() { }

	protected override void OnSliderChanged(float value) { }

	protected float SharedAwake(bool isMuted) { }

	protected float SharedOnButtonPressed(bool isMute) { }

	protected float SharedOnSliderChanged(float value) { }

}

