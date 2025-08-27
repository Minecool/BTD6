namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AnimateAirUnitOnFire", menuName = "BTD6/Behaviors/Weapons/AnimateAirUnitOnFire")]
public class AnimateAirUnitOnFire : WeaponBehavior
{
	public int animationState; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public AnimateAirUnitOnFire() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

