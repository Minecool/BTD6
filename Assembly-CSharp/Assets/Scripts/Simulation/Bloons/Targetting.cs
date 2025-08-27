namespace Assets.Scripts.Simulation.Bloons;

public static class Targetting
{
	private static readonly List<Target> tempTargetList; //Field offset: 0x0

	private static Targetting() { }

	private static bool AddTemporaryTarget(Target target, int count) { }

	public static bool CanHitMoab(Bloon bloon, PathSegmentInRange seg, out Vector3 offset, float range, Vector3 position, bool usingSharedRange, Map map) { }

	public static void ClearTemporaryTargets() { }

	private static bool GetGlobalBest(TargetType targetType, out Target best, Map map, List<PathSegmentInRange> brackets, BloonFilter filter, float range, Vector3 position, bool cantTargetMoab, bool cantTargetCamo, bool usingSharedRange) { }

	public static Target GetTarget(Simulation sim, float range, TargetType targetType, Vector3 position, List<PathSegmentInRange> brackets, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false, bool usingSharedRange = false, bool attackThroughWalls = false) { }

	public static List<Target> GetTargets(Simulation sim, int count, float range, TargetType targetType, Vector3 position, List<PathSegmentInRange> brackets, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false, bool usingSharedRange = false, bool attackThroughWalls = false) { }

	public static bool QuickTargetCheck(Map map, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false, bool usingSharedRange = false) { }

}

