namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SetSpriteFromPierce), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetSpriteFromPierceModel : ProjectileBehaviorModel
{
	public PrefabReference[] sprites; //Field offset: 0x38
	public string loopMode; //Field offset: 0x40

	public SetSpriteFromPierceModel(string name, PrefabReference[] sprites, string loopMode) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

