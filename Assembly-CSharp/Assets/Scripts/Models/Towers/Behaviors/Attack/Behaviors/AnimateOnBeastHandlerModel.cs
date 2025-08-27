namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(AnimateOnBeastHandler), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimateOnBeastHandlerModel : AttackBehaviorModel
{
	public int animationStateMinParent; //Field offset: 0x30
	public int animationStateMaxParent; //Field offset: 0x34
	public int animationStateMinContributor; //Field offset: 0x38
	public int animationStateMaxContributor; //Field offset: 0x3C

	public AnimateOnBeastHandlerModel(string name, int animationStateMinParent, int animationStateMaxParent, int animationStateMinContributor, int animationStateMaxContributor) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

