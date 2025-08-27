namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SlowModifierForTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowModifierForTagModel : ProjectileBehaviorModel
{
	public string tag; //Field offset: 0x38
	public string slowId; //Field offset: 0x40
	public float slowMultiplier; //Field offset: 0x48
	public bool resetToUnmodified; //Field offset: 0x4C
	public bool preventMutation; //Field offset: 0x4D
	public float lifespanOverride; //Field offset: 0x50
	public bool makeNotTag; //Field offset: 0x54

	public SlowModifierForTagModel(string name, string tag, string slowId, float slowMultiplier, bool resetToUnmodified, bool preventMutation, float lifespanOverride, bool makeNotTag) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

