namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateEffectOnUpgrade", menuName = "BTD6/Behaviors/Towers/CreateEffectOnUpgrade")]
public class CreateEffectOnUpgrade : TowerBehavior
{
	public Effect effect; //Field offset: 0x30
	public bool createOnAirUnit; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public CreateEffectOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

