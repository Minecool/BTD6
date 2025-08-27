namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "SwitchAnimStateForBloonType", menuName = "BTD6/Behaviors/Weapons/SwitchAnimStateForBloonType")]
public class SwitchAnimStateForBloonType : WeaponBehavior
{
	public int nonMoabsAnimId; //Field offset: 0x30
	public int moabAnimId; //Field offset: 0x34
	public int bfbAnimId; //Field offset: 0x38
	public int zomgAnimId; //Field offset: 0x3C
	public int ddtAnimId; //Field offset: 0x40
	public int badAnimId; //Field offset: 0x44

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 173
	}

	public SwitchAnimStateForBloonType() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

