namespace Assets.Scripts.Models.GenericBehaviors;

[Flags]
public enum DisplayCategory
{
	None = 0,
	Default = 1,
	Bloon = 2,
	Tower = 4,
	Prop = 8,
	Projectile = 16,
	Effect = 32,
	Buff = 64,
	Overlay = 128,
	Pet = 256,
}

