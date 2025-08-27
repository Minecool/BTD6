namespace Assets.Scripts.Unity.Map.Triggers;

public class RemoveableSoldTrigger : MapTrigger
{
	public Removeable removeable; //Field offset: 0x20
	private RemoveableSoldTriggerModel def; //Field offset: 0x28

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 204
	}

	public RemoveableSoldTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

