namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BeastHandlerPetDisplayStep), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BeastHandlerPetDisplayStepModel : TowerBehaviorModel
{
	public PrefabReference display; //Field offset: 0x30
	public PrefabReference projectileDisplay; //Field offset: 0x38
	public float percent; //Field offset: 0x40

	public BeastHandlerPetDisplayStepModel(string name, PrefabReference display, PrefabReference projectileDisplay, float percent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

