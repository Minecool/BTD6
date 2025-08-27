namespace Assets.Scripts.Unity.Map.Triggers;

public class CreateAreasAction : MapAction
{
	public Area[] areas; //Field offset: 0x20
	private CreateAreasActionModel def; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 495
	}

	public CreateAreasAction() { }

	public virtual MapActionModel get_Def() { }

}

