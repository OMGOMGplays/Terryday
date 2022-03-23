using Sandbox;

namespace TD
{
	partial class TDPlayer : Player
	{
		public override void Respawn()
		{
			base.Respawn();

			SetModel("models/citizen/citizen.vmdl");

			CameraMode = new FirstPersonCamera();
			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();

			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;
		}

		public override void Simulate( Client cl )
		{
			base.Simulate( cl );

			TickPlayerUse();
		}
	}
}
