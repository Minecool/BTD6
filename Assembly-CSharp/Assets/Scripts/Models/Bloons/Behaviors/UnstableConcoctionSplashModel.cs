namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(UnstableConcoctionSplash), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class UnstableConcoctionSplashModel : EmitOnPopModel
{
	public Dictionary<String, Single> baseIdToBloonDmg; //Field offset: 0x50
	public float defaultBloonDmg; //Field offset: 0x58
	public Dictionary<String, Single> baseIdToMoabDmg; //Field offset: 0x60
	public float bossToMoabDmg; //Field offset: 0x68
	public float defaultMoabDmg; //Field offset: 0x6C

	public UnstableConcoctionSplashModel(string name, ProjectileModel projectile, EmissionModel emission, ObjectId tower, Dictionary<String, Single> baseIdToBloonDmg, float defaultBloonDmg, Dictionary<String, Single> baseIdToMoabDmg, float bossToMoabDmg, float defaultMoabDmg) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

