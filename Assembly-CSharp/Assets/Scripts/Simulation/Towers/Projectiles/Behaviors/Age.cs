namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Age : ProjectileBehavior
{
	public AgeModel ageModel; //Field offset: 0x68
	protected int roundsLeft; //Field offset: 0x70
	protected int createdAt; //Field offset: 0x74
	protected int lifespanFrames; //Field offset: 0x78

	public int OwnerAge
	{
		 get { } //Length: 155
	}

	public Age() { }

	public int get_OwnerAge() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnRoundPassed() { }

	public void Process(int elapsed) { }

	public void ResetAge() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SetToExpire() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

