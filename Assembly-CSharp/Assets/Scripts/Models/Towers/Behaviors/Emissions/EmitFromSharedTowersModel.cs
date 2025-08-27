namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(EmitFromSharedTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmitFromSharedTowersModel : EmissionModel
{
	public bool isUsingSharedRange; //Field offset: 0x38
	public String[] sharedTowerTypes; //Field offset: 0x40

	public EmitFromSharedTowersModel(string name, bool isUsingSharedRange, String[] sharedTowerTypes, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

