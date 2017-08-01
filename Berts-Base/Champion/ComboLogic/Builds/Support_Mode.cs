using System;
using Aimtec;
using Aimtec.SDK.Events;
using Aimtec.SDK.Orbwalking;

namespace Berts_Base.Champion.ComboLogic.Builds
{
    class Support_Mode : ChampionBuildBase
    {
        public Support_Mode(ref IOrbwalker orbwalker) : base(ref orbwalker)
        {
        }

        public override void OnAddBuff(Obj_AI_Base sender, Buff buff)
        {
            throw new NotImplementedException();
        }

        public override void OnCastSpell(Obj_AI_Base sender, SpellBookCastSpellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnCreate(GameObject sender)
        {
            throw new NotImplementedException();
        }

        public override void OnDestroy(GameObject sender)
        {
            throw new NotImplementedException();
        }

        public override void OnGapcloser(object sender, Dash.DashArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnIssueOrder(Obj_AI_Base sender, Obj_AI_BaseIssueOrderEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnNonKillableMinion(object sender, NonKillableMinionEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnPostAttack(object sender, PostAttackEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnPreAttack(object sender, PreAttackEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnPreMove(object sender, PreMoveEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnPresent()
        {
            throw new NotImplementedException();
        }

        public override void OnProcessSpellCast(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnRemoveBuff(Obj_AI_Base sender, Buff buff)
        {
            throw new NotImplementedException();
        }

        public override void OnRender()
        {
            throw new NotImplementedException();
        }

        public override void OnSelectUnit(GameObject e)
        {
            throw new NotImplementedException();
        }

        public override void OnStopCast(Obj_AI_Base sender, SpellBookStopCastEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnUpdateChargedSpell(Obj_AI_Base sender, SpellBookUpdateChargedSpellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
