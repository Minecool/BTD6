namespace Assets.Scripts.Unity.Map.Triggers;

public class PathActiveAction : MapAction
{
	public Path path; //Field offset: 0x20
	public bool setActiveToo; //Field offset: 0x28
	private PathActiveActionModel def; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 229
	}

	public PathActiveAction() { }

	public virtual MapActionModel get_Def() { }

}

