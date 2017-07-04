using System;
using Xunit;
using Game2.Domain.Weapons;

namespace Game2.Domain.Tests.Unit.Weapons
{
	public class MissleWeaponTests
	{
		[Fact]
		public void NormalFire()
		{
			var weapon = new MissleWeapon();
			var result = weapon.Fire(10, 20);
			Assert.Equal(30, result.HeatGenerated);
			Assert.Equal(10, result.PowerDrained);
			Assert.False(result.Incapacitate);
		}

		[Fact]
		public void OverheatedFireCausesIncapacitation()
		{
			var weapon = new MissleWeapon();
			var result = weapon.Fire(10, 300);
			Assert.Equal(30, result.HeatGenerated);
			Assert.Equal(10, result.PowerDrained);
			Assert.True(result.Incapacitate);
		}
	}
}
