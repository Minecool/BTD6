namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AngleToMapCenter", menuName = "BTD6/Behaviors/Weapons/AngleToMapCenter")]
public class AngleToMapCenter : WeaponBehavior
{
	public float range; //Field offset: 0x30
	public float offset; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public AngleToMapCenter() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

