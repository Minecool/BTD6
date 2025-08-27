namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class PlayMovieClipAction : EntityAction
{
	public string clipName; //Field offset: 0x18
	public PrefabReference clipPrefab; //Field offset: 0x20
	public bool forceStartRoundOnEndAnimation; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 132
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public PlayMovieClipAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

