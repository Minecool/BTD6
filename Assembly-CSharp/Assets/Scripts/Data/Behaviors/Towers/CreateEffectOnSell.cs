namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnSell", menuName = "BTD6/Behaviors/Towers/CreateEffectOnSell")]
public class CreateEffectOnSell : TowerBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public CreateEffectOnSell() { }

	public virtual TowerBehaviorModel get_Def() { }

}

