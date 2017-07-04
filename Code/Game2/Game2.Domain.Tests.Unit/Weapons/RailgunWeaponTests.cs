using System;
using Xunit;
using Game2.Domain.Weapons;

namespace Game2.Domain.Tests.Unit.Weapons
{
	public class RailgunWeaponTests
    {
		[Fact]
		public void NormalFire()
		{
			var weapon = new RailgunWeapon();
			var result = weapon.Fire(1, 20);
			Assert.Equal(5, result.HeatGenerated);
			Assert.Equal(50, result.PowerDrained);
			Assert.True(result.Incapacitate);
		}

		[Fact]
		public void MultiFireGeneratesExtraHeat()
		{
			var weapon = new RailgunWeapon();
			var result = weapon.Fire(2, 20);
			Assert.Equal(20, result.HeatGenerated);
			Assert.Equal(100, result.PowerDrained);
			Assert.True(result.Incapacitate);
		}
	}
}
