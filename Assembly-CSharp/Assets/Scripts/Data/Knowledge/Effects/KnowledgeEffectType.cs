namespace Assets.Scripts.Data.Knowledge.Effects;

[Flags]
public enum KnowledgeEffectType
{
	Tower = 1,
	Bloon = 2,
	Power = 4,
	Simulation = 8,
	StartingCash = 16,
	ContestedTerritoryRules = 32,
	TowerDiscount = 64,
}

