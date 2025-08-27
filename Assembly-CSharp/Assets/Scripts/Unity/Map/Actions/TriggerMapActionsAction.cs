namespace Assets.Scripts.Unity.Map.Actions;

public class TriggerMapActionsAction : MapAction
{
	private TriggerMapActionsActionModel def; //Field offset: 0x20
	public MapActions mapActions; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 305
	}

	public TriggerMapActionsAction() { }

	public virtual MapActionModel get_Def() { }

}

