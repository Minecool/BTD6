namespace Assets.Scripts.Unity.Map.Triggers;

public class DestroyAreasAction : MapAction
{
	public Area[] areas; //Field offset: 0x20
	private DestroyAreasActionModel def; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 495
	}

	public DestroyAreasAction() { }

	public virtual MapActionModel get_Def() { }

}

