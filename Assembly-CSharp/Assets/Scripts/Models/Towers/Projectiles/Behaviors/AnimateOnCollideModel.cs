namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AnimateOnCollide), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimateOnCollideModel : ProjectileBehaviorModel
{
	public int animationState; //Field offset: 0x38

	public AnimateOnCollideModel(string name, int animationState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

