namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DamageOverTimeForTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageOverTimeForTagModel : DamageOverTimeModel
{
	public string tag; //Field offset: 0x80

	public DamageOverTimeForTagModel(string name, float damage, float interval, BloonProperties immuneBloonProperties, BloonProperties immuneBloonPropertiesOriginal, string tag, ObjectId tower, DamageModifierModel[] damageModifierModels, bool isFireBased) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

