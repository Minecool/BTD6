//Type is in global namespace

public class FXVolumeControl : VolumeControl
{
	internal enum SoundVolumeControlType
	{
		GeneralSound = 0,
		HeroVoice = 1,
	}

	public SoundVolumeControlType volumeControlType; //Field offset: 0x48

	public FXVolumeControl() { }

	private void Awake() { }

	protected virtual void OnButtonPressed() { }

	protected virtual void OnSliderChanged(float value) { }

}

