namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "EjectAnimation", menuName = "BTD6/Behaviors/Weapons/EjectAnimation")]
public class EjectAnimation : WeaponBehavior
{
	public int animationState; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public EjectAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

