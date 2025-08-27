namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(BloonsPoppedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonsPoppedTriggerModel : MapTriggerModel
{
	public Vector3 position; //Field offset: 0x38
	public int requiredBloons; //Field offset: 0x44
	public float radius; //Field offset: 0x48
	public float cooldown; //Field offset: 0x4C

	public BloonsPoppedTriggerModel(string name, Vector3 position, int requiredBloons, float radius, float cooldown) { }

}

