namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ActivateAbilityAfterInterval : TowerBehavior
{
	public ActivateAbilityAfterInterval parent; //Field offset: 0x98
	public Ability ability; //Field offset: 0xA0
	public Ability expAbility; //Field offset: 0xA8
	public float interval; //Field offset: 0xB0
	public string expInterval; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 248
	}

	public ActivateAbilityAfterInterval() { }

	public virtual TowerBehaviorModel get_Def() { }

}

