namespace Assets.Scripts.Models.Towers.Mods;

public class GrantCamoDetectForAbilityModModel : MutatorModModel
{
	public string mutatorId; //Field offset: 0x30
	public bool useAbilityDuration; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public GrantCamoDetectForAbilityModModel(string name, float lifespan, string mutatorId, bool useAbilityDuration) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

	public void set_Lifespan(float value) { }

}

