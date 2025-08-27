namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnPlace", menuName = "BTD6/Behaviors/Towers/CreateEffectOnPlace")]
public class CreateEffectOnPlace : TowerBehavior
{
	public Effect effect; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 146
	}

	public CreateEffectOnPlace() { }

	public virtual TowerBehaviorModel get_Def() { }

}

