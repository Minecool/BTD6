namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MerchantShip : TowerBehavior
{
	public MerchantShip parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public MerchantShip() { }

	public virtual TowerBehaviorModel get_Def() { }

}

