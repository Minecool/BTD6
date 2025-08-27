namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(Pet), True, True, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetModelUnsynced : PetModel
{

	public PetModelUnsynced(string name, bool isFlying, PrefabReference display, PetBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

}

