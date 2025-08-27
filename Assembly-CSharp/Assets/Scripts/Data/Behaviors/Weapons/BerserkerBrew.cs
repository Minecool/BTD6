namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "BerserkerBrew", menuName = "BTD6/Behaviors/Weapons/BerserkerBrew")]
public class BerserkerBrew : EntityBehavior<WeaponBehaviorModel>
{
	public float damageUp; //Field offset: 0x28
	public float pierceUp; //Field offset: 0x2C
	public float rateUp; //Field offset: 0x30
	public float rangeUp; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public BerserkerBrew() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

