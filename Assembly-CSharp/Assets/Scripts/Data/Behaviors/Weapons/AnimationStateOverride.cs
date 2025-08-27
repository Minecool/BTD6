namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AnimationStateOverride", menuName = "BTD6/Behaviors/Weapons/AnimationStateOverride")]
public class AnimationStateOverride : WeaponBehavior
{
	public int stateFrom; //Field offset: 0x30
	public int stateTo; //Field offset: 0x34
	public int overrideWith; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 145
	}

	public AnimationStateOverride() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

