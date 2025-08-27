namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateSoundOnDelayedCollision), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnDelayedCollisionModel : ProjectileBehaviorModel
{
	public SoundModel sound1; //Field offset: 0x38
	public SoundModel sound2; //Field offset: 0x40
	public SoundModel sound3; //Field offset: 0x48
	public SoundModel sound4; //Field offset: 0x50
	public float delay; //Field offset: 0x58

	public CreateSoundOnDelayedCollisionModel(string name, float delay, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

