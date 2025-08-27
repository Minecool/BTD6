namespace UnityEngine.Rendering;

[Extension]
internal static class LODGroupRenderingUtils
{

	public static float CalculateFOVHalfAngle(float fieldOfView) { }

	public static float CalculateLODDistance(float relativeScreenHeight, float size) { }

	public static float CalculateScreenRelativeMetric(LODParameters lodParams, float lodBias) { }

	public static float CalculateSqrPerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

}

