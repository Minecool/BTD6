namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(MoveWithWind), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoveWithWindModel : BloonBehaviorModel
{
	public float distanceMin; //Field offset: 0x30
	public float distanceMax; //Field offset: 0x34
	public float distanceScaleForTags; //Field offset: 0x38
	public string distanceScaleForTagsTags; //Field offset: 0x40
	public String[] distanceScaleForTagsTagsList; //Field offset: 0x48
	public float speedMultiplier; //Field offset: 0x50

	public MoveWithWindModel() { }

	public MoveWithWindModel(string name, float distanceMin, float distanceMax, float distanceScaleForTags, string distanceScaleForTagsTags, float speedMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

