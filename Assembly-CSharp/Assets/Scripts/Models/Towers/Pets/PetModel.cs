namespace Assets.Scripts.Models.Towers.Pets;

public abstract class PetModel : TowerBehaviorModel
{
	public PetBehaviorModel[] behaviors; //Field offset: 0x30
	public bool isFlying; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40

	public PetModel(string name, bool isFlying, PrefabReference display, PetBehaviorModel[] behaviors) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

