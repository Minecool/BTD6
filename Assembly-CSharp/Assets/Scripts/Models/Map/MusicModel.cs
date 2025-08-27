namespace Assets.Scripts.Models.Map;

public class MusicModel : Model
{
	public readonly String[] musicTrackNames; //Field offset: 0x30

	public MusicModel(string name, String[] musicTrackNames) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

