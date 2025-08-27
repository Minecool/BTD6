namespace Assets.Scripts.Unity.Powers;

public class DartTime : PowerBehavior
{
	public float bloonSpeed; //Field offset: 0x20
	public float towerAttackSpeed; //Field offset: 0x24
	public float duration; //Field offset: 0x28

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public DartTime() { }

	public virtual PowerBehaviorModel get_Def() { }

}

