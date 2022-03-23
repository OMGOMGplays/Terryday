using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Linq;

namespace TD.UI
{
	public partial class TDHud : HudEntity<RootPanel> 
	{
		public static TDHud Instance {get; set;}

		public TDHud() 
		{
			Instance = this;
		}

		public override void CreateRootPanel()
		{
			RootPanel?.Delete();

			base.CreateRootPanel();
			CreateHUDElements();
		}

		public void CreateHUDElements() 
		{
			RootPanel.AddChild<MainMenu>();

			// RootPanel.AddChild<PlayerMoney>();

			// RootPanel.AddChild<Ammo>();
			// RootPanel.AddChild<Vitals>();
		}
	}
}
