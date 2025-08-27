namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(GoldenBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GoldenBloonModel : BloonBehaviorModel
{
	public PrefabReference damageFX; //Field offset: 0x30
	public PrefabReference rewardText; //Field offset: 0x38
	public float rewardTextLifeTime; //Field offset: 0x40
	[SerializeField]
	private float invulnerableTime; //Field offset: 0x44
	[SerializeField]
	private float cantJumpTime; //Field offset: 0x48
	[SerializeField]
	private float speedIncreaseTime; //Field offset: 0x4C
	public float speedIncreaseWhenDamaged; //Field offset: 0x50
	public int jumpChanceTotal; //Field offset: 0x54
	public int jumpChanceForward; //Field offset: 0x58
	public int jumpChanceBackward; //Field offset: 0x5C
	public float minJumpDist; //Field offset: 0x60
	public float maxJumpDistPercOfTrack; //Field offset: 0x64
	public float jumpSpeedMultiplier; //Field offset: 0x68
	public int invulnerableTimeFrames; //Field offset: 0x6C
	public int cantJumpTimeFrames; //Field offset: 0x70
	public int speedIncreaseTimeFrames; //Field offset: 0x74

	public GoldenBloonModel() { }

	public GoldenBloonModel(string name, PrefabReference damageFX, PrefabReference rewardText, float rewardTextLifeTime, float invulnerableTime, float cantJumpTime, float speedIncreaseWhenDamaged, float speedIncreaseTime, int jumpChanceTotal, int jumpChanceForward, int jumpChanceBackward, float minJumpDist, float maxJumpDistPercOfTrack, float jumpSpeedMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

