namespace Assets.Scripts.Simulation.Map.Triggers;

public class PreBloonSpawnTrigger : MapTrigger
{
	public string bloonTag; //Field offset: 0x80

	public PreBloonSpawnTrigger() { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnPreBloonSpawn(BloonModel bloonModel) { }

}

