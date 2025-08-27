namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateEffectOnTowerExpire : TowerBehavior
{
	public CreateEffectOnTowerExpire parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 198
	}

	public CreateEffectOnTowerExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

