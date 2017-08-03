using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Events;

namespace Berts_Base.Champion.ComboLogic.Builds
{
    abstract class ChampionBuildBase
    {
        public ChampionBuildBase(ref IOrbwalker orbwalker)
        {
            SpellBook.OnCastSpell += OnCastSpell;
            SpellBook.OnStopCast += OnStopCast;
            SpellBook.OnUpdateChargedSpell += OnUpdateChargedSpell;
            Render.OnPresent += OnPresent;
            Render.OnRender += OnRender;
            Obj_AI_Base.OnProcessSpellCast += OnProcessSpellCast;
            Obj_AI_Base.OnIssueOrder += OnIssueOrder;
            GameObject.OnCreate += OnCreate;
            GameObject.OnDestroy += OnDestroy;
            orbwalker.PreAttack += OnPreAttack;
            orbwalker.PostAttack += OnPostAttack;
            orbwalker.PreMove += OnPreMove;
            orbwalker.OnNonKillableMinion += OnNonKillableMinion;
            Dash.HeroDashed += OnGapcloser;
            BuffManager.OnAddBuff += OnAddBuff;
            BuffManager.OnRemoveBuff += OnRemoveBuff;
            HudManager.OnSelectUnit += OnSelectUnit;
        }

        public abstract void OnCastSpell(Obj_AI_Base sender, SpellBookCastSpellEventArgs e);

        public abstract void OnStopCast(Obj_AI_Base sender, SpellBookStopCastEventArgs e);

        public abstract void OnUpdateChargedSpell(Obj_AI_Base sender, SpellBookUpdateChargedSpellEventArgs e);

        public abstract void OnPresent();

        public abstract void OnRender();

        public abstract void OnProcessSpellCast(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs e);

        public abstract void OnIssueOrder(Obj_AI_Base sender, Obj_AI_BaseIssueOrderEventArgs e);

        public abstract void OnCreate(GameObject sender);

        public abstract void OnDestroy(GameObject sender);

        public abstract void OnPreAttack(object sender, PreAttackEventArgs e);

        public abstract void OnPostAttack(object sender, PostAttackEventArgs e);

        public abstract void OnPreMove(object sender, PreMoveEventArgs e);

        public abstract void OnNonKillableMinion(object sender, NonKillableMinionEventArgs e);

        public abstract void OnGapcloser(object sender, Dash.DashArgs e);

        public abstract void OnAddBuff(Obj_AI_Base sender, Buff buff);

        public abstract void OnRemoveBuff(Obj_AI_Base sender, Buff buff);

        public abstract void OnSelectUnit(GameObject e);

        public virtual bool GetIfShouldCastQ()
        {
#warning Need to implement manalogic
            return true;
        }

        public virtual bool GetIfShouldCastW()
        {
#warning Need to implement manalogic
            return true;
        }

        public virtual bool GetIfShouldCastE()
        {
#warning Need to implement manalogic
            return true;
        }

        public virtual bool GetIfShouldCastR()
        {
#warning Need to implement manalogic
            return true;
        }
    }
}
