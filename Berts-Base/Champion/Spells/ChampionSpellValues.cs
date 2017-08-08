using Aimtec.SDK;
using System;
using System.Linq;

namespace Berts_Base.Champion.Spells
{
    class ChampionSpellValues
    {
        public Spell _flashSpell { private set; get; }
        public Spell _smiteSpell { private set; get; }
        public Spell _igniteSpell { private set; get; }

        public Spell _qSpell { private set; get; }
        public Spell _q2Spell { private set; get; }

        public Spell _wSpell { private set; get; }
        public Spell _w2Spell { private set; get; }

        public Spell _eSpell { private set; get; }
        public Spell _e2Spell { private set; get; }

        public Spell _rSpell { private set; get; }
        public Spell _r2Spell { private set; get; }

        /// <summary>
        /// Initialises Champion Spells
        /// </summary>
        /// <param name="champion"></param>
        public ChampionSpellValues(Aimtec.Obj_AI_Hero champion)
        {
            SetupSummoners(champion);
            SetupQ(champion);
            SetupW(champion);
            SetupE(champion);
            SetupR(champion);
        }

        /// <summary>
        /// Setup the summoner spells that can be used for aggressive plays.
        /// </summary>
        /// <param name="champion">The champion.</param>
        void SetupSummoners(Aimtec.Obj_AI_Hero champion)
        {
            if (champion.SpellBook.Spells.Any(x => x.Name.ToLower().Contains(Constants.SpellData.Smite)))
            {
                SimpleLog.Info("Smite Supported - Loading Spell");
                _smiteSpell = new Spell(champion.SpellBook.Spells.First(spell => spell.Name.Contains(Constants.SpellData.Smite)).Slot, 500);
            }

            if (champion.SpellBook.Spells.Any(x => x.Name.ToLower().Contains(Constants.SpellData.Ignite)))
            {
                SimpleLog.Info("Ignite Supported - Loading Spell");
                _igniteSpell = new Spell(champion.SpellBook.Spells.First(spell => spell.Name.Contains(Constants.SpellData.Ignite)).Slot, 500);
            }

            if (champion.SpellBook.Spells.Any(x => x.Name.ToLower().Contains(Constants.SpellData.Flash)))
            {
                SimpleLog.Info("Flash Supported - Loading Spell");
                _igniteSpell = new Spell(champion.SpellBook.Spells.First(spell => spell.Name.Contains(Constants.SpellData.Flash)).Slot, 500);
            }
        }

        /// <summary>
        /// Setup Q Spell.
        /// </summary>
        /// <param name="champion">The champion.</param>
        /// <exception cref="NotImplementedException"></exception>
        void SetupQ(Aimtec.Obj_AI_Hero champion)
        {
            //_qSpell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_qSpell.SetCharged();
            //_qSpell.SetSkillshot();

            //_q2Spell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_q2Spell.SetCharged()
            //_q2Spell.SetSkillshot()

            throw new NotImplementedException();
        }

        /// <summary>
        /// Setup W Spell.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        void SetupW(Aimtec.Obj_AI_Hero champion)
        {
            //_wSpell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_wSpell.SetCharged();
            //_wSpell.SetSkillshot();

            //_w2Spell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_w2Spell.SetCharged()
            //_w2Spell.SetSkillshot()

            throw new NotImplementedException();
        }

        /// <summary>
        /// Setup E Spell.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        void SetupE(Aimtec.Obj_AI_Hero champion)
        {
            //_eSpell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_eSpell.SetCharged();
            //_eSpell.SetSkillshot();

            //_e2Spell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_e2Spell.SetCharged()
            //_e2Spell.SetSkillshot()

            throw new NotImplementedException();
        }

        /// <summary>
        /// Setup R spell.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        void SetupR(Aimtec.Obj_AI_Hero champion)
        {
            //_rSpell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_rSpell.SetCharged();
            //_rSpell.SetSkillshot();

            //_r2Spell = new Spell(Aimtec.SpellSlot.Q, 0f);
            //_r2Spell.SetCharged()
            //_r2Spell.SetSkillshot()

            throw new NotImplementedException();
        }
    }
}
