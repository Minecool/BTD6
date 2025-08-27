namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(PlayMovieClipAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlayMovieClipActionModel : EntityActionModel
{
	public string clipName; //Field offset: 0x38
	public PrefabReference clipPrefab; //Field offset: 0x40
	public bool forceStartRoundOnEndAnimation; //Field offset: 0x48

	public PlayMovieClipActionModel(string name, string clipName, PrefabReference clipPrefab, bool forceStartRoundOnEndAnimation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

