using System;
using Xunit;
using Game2.Domain.Weapons;

namespace Game2.Domain.Tests.Unit.Weapons
{
    public class AutocannonWeaponTests
    {
		[Fact]
		public void NormalFire()
		{
			var weapon = new AutocannonWeapon();
			var result = weapon.Fire(10, 20);
			Assert.Equal(10, result.HeatGenerated);
			Assert.Equal(0, result.PowerDrained);
			Assert.False(result.Incapacitate);
		}

		[Fact]
		public void OverheatedFireCausesJam()
		{
			var weapon = new AutocannonWeapon();
			var result = weapon.Fire(10, 300);
			Assert.Equal(0, result.HeatGenerated);
			Assert.Equal(0, result.PowerDrained);
			Assert.False(result.Incapacitate);
		}
    }
}
