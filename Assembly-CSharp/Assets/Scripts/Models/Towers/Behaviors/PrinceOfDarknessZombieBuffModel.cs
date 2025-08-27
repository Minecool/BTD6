namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PrinceOfDarknessZombieBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PrinceOfDarknessZombieBuffModel : TowerBehaviorBuffModel
{
	public float damageIncrease; //Field offset: 0x48
	public float distanceMultiplier; //Field offset: 0x4C

	public PrinceOfDarknessZombieBuffModel(string name, float damageIncrease, float distanceMultiplier, string buffLocsName, string buffIconName, bool isGlobalRange) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

