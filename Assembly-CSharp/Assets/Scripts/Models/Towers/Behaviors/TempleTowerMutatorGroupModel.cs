namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TempleTowerMutatorGroup), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TempleTowerMutatorGroupModel : TowerMutatorGroupModel
{
	public int cost; //Field offset: 0x38
	public TowerSet towerSet; //Field offset: 0x3C

	public TempleTowerMutatorGroupModel(string name, TowerMutatorModel[] mutators, int cost, TowerSet towerSet) { }

	public virtual Model Clone() { }

}

