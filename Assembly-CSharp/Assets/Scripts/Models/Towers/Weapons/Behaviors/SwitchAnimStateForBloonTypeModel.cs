namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(SwitchAnimStateForBloonType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwitchAnimStateForBloonTypeModel : WeaponBehaviorModel
{
	public int nonMoabsAnimId; //Field offset: 0x30
	public int moabAnimId; //Field offset: 0x34
	public int bfbAnimId; //Field offset: 0x38
	public int zomgAnimId; //Field offset: 0x3C
	public int ddtAnimId; //Field offset: 0x40
	public int badAnimId; //Field offset: 0x44

	public SwitchAnimStateForBloonTypeModel(string name, int nonMoabsAnimId, int moabAnimId, int bfbAnimId, int zomgAnimId, int ddtAnimId, int badAnimId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

