namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnAirUnitDestroy", menuName = "BTD6/Behaviors/Towers/CreateEffectOnAirUnitDestroy")]
public class CreateEffectOnAirUnitDestroy : TowerBehavior
{
	public Effect effect; //Field offset: 0x30
	public float rotation; //Field offset: 0x38
	public float scale; //Field offset: 0x3C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 249
	}

	public CreateEffectOnAirUnitDestroy() { }

	public virtual TowerBehaviorModel get_Def() { }

}

