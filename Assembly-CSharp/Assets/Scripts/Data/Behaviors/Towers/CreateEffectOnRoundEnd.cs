namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnRoundEnd", menuName = "BTD6/Behaviors/Towers/CreateEffectOnRoundEnd")]
public class CreateEffectOnRoundEnd : TowerBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public CreateEffectOnRoundEnd() { }

	public virtual TowerBehaviorModel get_Def() { }

}

