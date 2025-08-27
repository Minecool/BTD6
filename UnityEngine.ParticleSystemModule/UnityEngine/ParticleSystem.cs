namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	internal struct CollisionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CollisionModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ColorBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct CustomDataModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CustomDataModule(ParticleSystem particleSystem) { }

	}

	internal struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public bool enabled
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 66
		}

		public MinMaxCurve rateOverTime
		{
			[NativeThrows]
			 set { } //Length: 66
		}

		public float rateOverTimeMultiplier
		{
			 get { } //Length: 51
		}

		internal EmissionModule(ParticleSystem particleSystem) { }

		public bool get_enabled() { }

		private static bool get_enabled_Injected(ref EmissionModule _unity_self) { }

		public float get_rateOverTimeMultiplier() { }

		private static float get_rateOverTimeMultiplier_Injected(ref EmissionModule _unity_self) { }

		[NativeThrows]
		public void set_enabled(bool value) { }

		private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value) { }

		[NativeThrows]
		public void set_rateOverTime(MinMaxCurve value) { }

		private static void set_rateOverTime_Injected(ref EmissionModule _unity_self, ref MinMaxCurve value) { }

	}

	internal struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle; //Field offset: 0x0
		[NativeName("positionSet")]
		private bool m_PositionSet; //Field offset: 0x84
		[NativeName("velocitySet")]
		private bool m_VelocitySet; //Field offset: 0x85
		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[NativeName("rotationSet")]
		private bool m_RotationSet; //Field offset: 0x87
		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[NativeName("startSizeSet")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[NativeName("startColorSet")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	internal struct ExternalForcesModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ExternalForcesModule(ParticleSystem particleSystem) { }

	}

	internal struct ForceOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ForceOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct InheritVelocityModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal InheritVelocityModule(ParticleSystem particleSystem) { }

	}

	internal struct LifetimeByEmitterSpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct LightsModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LightsModule(ParticleSystem particleSystem) { }

	}

	internal struct LimitVelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float duration
		{
			 get { } //Length: 51
		}

		public float gravityModifierMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public bool loop
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 66
		}

		public int maxParticles
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 64
		}

		public bool playOnAwake
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 66
		}

		public ParticleSystemScalingMode scalingMode
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 64
		}

		public ParticleSystemSimulationSpace simulationSpace
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 64
		}

		public float simulationSpeed
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public MinMaxGradient startColor
		{
			 get { } //Length: 89
			[NativeThrows]
			 set { } //Length: 66
		}

		public MinMaxCurve startDelay
		{
			 get { } //Length: 79
		}

		public float startDelayMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public MinMaxCurve startLifetime
		{
			 get { } //Length: 79
		}

		public float startLifetimeMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		[NativeName("StartRotationZMultiplier")]
		public float startRotationMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public float startRotationXMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public float startRotationYMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public float startRotationZMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		[NativeName("StartSizeXMultiplier")]
		public float startSizeMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		public float startSpeedMultiplier
		{
			 get { } //Length: 51
			[NativeThrows]
			 set { } //Length: 67
		}

		internal MainModule(ParticleSystem particleSystem) { }

		public float get_duration() { }

		private static float get_duration_Injected(ref MainModule _unity_self) { }

		public float get_gravityModifierMultiplier() { }

		private static float get_gravityModifierMultiplier_Injected(ref MainModule _unity_self) { }

		public bool get_loop() { }

		private static bool get_loop_Injected(ref MainModule _unity_self) { }

		public int get_maxParticles() { }

		private static int get_maxParticles_Injected(ref MainModule _unity_self) { }

		public bool get_playOnAwake() { }

		private static bool get_playOnAwake_Injected(ref MainModule _unity_self) { }

		public ParticleSystemScalingMode get_scalingMode() { }

		private static ParticleSystemScalingMode get_scalingMode_Injected(ref MainModule _unity_self) { }

		public ParticleSystemSimulationSpace get_simulationSpace() { }

		private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self) { }

		public float get_simulationSpeed() { }

		private static float get_simulationSpeed_Injected(ref MainModule _unity_self) { }

		public MinMaxGradient get_startColor() { }

		private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret) { }

		public MinMaxCurve get_startDelay() { }

		private static void get_startDelay_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		public float get_startDelayMultiplier() { }

		private static float get_startDelayMultiplier_Injected(ref MainModule _unity_self) { }

		public MinMaxCurve get_startLifetime() { }

		private static void get_startLifetime_Injected(ref MainModule _unity_self, out MinMaxCurve ret) { }

		public float get_startLifetimeMultiplier() { }

		private static float get_startLifetimeMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationMultiplier() { }

		private static float get_startRotationMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationXMultiplier() { }

		private static float get_startRotationXMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationYMultiplier() { }

		private static float get_startRotationYMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startRotationZMultiplier() { }

		private static float get_startRotationZMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startSizeMultiplier() { }

		private static float get_startSizeMultiplier_Injected(ref MainModule _unity_self) { }

		public float get_startSpeedMultiplier() { }

		private static float get_startSpeedMultiplier_Injected(ref MainModule _unity_self) { }

		[NativeThrows]
		public void set_gravityModifierMultiplier(float value) { }

		private static void set_gravityModifierMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_loop(bool value) { }

		private static void set_loop_Injected(ref MainModule _unity_self, bool value) { }

		[NativeThrows]
		public void set_maxParticles(int value) { }

		private static void set_maxParticles_Injected(ref MainModule _unity_self, int value) { }

		[NativeThrows]
		public void set_playOnAwake(bool value) { }

		private static void set_playOnAwake_Injected(ref MainModule _unity_self, bool value) { }

		[NativeThrows]
		public void set_scalingMode(ParticleSystemScalingMode value) { }

		private static void set_scalingMode_Injected(ref MainModule _unity_self, ParticleSystemScalingMode value) { }

		[NativeThrows]
		public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

		private static void set_simulationSpace_Injected(ref MainModule _unity_self, ParticleSystemSimulationSpace value) { }

		[NativeThrows]
		public void set_simulationSpeed(float value) { }

		private static void set_simulationSpeed_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startColor(MinMaxGradient value) { }

		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value) { }

		[NativeThrows]
		public void set_startDelayMultiplier(float value) { }

		private static void set_startDelayMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startLifetimeMultiplier(float value) { }

		private static void set_startLifetimeMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startRotationMultiplier(float value) { }

		private static void set_startRotationMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startRotationXMultiplier(float value) { }

		private static void set_startRotationXMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startRotationYMultiplier(float value) { }

		private static void set_startRotationYMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startRotationZMultiplier(float value) { }

		private static void set_startRotationZMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startSizeMultiplier(float value) { }

		private static void set_startSizeMultiplier_Injected(ref MainModule _unity_self, float value) { }

		[NativeThrows]
		public void set_startSpeedMultiplier(float value) { }

		private static void set_startSpeedMultiplier_Injected(ref MainModule _unity_self, float value) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct MinMaxCurve
	{
		[SerializeField]
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private float m_CurveMultiplier; //Field offset: 0x4
		[SerializeField]
		private AnimationCurve m_CurveMin; //Field offset: 0x8
		[SerializeField]
		private AnimationCurve m_CurveMax; //Field offset: 0x10
		[SerializeField]
		private float m_ConstantMin; //Field offset: 0x18
		[SerializeField]
		private float m_ConstantMax; //Field offset: 0x1C

		public float constant
		{
			 get { } //Length: 8
		}

		public ParticleSystemCurveMode mode
		{
			 get { } //Length: 5
		}

		public MinMaxCurve(float constant) { }

		public float Evaluate(float time) { }

		public float Evaluate(float time, float lerpFactor) { }

		public float get_constant() { }

		public ParticleSystemCurveMode get_mode() { }

		public static MinMaxCurve op_Implicit(float constant) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct MinMaxGradient
	{
		[SerializeField]
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[SerializeField]
		private Gradient m_GradientMin; //Field offset: 0x8
		[SerializeField]
		private Gradient m_GradientMax; //Field offset: 0x10
		[SerializeField]
		private Color m_ColorMin; //Field offset: 0x18
		[SerializeField]
		private Color m_ColorMax; //Field offset: 0x28

		public Color color
		{
			 get { } //Length: 11
		}

		public MinMaxGradient(Color color) { }

		public Color get_color() { }

		public static MinMaxGradient op_Implicit(Color color) { }

	}

	internal struct NoiseModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal NoiseModule(ParticleSystem particleSystem) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	internal struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private uint m_ParentRandomSeed; //Field offset: 0x68
		private float m_Lifetime; //Field offset: 0x6C
		private float m_StartLifetime; //Field offset: 0x70
		private int m_MeshIndex; //Field offset: 0x74
		private float m_EmitAccumulator0; //Field offset: 0x78
		private float m_EmitAccumulator1; //Field offset: 0x7C
		private uint m_Flags; //Field offset: 0x80

		public Vector3 angularVelocity3D
		{
			 set { } //Length: 63
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		public float lifetime
		{
			 set { } //Length: 6
		}

		public Vector3 position
		{
			 set { } //Length: 15
		}

		public uint randomSeed
		{
			 set { } //Length: 4
		}

		public float remainingLifetime
		{
			 set { } //Length: 6
		}

		public Vector3 rotation3D
		{
			 set { } //Length: 63
		}

		public Color32 startColor
		{
			 set { } //Length: 4
		}

		public float startLifetime
		{
			 set { } //Length: 6
		}

		public float startSize
		{
			 set { } //Length: 17
		}

		public Vector3 velocity
		{
			 set { } //Length: 16
		}

		public void set_angularVelocity3D(Vector3 value) { }

		public void set_lifetime(float value) { }

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_remainingLifetime(float value) { }

		public void set_rotation3D(Vector3 value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}

	internal struct PlaybackState
	{
		public struct Collision
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Emission
		{
			public float m_ParticleSpacing; //Field offset: 0x0
			public float m_ToEmitAccumulator; //Field offset: 0x4
			public Seed m_Random; //Field offset: 0x8

		}

		public struct Force
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Initial
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Lights
		{
			public Seed m_Random; //Field offset: 0x0
			public float m_ParticleEmissionCounter; //Field offset: 0x10

		}

		public struct Noise
		{
			public float m_ScrollOffset; //Field offset: 0x0

		}

		public struct Seed
		{
			public uint x; //Field offset: 0x0
			public uint y; //Field offset: 0x4
			public uint z; //Field offset: 0x8
			public uint w; //Field offset: 0xC

		}

		public struct Seed4
		{
			public Seed x; //Field offset: 0x0
			public Seed y; //Field offset: 0x10
			public Seed z; //Field offset: 0x20
			public Seed w; //Field offset: 0x30

		}

		public struct Shape
		{
			public Seed4 m_Random; //Field offset: 0x0
			public float m_RadiusTimer; //Field offset: 0x40
			public float m_RadiusTimerPrev; //Field offset: 0x44
			public float m_ArcTimer; //Field offset: 0x48
			public float m_ArcTimerPrev; //Field offset: 0x4C
			public float m_MeshSpawnTimer; //Field offset: 0x50
			public float m_MeshSpawnTimerPrev; //Field offset: 0x54
			public int m_OrderedMeshVertexIndex; //Field offset: 0x58

		}

		public struct Trail
		{
			public float m_Timer; //Field offset: 0x0

		}

		internal float m_AccumulatedDt; //Field offset: 0x0
		internal float m_StartDelay; //Field offset: 0x4
		internal float m_PlaybackTime; //Field offset: 0x8
		internal int m_RingBufferIndex; //Field offset: 0xC
		internal Emission m_Emission; //Field offset: 0x10
		internal Initial m_Initial; //Field offset: 0x28
		internal Shape m_Shape; //Field offset: 0x68
		internal Force m_Force; //Field offset: 0xC4
		internal Collision m_Collision; //Field offset: 0x104
		internal Noise m_Noise; //Field offset: 0x144
		internal Lights m_Lights; //Field offset: 0x148
		internal Trail m_Trail; //Field offset: 0x15C

	}

	internal struct RotationBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct RotationOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ShapeModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct SubEmittersModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SubEmittersModule(ParticleSystem particleSystem) { }

	}

	internal struct TextureSheetAnimationModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TextureSheetAnimationModule(ParticleSystem particleSystem) { }

	}

	internal struct TrailModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TrailModule(ParticleSystem particleSystem) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoParticleTrails")]
	internal struct Trails
	{
		internal List<Vector4> positions; //Field offset: 0x0
		internal List<Int32> frontPositions; //Field offset: 0x8
		internal List<Int32> backPositions; //Field offset: 0x10
		internal List<Int32> positionCounts; //Field offset: 0x18
		internal List<Single> textureOffsets; //Field offset: 0x20
		internal int maxTrailCount; //Field offset: 0x28
		internal int maxPositionsPerTrailCount; //Field offset: 0x2C

		internal void Allocate() { }

	}

	internal struct TriggerModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TriggerModule(ParticleSystem particleSystem) { }

	}

	internal struct VelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal VelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}


	[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
	public bool automaticCullingEnabled
	{
		 get { } //Length: 51
	}

	public CollisionModule collision
	{
		 get { } //Length: 6
	}

	public ColorBySpeedModule colorBySpeed
	{
		 get { } //Length: 6
	}

	public ColorOverLifetimeModule colorOverLifetime
	{
		 get { } //Length: 6
	}

	public CustomDataModule customData
	{
		 get { } //Length: 6
	}

	[Obsolete("duration property is deprecated. Use main.duration instead.", False)]
	public float duration
	{
		 get { } //Length: 52
	}

	public EmissionModule emission
	{
		 get { } //Length: 6
	}

	[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
	public float emissionRate
	{
		 get { } //Length: 52
		 set { } //Length: 113
	}

	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	public bool enableEmission
	{
		 get { } //Length: 52
		 set { } //Length: 61
	}

	public ExternalForcesModule externalForces
	{
		 get { } //Length: 6
	}

	public ForceOverLifetimeModule forceOverLifetime
	{
		 get { } //Length: 6
	}

	[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
	public float gravityModifier
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	public bool has3DParticleRotations
	{
		[NativeName("Has3DParticleRotations")]
		 get { } //Length: 51
	}

	public bool hasNonUniformParticleSizes
	{
		[NativeName("HasNonUniformParticleSizes")]
		 get { } //Length: 51
	}

	public InheritVelocityModule inheritVelocity
	{
		 get { } //Length: 6
	}

	public bool isEmitting
	{
		[NativeName("SyncJobs(false)->IsEmitting")]
		 get { } //Length: 51
	}

	public bool isPaused
	{
		[NativeName("SyncJobs(false)->IsPaused")]
		 get { } //Length: 51
	}

	public bool isPlaying
	{
		[NativeName("SyncJobs(false)->IsPlaying")]
		 get { } //Length: 51
	}

	public bool isStopped
	{
		[NativeName("SyncJobs(false)->IsStopped")]
		 get { } //Length: 51
	}

	public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed
	{
		 get { } //Length: 6
	}

	public LightsModule lights
	{
		 get { } //Length: 6
	}

	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime
	{
		 get { } //Length: 6
	}

	[Obsolete("loop property is deprecated. Use main.loop instead.", False)]
	public bool loop
	{
		 get { } //Length: 52
		 set { } //Length: 61
	}

	public MainModule main
	{
		 get { } //Length: 6
	}

	[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
	public int maxParticles
	{
		 get { } //Length: 52
		 set { } //Length: 59
	}

	public NoiseModule noise
	{
		 get { } //Length: 6
	}

	public int particleCount
	{
		[NativeName("SyncJobs(false)->GetParticleCount")]
		 get { } //Length: 51
	}

	[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
	public float playbackSpeed
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
	public bool playOnAwake
	{
		 get { } //Length: 52
		 set { } //Length: 61
	}

	public bool proceduralSimulationSupported
	{
		 get { } //Length: 51
	}

	public uint randomSeed
	{
		[NativeName("GetRandomSeed")]
		 get { } //Length: 51
		[NativeName("SyncJobs(false)->SetRandomSeed")]
		 set { } //Length: 64
	}

	public RotationBySpeedModule rotationBySpeed
	{
		 get { } //Length: 6
	}

	public RotationOverLifetimeModule rotationOverLifetime
	{
		 get { } //Length: 6
	}

	[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
	public ParticleSystemScalingMode scalingMode
	{
		 get { } //Length: 52
		 set { } //Length: 59
	}

	public ShapeModule shape
	{
		 get { } //Length: 6
	}

	[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
	public ParticleSystemSimulationSpace simulationSpace
	{
		 get { } //Length: 52
		 set { } //Length: 59
	}

	public SizeBySpeedModule sizeBySpeed
	{
		 get { } //Length: 6
	}

	public SizeOverLifetimeModule sizeOverLifetime
	{
		 get { } //Length: 6
	}

	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor
	{
		 get { } //Length: 102
		 set { } //Length: 146
	}

	[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
	public float startDelay
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	public float startLifetime
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
	public float startRotation
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
	public Vector3 startRotation3D
	{
		 get { } //Length: 205
		 set { } //Length: 148
	}

	[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
	public float startSize
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	public float startSpeed
	{
		 get { } //Length: 52
		 set { } //Length: 68
	}

	public SubEmittersModule subEmitters
	{
		 get { } //Length: 6
	}

	public TextureSheetAnimationModule textureSheetAnimation
	{
		 get { } //Length: 6
	}

	public float time
	{
		[NativeName("SyncJobs(false)->GetSecPosition")]
		 get { } //Length: 51
		[NativeName("SyncJobs(false)->SetSecPosition")]
		 set { } //Length: 67
	}

	public float totalTime
	{
		[NativeName("SyncJobs(false)->GetTotalSecPosition")]
		 get { } //Length: 51
	}

	public TrailModule trails
	{
		 get { } //Length: 6
	}

	public TriggerModule trigger
	{
		 get { } //Length: 6
	}

	public bool useAutoRandomSeed
	{
		[NativeName("GetAutoRandomSeed")]
		 get { } //Length: 51
		[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		 set { } //Length: 66
	}

	public VelocityOverLifetimeModule velocityOverLifetime
	{
		 get { } //Length: 6
	}

	public ParticleSystem() { }

	[NativeName("SetUsesAxisOfRotation")]
	public void AllocateAxisOfRotationAttribute() { }

	[NativeName("SetUsesCustomData")]
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	[NativeName("SetUsesMeshIndex")]
	public void AllocateMeshIndexAttribute() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	public void Clear(bool withChildren) { }

	public void Clear() { }

	[ThreadSafe]
	internal static void CopyManagedJobData(Void* systemPtr, out NativeParticleData particleData) { }

	[RequiredByNativeCode]
	public void Emit(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count) { }

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Particle particle) { }

	private void Emit_Injected(ref EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle) { }

	public bool get_automaticCullingEnabled() { }

	public CollisionModule get_collision() { }

	public ColorBySpeedModule get_colorBySpeed() { }

	public ColorOverLifetimeModule get_colorOverLifetime() { }

	public CustomDataModule get_customData() { }

	public float get_duration() { }

	public EmissionModule get_emission() { }

	public float get_emissionRate() { }

	public bool get_enableEmission() { }

	public ExternalForcesModule get_externalForces() { }

	public ForceOverLifetimeModule get_forceOverLifetime() { }

	public float get_gravityModifier() { }

	[NativeName("Has3DParticleRotations")]
	public bool get_has3DParticleRotations() { }

	[NativeName("HasNonUniformParticleSizes")]
	public bool get_hasNonUniformParticleSizes() { }

	public InheritVelocityModule get_inheritVelocity() { }

	[NativeName("SyncJobs(false)->IsEmitting")]
	public bool get_isEmitting() { }

	[NativeName("SyncJobs(false)->IsPaused")]
	public bool get_isPaused() { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->IsStopped")]
	public bool get_isStopped() { }

	public LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	public LightsModule get_lights() { }

	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	public bool get_loop() { }

	public MainModule get_main() { }

	public int get_maxParticles() { }

	public NoiseModule get_noise() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	public int get_particleCount() { }

	public float get_playbackSpeed() { }

	public bool get_playOnAwake() { }

	public bool get_proceduralSimulationSupported() { }

	[NativeName("GetRandomSeed")]
	public uint get_randomSeed() { }

	public RotationBySpeedModule get_rotationBySpeed() { }

	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	public ParticleSystemScalingMode get_scalingMode() { }

	public ShapeModule get_shape() { }

	public ParticleSystemSimulationSpace get_simulationSpace() { }

	public SizeBySpeedModule get_sizeBySpeed() { }

	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	public Color get_startColor() { }

	public float get_startDelay() { }

	public float get_startLifetime() { }

	public float get_startRotation() { }

	public Vector3 get_startRotation3D() { }

	public float get_startSize() { }

	public float get_startSpeed() { }

	public SubEmittersModule get_subEmitters() { }

	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	public float get_time() { }

	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	public float get_totalTime() { }

	public TrailModule get_trails() { }

	public TriggerModule get_trigger() { }

	[NativeName("GetAutoRandomSeed")]
	public bool get_useAutoRandomSeed() { }

	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	internal Void* GetManagedJobData() { }

	internal JobHandle GetManagedJobHandle() { }

	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	private void GetParticleCurrentColor_Injected(ref Particle particle, out Color32 ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = True)]
	internal Vector3 GetParticleCurrentSize3D(ref Particle particle) { }

	private void GetParticleCurrentSize3D_Injected(ref Particle particle, out Vector3 ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = True)]
	internal int GetParticleMeshIndex(ref Particle particle) { }

	public int GetParticles(out NativeArray<Particle> particles) { }

	public int GetParticles(out NativeArray<Particle> particles, int size) { }

	public int GetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public int GetParticles(out Particle[] particles) { }

	public int GetParticles(out Particle[] particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	public PlaybackState GetPlaybackState() { }

	private void GetPlaybackState_Injected(out PlaybackState ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = True)]
	private void GetTrailDataInternal(ref Trails trailData) { }

	public int GetTrails(ref Trails trailData) { }

	public Trails GetTrails() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	public bool IsAlive(bool withChildren) { }

	public bool IsAlive() { }

	public void Pause() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	public void Pause(bool withChildren) { }

	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	public void Play(bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunction("ScheduleManagedJob", ThrowsException = True)]
	internal static JobHandle ScheduleManagedJob(ref JobScheduleParameters parameters, Void* additionalData) { }

	private static void ScheduleManagedJob_Injected(ref JobScheduleParameters parameters, Void* additionalData, out JobHandle ret) { }

	public void set_emissionRate(float value) { }

	public void set_enableEmission(bool value) { }

	public void set_gravityModifier(float value) { }

	public void set_loop(bool value) { }

	public void set_maxParticles(int value) { }

	public void set_playbackSpeed(float value) { }

	public void set_playOnAwake(bool value) { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	public void set_randomSeed(uint value) { }

	public void set_scalingMode(ParticleSystemScalingMode value) { }

	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	public void set_startColor(Color value) { }

	public void set_startDelay(float value) { }

	public void set_startLifetime(float value) { }

	public void set_startRotation(float value) { }

	public void set_startRotation3D(Vector3 value) { }

	public void set_startSize(float value) { }

	public void set_startSpeed(float value) { }

	[NativeName("SyncJobs(false)->SetSecPosition")]
	public void set_time(float value) { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	internal void SetManagedJobHandle(JobHandle handle) { }

	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	public void SetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public void SetParticles(out Particle[] particles, int size) { }

	public void SetParticles(out Particle[] particles) { }

	public void SetParticles(out NativeArray<Particle> particles, int size) { }

	public void SetParticles(out NativeArray<Particle> particles) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	public void SetParticles(out Particle[] particles, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	public void SetPlaybackState(PlaybackState playbackState) { }

	private void SetPlaybackState_Injected(ref PlaybackState playbackState) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
	public void SetTrails(Trails trailData) { }

	private void SetTrails_Injected(ref Trails trailData) { }

	public void Simulate(float t) { }

	public void Simulate(float t, bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	public void Stop() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop(bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = True)]
	public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) { }

	public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) { }

	public void TriggerSubEmitter(int subEmitterIndex) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = True)]
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) { }

	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref Particle particle) { }

}

