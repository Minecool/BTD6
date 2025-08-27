namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

public class OrbitBloonProjectileMutator : BehaviorMutator
{
	public float speedMultiplier; //Field offset: 0x70
	public int duration; //Field offset: 0x74
	public int cooldown; //Field offset: 0x78
	public float orbitRadius; //Field offset: 0x7C
	public float radiusBloonSizeMultiplier; //Field offset: 0x80
	public float moabOrbitSpeedMultiplier; //Field offset: 0x84

	public OrbitBloonProjectileMutator(float speedMultiplier, int duration, float orbitRadius, int cooldown, float radiusBloonSizeMultiplier, float moabOrbitSpeedMultiplier) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

