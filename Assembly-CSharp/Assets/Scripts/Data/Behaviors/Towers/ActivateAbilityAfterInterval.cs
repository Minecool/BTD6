namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ActivateAbilityAfterInterval", menuName = "BTD6/Behaviors/Towers/ActivateAbilityAfterInterval")]
public class ActivateAbilityAfterInterval : TowerBehavior
{
	public Ability ability; //Field offset: 0x30
	public float interval; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 297
	}

	public ActivateAbilityAfterInterval() { }

	public virtual TowerBehaviorModel get_Def() { }

	public void OnEnable() { }

}

