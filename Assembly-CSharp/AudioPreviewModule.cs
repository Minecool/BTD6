//Type is in global namespace

public class AudioPreviewModule : MonoBehaviour
{
	public Animator equalizerAnimator; //Field offset: 0x20
	public AudioClip currentAudioClip; //Field offset: 0x28

	public AudioPreviewModule() { }

	private void PlayEQ(int play = 0) { }

	public void PlayNewTrack(AudioClip audioClip) { }

	public void ShowEQ(bool show) { }

	public void StopCurrentTrack() { }

}

