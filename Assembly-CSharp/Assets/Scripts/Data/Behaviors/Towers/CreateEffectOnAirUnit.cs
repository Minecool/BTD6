namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnAirUnit", menuName = "BTD6/Behaviors/Towers/CreateEffectOnAirUnit")]
public class CreateEffectOnAirUnit : TowerBehavior
{
	public Effect effect; //Field offset: 0x30
	public float rotation; //Field offset: 0x38
	public float scale; //Field offset: 0x3C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 260
	}

	public CreateEffectOnAirUnit() { }

	public virtual TowerBehaviorModel get_Def() { }

}

