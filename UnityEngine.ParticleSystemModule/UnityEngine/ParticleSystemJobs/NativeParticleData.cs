namespace UnityEngine.ParticleSystemJobs;

internal struct NativeParticleData
{
	public struct Array3
	{
		internal Single* x; //Field offset: 0x0
		internal Single* y; //Field offset: 0x8
		internal Single* z; //Field offset: 0x10

	}

	public struct Array4
	{
		internal Single* x; //Field offset: 0x0
		internal Single* y; //Field offset: 0x8
		internal Single* z; //Field offset: 0x10
		internal Single* w; //Field offset: 0x18

	}

	internal int count; //Field offset: 0x0
	internal Array3 positions; //Field offset: 0x8
	internal Array3 velocities; //Field offset: 0x20
	internal Array3 axisOfRotations; //Field offset: 0x38
	internal Array3 rotations; //Field offset: 0x50
	internal Array3 rotationalSpeeds; //Field offset: 0x68
	internal Array3 sizes; //Field offset: 0x80
	internal Void* startColors; //Field offset: 0x98
	internal Void* aliveTimePercent; //Field offset: 0xA0
	internal Void* inverseStartLifetimes; //Field offset: 0xA8
	internal Void* randomSeeds; //Field offset: 0xB0
	internal Array4 customData1; //Field offset: 0xB8
	internal Array4 customData2; //Field offset: 0xD8
	internal Void* meshIndices; //Field offset: 0xF8

}

