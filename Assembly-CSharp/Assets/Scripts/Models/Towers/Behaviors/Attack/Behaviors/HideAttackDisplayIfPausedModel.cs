namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(HideAttackDisplayIfPaused), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HideAttackDisplayIfPausedModel : AttackBehaviorModel
{
	public int animationStateOnReveal; //Field offset: 0x30

	public HideAttackDisplayIfPausedModel(string name, int animationStateOnReveal) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

