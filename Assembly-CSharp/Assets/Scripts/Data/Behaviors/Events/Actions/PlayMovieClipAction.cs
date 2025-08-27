namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class PlayMovieClipAction : EntityAction
{
	[SerializeField]
	public string clipName; //Field offset: 0x28
	[SerializeField]
	public PrefabReference clipPrefab; //Field offset: 0x30
	[SerializeField]
	public bool forceStartRoundOnEndAnimation; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 132
	}

	public PlayMovieClipAction() { }

	public virtual Model get_Model() { }

}

