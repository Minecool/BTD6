namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateEffectOnSell : TowerBehavior
{
	public CreateEffectOnSell parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 198
	}

	public CreateEffectOnSell() { }

	public virtual TowerBehaviorModel get_Def() { }

}

