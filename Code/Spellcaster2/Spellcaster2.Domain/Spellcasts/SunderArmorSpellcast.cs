using System;
using Spellcaster2.Domain.Effects;

namespace Spellcaster2.Domain.Spellcasts
{
    internal class SunderArmorSpellcast : Spellcast
    {
		public SunderArmorSpellcast(IMessager messager, ILogger logger) : base(messager, logger) { }

		protected override string GetBeginCastMessage(ICharacter source, ICharacter target) => $"{source.GetName()} has rendered the armor of {target.GetName()} effectively useless!";

		protected override void AffectSource(ICharacter source) => source.AdjustMana(-15);

		protected override void AffectTarget(ICharacter target) => target.AddEffect(new ArmorReductionEffect(5));

	}
}
