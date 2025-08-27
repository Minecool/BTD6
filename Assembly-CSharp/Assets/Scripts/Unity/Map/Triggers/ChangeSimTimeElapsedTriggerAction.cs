namespace Assets.Scripts.Unity.Map.Triggers;

public class ChangeSimTimeElapsedTriggerAction : MapAction
{
	public MapEvent mapEvent; //Field offset: 0x20
	public float timeReduction; //Field offset: 0x28
	private MapActionModel def; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 201
	}

	public ChangeSimTimeElapsedTriggerAction() { }

	public virtual MapActionModel get_Def() { }

}

