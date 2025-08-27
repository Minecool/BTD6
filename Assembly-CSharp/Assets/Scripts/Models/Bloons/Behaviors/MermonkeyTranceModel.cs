namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(MermonkeyTrance), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MermonkeyTranceModel : BloonBehaviorModel
{
	public int durationFrames; //Field offset: 0x30
	public float orbitRadius; //Field offset: 0x34
	public float bloonOrbitSpeedMultiplier; //Field offset: 0x38
	public float moabOrbitSpeed; //Field offset: 0x3C
	public int cooldownFrames; //Field offset: 0x40
	public float radiusBloonSizeMultiplier; //Field offset: 0x44

	public MermonkeyTranceModel() { }

	public MermonkeyTranceModel(string name, int durationFrames, float orbitRadius, float bloonOrbitSpeedMultiplier, int cooldownFrames, float radiusBloonSizeMultiplier, float moabOrbitSpeed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

