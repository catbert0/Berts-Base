using Aimtec;
using System;
using System.Linq;

namespace Berts_Base.Champion.Spells
{
    class ChampionSpellValues
    {
        public Spell _flashSpell { private set; get; }


        public Aimtec.SDK.Spell _smiteSpell { private set; get; }
        public Spell _smiteSpellData { private set; get; }

        public Spell _igniteSpell { private set; get; }

        public Aimtec.SDK.Spell _qSpell { private set; get; }
        public Aimtec.SDK.Spell _q2Spell { private set; get; }

        public Aimtec.SDK.Spell _wSpell { private set; get; }
        public Aimtec.SDK.Spell _w2Spell { private set; get; }

        public Aimtec.SDK.Spell _eSpell { private set; get; }
        public Aimtec.SDK.Spell _e2Spell { private set; get; }

        public Aimtec.SDK.Spell _rSpell { private set; get; }
        public Aimtec.SDK.Spell _r2Spell { private set; get; }

        /// <summary>
        /// Initialises Champion Spells
        /// </summary>
        /// <param name="champion"></param>
        public ChampionSpellValues(Obj_AI_Hero champion)
        {
            SetupSummoners(champion);
            SetupQ(champion);
            SetupW(champion);
            SetupE(champion);
            SetupR(champion);
        }

        /// <summary>
        /// Gets if the summoner has Smite
        /// </summary>
        /// <returns></returns>
        public bool GetSummonerHasSmite()
        {
            return _smiteSpell != null;
        }

        /// <summary>
        /// Gets if the summoner has Flash
        /// </summary>
        /// <returns></returns>
        public bool SummonerHasFlash()
        {
            return _flashSpell != null;
        }

        /// <summary>
        /// Gets if the summoner has Ignite
        /// </summary>
        /// <returns></returns>
        public bool SummonerHasIgnite()
        {
            return _igniteSpell != null;
        }

        /// <summary>
        /// Setup the summoner spells that can be used for aggressive plays.
        /// </summary>
        /// <param name="champion">The champion.</param>
        void SetupSummoners(Obj_AI_Hero champion)
        {
            GetSummonerSpell(champion.SpellBook.Spells.First(x => x.Slot.Equals(SpellSlot.Summoner1)));
            GetSummonerSpell(champion.SpellBook.Spells.First(x => x.Slot.Equals(SpellSlot.Summoner2)));
        }

        private void GetSummonerSpell(Spell summoner)
        {
            _smiteSpellData = summoner.Name.ToLower().Contains(Constants.SpellData.Smite) ? summoner : null;
            _igniteSpell = summoner.Name.ToLower().Contains(Constants.SpellData.Ignite) ? summoner : null;
            _flashSpell = summoner.Name.ToLower().Contains(Constants.SpellData.Flash) ? summoner : null;
        }

        public void CastSmite()
        {
#warning need to improve this check so I dont check for null on every smite cast
            if (_smiteSpell == null)
                _smiteSpell = new Aimtec.SDK.Spell(_smiteSpellData.Slot, _smiteSpellData.SpellData.CastRange);

            if (_smiteSpellData.Ammo > 1)
            {
                _smiteSpell.Cast();
            }
        }

        /// <summary>
        /// Setup Q Spell.
        /// </summary>
        /// <param name="champion">The champion.</param>
        /// <exception cref="NotImplementedException"></exception>
        void SetupQ(Obj_AI_Hero champion)
        {
            _qSpell = new Aimtec.SDK.Spell(SpellSlot.Q, 0f);
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
        void SetupW(Obj_AI_Hero champion)
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
        void SetupE(Obj_AI_Hero champion)
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
        void SetupR(Obj_AI_Hero champion)
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
