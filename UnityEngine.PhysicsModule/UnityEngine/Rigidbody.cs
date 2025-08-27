namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public float angularDrag
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public bool automaticCenterOfMass
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool automaticInertiaTensor
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 centerOfMass
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public RigidbodyConstraints constraints
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool detectCollisions
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float drag
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public LayerMask excludeLayers
	{
		 get { } //Length: 68
		 set { } //Length: 59
	}

	public bool freezeRotation
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public LayerMask includeLayers
	{
		 get { } //Length: 68
		 set { } //Length: 59
	}

	public Vector3 inertiaTensor
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion inertiaTensorRotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public RigidbodyInterpolation interpolation
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool isKinematic
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float mass
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float maxAngularVelocity
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float maxDepenetrationVelocity
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float maxLinearVelocity
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector3 position
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion rotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", True)]
	public float sleepAngularVelocity
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public float sleepThreshold
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
	public float sleepVelocity
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations")]
	public int solverIterationCount
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int solverIterations
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations")]
	public int solverVelocityIterationCount
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int solverVelocityIterations
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Cone friction is no longer supported.", True)]
	public bool useConeFriction
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public bool useGravity
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Vector3 worldCenterOfMass
	{
		 get { } //Length: 77
	}

	public Rigidbody() { }

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForce(float x, float y, float z) { }

	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForce(Vector3 force) { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeForce(Vector3 force) { }

	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeForce(float x, float y, float z) { }

	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeTorque(Vector3 torque) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeTorque(float x, float y, float z) { }

	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	public void AddTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddTorque(float x, float y, float z) { }

	[ExcludeFromDocs]
	public void AddTorque(Vector3 torque) { }

	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	public float get_angularDrag() { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public bool get_automaticCenterOfMass() { }

	public bool get_automaticInertiaTensor() { }

	public Vector3 get_centerOfMass() { }

	private void get_centerOfMass_Injected(out Vector3 ret) { }

	public CollisionDetectionMode get_collisionDetectionMode() { }

	public RigidbodyConstraints get_constraints() { }

	public bool get_detectCollisions() { }

	public float get_drag() { }

	public LayerMask get_excludeLayers() { }

	private void get_excludeLayers_Injected(out LayerMask ret) { }

	public bool get_freezeRotation() { }

	public LayerMask get_includeLayers() { }

	private void get_includeLayers_Injected(out LayerMask ret) { }

	public Vector3 get_inertiaTensor() { }

	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	public Quaternion get_inertiaTensorRotation() { }

	private void get_inertiaTensorRotation_Injected(out Quaternion ret) { }

	public RigidbodyInterpolation get_interpolation() { }

	public bool get_isKinematic() { }

	public float get_mass() { }

	public float get_maxAngularVelocity() { }

	public float get_maxDepenetrationVelocity() { }

	public float get_maxLinearVelocity() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public float get_sleepAngularVelocity() { }

	public float get_sleepThreshold() { }

	public float get_sleepVelocity() { }

	public int get_solverIterationCount() { }

	public int get_solverIterations() { }

	public int get_solverVelocityIterationCount() { }

	public int get_solverVelocityIterations() { }

	public bool get_useConeFriction() { }

	public bool get_useGravity() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Vector3 get_worldCenterOfMass() { }

	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	[ExcludeFromDocs]
	public Vector3 GetAccumulatedForce() { }

	public Vector3 GetAccumulatedForce(float step) { }

	private void GetAccumulatedForce_Injected(float step, out Vector3 ret) { }

	[ExcludeFromDocs]
	public Vector3 GetAccumulatedTorque() { }

	public Vector3 GetAccumulatedTorque(float step) { }

	private void GetAccumulatedTorque_Injected(float step, out Vector3 ret) { }

	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	private void GetRelativePointVelocity_Injected(ref Vector3 relativePoint, out Vector3 ret) { }

	[NativeName("ClosestPointOnBounds")]
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

	[NativeName("SweepTestAll")]
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	private RaycastHit[] Internal_SweepTestAll_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	public bool IsSleeping() { }

	public void Move(Vector3 position, Quaternion rotation) { }

	private void Move_Injected(ref Vector3 position, ref Quaternion rotation) { }

	public void MovePosition(Vector3 position) { }

	private void MovePosition_Injected(ref Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private void MoveRotation_Injected(ref Quaternion rot) { }

	public void ResetCenterOfMass() { }

	public void ResetInertiaTensor() { }

	public void set_angularDrag(float value) { }

	public void set_angularVelocity(Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	public void set_automaticCenterOfMass(bool value) { }

	public void set_automaticInertiaTensor(bool value) { }

	public void set_centerOfMass(Vector3 value) { }

	private void set_centerOfMass_Injected(ref Vector3 value) { }

	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	public void set_constraints(RigidbodyConstraints value) { }

	public void set_detectCollisions(bool value) { }

	public void set_drag(float value) { }

	public void set_excludeLayers(LayerMask value) { }

	private void set_excludeLayers_Injected(ref LayerMask value) { }

	public void set_freezeRotation(bool value) { }

	public void set_includeLayers(LayerMask value) { }

	private void set_includeLayers_Injected(ref LayerMask value) { }

	public void set_inertiaTensor(Vector3 value) { }

	private void set_inertiaTensor_Injected(ref Vector3 value) { }

	public void set_inertiaTensorRotation(Quaternion value) { }

	private void set_inertiaTensorRotation_Injected(ref Quaternion value) { }

	public void set_interpolation(RigidbodyInterpolation value) { }

	public void set_isKinematic(bool value) { }

	public void set_mass(float value) { }

	public void set_maxAngularVelocity(float value) { }

	public void set_maxDepenetrationVelocity(float value) { }

	public void set_maxLinearVelocity(float value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void set_sleepAngularVelocity(float value) { }

	public void set_sleepThreshold(float value) { }

	public void set_sleepVelocity(float value) { }

	public void set_solverIterationCount(int value) { }

	public void set_solverIterations(int value) { }

	public void set_solverVelocityIterationCount(int value) { }

	public void set_solverVelocityIterations(int value) { }

	public void set_useConeFriction(bool value) { }

	public void set_useGravity(bool value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

	public void SetDensity(float density) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
	public void SetMaxAngularVelocity(float a) { }

	public void Sleep() { }

	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	[ExcludeFromDocs]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	private void SweepTest_Injected(ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	public void WakeUp() { }

}

