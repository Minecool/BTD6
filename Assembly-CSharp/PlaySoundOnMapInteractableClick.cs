//Type is in global namespace

public class PlaySoundOnMapInteractableClick : OnClickHandler
{
	public AudioClip soundClip1; //Field offset: 0x50
	public AudioClip soundClip2; //Field offset: 0x58
	public AudioClip soundClip3; //Field offset: 0x60
	public float delay; //Field offset: 0x68
	public bool overrideLowQuality; //Field offset: 0x6C
	public PlayInteractableAudio playInteractableAudio; //Field offset: 0x70

	public PlaySoundOnMapInteractableClick() { }

	private void Awake() { }

	public virtual void OnActivate() { }

	private void PlaySound(bool useSequence = false) { }

}

