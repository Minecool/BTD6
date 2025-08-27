namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(LatchToBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LatchToBloonModel : ProjectileBehaviorModel
{
	public bool rotateWithBloon; //Field offset: 0x38
	public int animationStateOnSetTarget; //Field offset: 0x3C
	public int animationStateOnTowerOnDestroy; //Field offset: 0x40
	public float postBloonDestroyTime; //Field offset: 0x44
	public int postBloonDestroyTimeFrames; //Field offset: 0x48
	public float bloonSpeedMultiplier; //Field offset: 0x4C
	private SlowMutator slowMutator; //Field offset: 0x50

	public SlowMutator SlowMutator
	{
		 get { } //Length: 284
	}

	public LatchToBloonModel(string name, bool rotateWithBloon, int animationStateOnSetTarget, int animationStateOnTowerOnDestroy, float postBloonDestroyTime, float bloonSpeedMultiplier) { }

	public virtual Model Clone() { }

	public SlowMutator get_SlowMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

