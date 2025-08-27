namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateEffectOnPlace : TowerBehavior
{
	public CreateEffectOnPlace parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public CreateEffectOnPlace() { }

	public virtual TowerBehaviorModel get_Def() { }

}

