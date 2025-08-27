namespace Assets.Scripts.Unity.Map.Triggers;

public class DestroyAreaAction : MapAction
{
	public Area area; //Field offset: 0x20
	private DestroyAreaActionModel def; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 238
	}

	public DestroyAreaAction() { }

	public virtual MapActionModel get_Def() { }

}

