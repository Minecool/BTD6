namespace Assets.Scripts.Models.Audio;

public class SoundModel : Model
{
	public AudioClipReference assetId; //Field offset: 0x30

	public SoundModel(string id, AudioClipReference assetId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

