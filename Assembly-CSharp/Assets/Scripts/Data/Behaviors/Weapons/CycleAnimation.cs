namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CycleAnimation", menuName = "BTD6/Behaviors/Weapons/CycleAnimation")]
public class CycleAnimation : WeaponBehavior
{
	public int minAnimationState; //Field offset: 0x30
	public int maxAnimationState; //Field offset: 0x34
	public string loopMode; //Field offset: 0x38
	public bool randomize; //Field offset: 0x40

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 152
	}

	public CycleAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

