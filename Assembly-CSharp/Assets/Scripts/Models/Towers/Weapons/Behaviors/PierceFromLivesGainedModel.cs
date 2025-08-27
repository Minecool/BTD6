namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(PierceFromLivesGained), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PierceFromLivesGainedModel : WeaponBehaviorModel
{
	public float piercePercentPerLife; //Field offset: 0x30
	public int lifeCap; //Field offset: 0x34
	public string saveId; //Field offset: 0x38

	public PierceFromLivesGainedModel(string name, float piercePercentPerLife, int lifeCap, string saveId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

