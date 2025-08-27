namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnTowerExpire", menuName = "BTD6/Behaviors/Towers/CreateEffectOnTowerExpire")]
public class CreateEffectOnTowerExpire : TowerBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public CreateEffectOnTowerExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

