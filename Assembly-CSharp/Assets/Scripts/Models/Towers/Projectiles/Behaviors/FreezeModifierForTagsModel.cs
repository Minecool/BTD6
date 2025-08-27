namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(FreezeModifierForTags), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreezeModifierForTagsModel : ProjectileBehaviorModel
{
	public String[] tags; //Field offset: 0x38
	public string freezeId; //Field offset: 0x40
	public float freezeTimeMultiplier; //Field offset: 0x48
	public bool resetToUnmodified; //Field offset: 0x4C
	public bool preventMutation; //Field offset: 0x4D

	public FreezeModifierForTagsModel(string name, String[] tags, string freezeId, float freezeTimeMultiplier, bool resetToUnmodified, bool preventMutation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

