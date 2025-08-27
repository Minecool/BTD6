namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MultiHookManager), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MultiHookManagerModel : TowerBehaviorModel
{
	[SerializeField]
	private float minTimeBetweenHooks; //Field offset: 0x30
	public int minTimeBetweenHooksFrames; //Field offset: 0x34
	[SerializeField]
	private float reloadTime; //Field offset: 0x38
	public int reloadTimeFrames; //Field offset: 0x3C

	public MultiHookManagerModel(string name, float minTimeBetweenHooks, float reloadTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

