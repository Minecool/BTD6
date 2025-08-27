namespace Assets.Scripts.Models.Rounds;

public class BloonEmissionModel : Model
{
	public string bloon; //Field offset: 0x30
	public float time; //Field offset: 0x38
	public int emissionIndex; //Field offset: 0x3C
	public bool isCustomBossEmission; //Field offset: 0x40
	public TowerSet towerSetImmunity; //Field offset: 0x44

	public BloonEmissionModel(string name, float time = 30, string bloon = null, bool isCustomBossEmission = false, TowerSet towerSetImmunity = 0) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

