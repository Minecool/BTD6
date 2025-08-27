namespace Assets.Scripts.Data.Knowledge.Effects;

public class KnowledgeEffect
{
	public KnowledgeEffectType type; //Field offset: 0x10
	public String[] targets; //Field offset: 0x18
	public MutatorModModel[] mutators; //Field offset: 0x20

	public KnowledgeEffect(KnowledgeEffectType type, String[] targets, MutatorModModel mutator) { }

	public KnowledgeEffect(KnowledgeEffectType type, String[] targets, MutatorModModel[] mutators) { }

	public bool TargetsBloon(BloonModel bloon) { }

	public bool TargetsPower(PowerModel power) { }

	public bool TargetsTower(TowerModel tower) { }

}

