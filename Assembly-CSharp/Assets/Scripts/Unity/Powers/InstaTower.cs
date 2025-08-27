namespace Assets.Scripts.Unity.Powers;

public class InstaTower : PowerBehavior
{
	public Tower tower; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public InstaTower() { }

	public virtual PowerBehaviorModel get_Def() { }

}

