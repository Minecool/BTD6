namespace Assets.Scripts.Unity.Map.Actions;

public class SetAreaActiveAction : MapAction
{
	private SetAreaActiveActionModel def; //Field offset: 0x20
	public Area area; //Field offset: 0x28
	public bool isActive; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 253
	}

	public SetAreaActiveAction() { }

	public virtual MapActionModel get_Def() { }

}

