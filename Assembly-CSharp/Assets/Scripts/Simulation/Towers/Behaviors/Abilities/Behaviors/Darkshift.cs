namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Darkshift : AbilityBehavior
{
	public DarkshiftModel darkshiftModel; //Field offset: 0x68
	private bool shifting; //Field offset: 0x70
	private Vector2 teleportPos; //Field offset: 0x74
	private int frameToMove; //Field offset: 0x7C
	private CustomInputData rData; //Field offset: 0x80

	public bool Shifting
	{
		 get { } //Length: 5
	}

	public Darkshift() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	private void EndDarkshift() { }

	public bool get_Shifting() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayDarkshiftSound() { }

	private void Process(int elapsed) { }

	private void StartDarkshift(Vector2 newPos) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

