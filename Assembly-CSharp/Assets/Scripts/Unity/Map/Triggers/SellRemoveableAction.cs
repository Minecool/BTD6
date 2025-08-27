namespace Assets.Scripts.Unity.Map.Triggers;

public class SellRemoveableAction : MapAction
{
	public Removeable removeable; //Field offset: 0x20
	private SellRemoveableActionModel def; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 192
	}

	public SellRemoveableAction() { }

	public virtual MapActionModel get_Def() { }

}

