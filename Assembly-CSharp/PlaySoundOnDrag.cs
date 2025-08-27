//Type is in global namespace

public class PlaySoundOnDrag : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public AudioClip sound; //Field offset: 0x20
	public SoundVolumeControlType volumeControlType; //Field offset: 0x28
	private bool isPlaying; //Field offset: 0x2C

	private AudioFactory AudioFactory
	{
		private get { } //Length: 146
	}

	private AudioType AudioType
	{
		private get { } //Length: 97
	}

	private string SoundModifier
	{
		private get { } //Length: 210
	}

	private float Volume
	{
		private get { } //Length: 171
	}

	public PlaySoundOnDrag() { }

	private void ChangeVolume() { }

	private void ExecuteAudioTask(AudioClip clip, bool play) { }

	private AudioFactory get_AudioFactory() { }

	private AudioType get_AudioType() { }

	private string get_SoundModifier() { }

	private float get_Volume() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	private void OnDestroy() { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	private void PlaySound() { }

	private void StopSound() { }

}

