namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SlowForBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowForBloonModel : SlowModel
{
	public string bloonId; //Field offset: 0x88
	public String[] bloonIds; //Field offset: 0x90
	public string bloonTag; //Field offset: 0x98
	public String[] bloonTags; //Field offset: 0xA0
	public bool excluding; //Field offset: 0xA8

	public SlowForBloonModel(string name, float multiplier, float lifespan, string mutationId, int layers, string overlayType, bool isUnique, bool dontRefreshDuration, string bloonId, string bloonTag, bool excluding, EffectModel effectModel, bool cascadeMutators, bool removeMutatorIfNotMatching, bool countGlueAchievement, int glueLevel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

