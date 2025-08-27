namespace Assets.Scripts.Unity.Map.Actions;

public class SuspendTowersOnAreaAction : MapAction
{
	private SuspendTowersOnAreaActionModel def; //Field offset: 0x20
	public Area area; //Field offset: 0x28
	public bool isUnsuspendAction; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 253
	}

	public SuspendTowersOnAreaAction() { }

	public virtual MapActionModel get_Def() { }

}

