using System;
using Spellcaster2.Domain.Effects;

namespace Spellcaster2.Domain.Spellcasts
{
    internal class DarkPactSpellcast : Spellcast
    {
		public DarkPactSpellcast(IMessager messager, ILogger logger) : base(messager, logger) { }

		protected override string GetBeginCastMessage(ICharacter source, ICharacter target) => $"{target.GetName()} has signed a dark pact with {source.GetName()}!";

		protected override void AffectSource(ICharacter source)
		{
			source.AdjustMana(-60);
			source.AdjustHitPoints(-100);
		}

		protected override void AffectTarget(ICharacter target)
		{
			target.AdjustMana(50);
			target.AdjustHitPoints(80);
		}
	}
}
