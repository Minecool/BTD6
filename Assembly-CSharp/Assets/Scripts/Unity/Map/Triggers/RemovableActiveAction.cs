namespace Assets.Scripts.Unity.Map.Triggers;

public class RemovableActiveAction : MapAction
{
	public Removeable removeable; //Field offset: 0x20
	public bool setActiveToo; //Field offset: 0x28
	private RemovableActiveActionModel def; //Field offset: 0x30

	public virtual MapActionModel Def
	{
		 get { } //Length: 232
	}

	public RemovableActiveAction() { }

	public virtual MapActionModel get_Def() { }

}

