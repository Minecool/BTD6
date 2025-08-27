namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateEffectOnAirUnit : TowerBehavior
{
	public CreateEffectOnAirUnit parent; //Field offset: 0x98
	public Effect effect; //Field offset: 0xA0
	public Effect expEffect; //Field offset: 0xA8
	public float rotation; //Field offset: 0xB0
	public string expRotation; //Field offset: 0xB8
	public float scale; //Field offset: 0xC0
	public string expScale; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 256
	}

	public CreateEffectOnAirUnit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

