using System;
using Spellcaster2.Domain.Effects;

namespace Spellcaster2.Domain.Spellcasts
{
	internal class RainOfFireSpellcast : Spellcast
	{
		public RainOfFireSpellcast(IMessager messager, ILogger logger) : base(messager, logger) { }

		protected override string GetBeginCastMessage(ICharacter source, ICharacter target) => $"{source.GetName()} begins raining fire upon {target.GetName()}!";

		protected override void AffectSource(ICharacter source) => source.AdjustMana(-10);

		protected override void AffectTarget(ICharacter target)
		{
			target.AddEffect(new DirectDamageEffect(10));
			target.AddEffect(new DamageOverTimeEffect(30));
		}
	}
}
