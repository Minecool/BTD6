namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreatePropsOnBloonAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreatePropsOnBloonActionModel : BloonBehaviorActionModel
{
	public float rockCircleRadius; //Field offset: 0x38
	public int rockAmount; //Field offset: 0x3C
	public float rockDuration; //Field offset: 0x40
	public int rockPropId; //Field offset: 0x44
	public PrefabReference expireEffect; //Field offset: 0x48
	public float expireEffectDuration; //Field offset: 0x50
	public float propScale; //Field offset: 0x54

	public CreatePropsOnBloonActionModel() { }

	public CreatePropsOnBloonActionModel(string name, string actionId, float rockCircleRadius, int rockAmount, float rockDuration, int rockPropId, PrefabReference expireEffect, float expireEffectDuration, float propScale) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

