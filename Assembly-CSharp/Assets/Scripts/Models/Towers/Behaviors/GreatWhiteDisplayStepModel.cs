namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(GreatWhiteDisplayStep), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GreatWhiteDisplayStepModel : TowerBehaviorModel
{
	public PrefabReference portalEffectDisplay; //Field offset: 0x30
	public PrefabReference noGrabEffectDisplay; //Field offset: 0x38
	public float percent; //Field offset: 0x40

	public GreatWhiteDisplayStepModel(string name, PrefabReference portalEffectDisplay, PrefabReference noGrabEffectDisplay, float percent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

