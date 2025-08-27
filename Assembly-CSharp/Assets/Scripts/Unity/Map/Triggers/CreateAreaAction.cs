namespace Assets.Scripts.Unity.Map.Triggers;

public class CreateAreaAction : MapAction
{
	public Area area; //Field offset: 0x20
	private CreateAreaActionModel def; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 238
	}

	public CreateAreaAction() { }

	public virtual MapActionModel get_Def() { }

}

