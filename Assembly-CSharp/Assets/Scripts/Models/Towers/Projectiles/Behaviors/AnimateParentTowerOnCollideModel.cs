namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AnimateParentTowerOnCollide), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimateParentTowerOnCollideModel : ProjectileBehaviorModel
{
	public int animationState; //Field offset: 0x38
	public float minTimeBetween; //Field offset: 0x3C
	public int minTimeBetweenFrames; //Field offset: 0x40

	public AnimateParentTowerOnCollideModel(string name, int animationState, float minTimeBetween) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

