namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateEffectOnUpgrade : TowerBehavior
{
	public CreateEffectOnUpgrade parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8
	public bool createOnAirUnit; //Field offset: 0xB0
	public string expCreateOnAirUnit; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 225
	}

	public CreateEffectOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

