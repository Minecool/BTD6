//Type is in global namespace

public class PetSoundToggleControl : MonoBehaviour
{
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	public Toggle petSoundToggleButton; //Field offset: 0x20
	public Animator petSoundToggleAnimator; //Field offset: 0x28

	public PetSoundToggleControl() { }

	public void TogglePetSounds(bool petSoundsOn) { }

}

