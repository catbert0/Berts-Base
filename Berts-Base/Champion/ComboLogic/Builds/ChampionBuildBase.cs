using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Events;
using System;
using Berts_Base.Champion.Spells;
using Berts_Base.SetupHelpers;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;

namespace Berts_Base.Champion.ComboLogic.Builds
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Base class for each champion build
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    abstract class ChampionBuildBase : IDisposable
    {
        private bool _disposed;

        protected IOrbwalker _orbwalker;
        protected IHealthPrediction _healthPredition { private set; get; }
        protected ITargetSelector _targetSelector { private set; get; }

        protected MenuManager _menu;
        protected Obj_AI_Hero _champion;
        protected ChampionSpellValues _spellData;

        protected SpellController _spellController = new SpellController();
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChampionBuildBase"/> class.
        /// 
        /// This sets up event listeners ready to react to the events that can occur
        /// </summary>
        /// <param name="orbwalker">The orbwalker.</param>
        public ChampionBuildBase(GameObjectManager gameObjectManager)
        {
            SetUpGameObjects(gameObjectManager);
            SetupEventTriggers();
        }

        /// <summary>
        /// Sets up game objects.
        /// </summary>
        /// <param name="gameObjectManager">The game object manager.</param>
        private void SetUpGameObjects(GameObjectManager gameObjectManager)
        {
            _champion = gameObjectManager._champion;
            _orbwalker = gameObjectManager._orbWalker;
            _healthPredition = gameObjectManager._healthPredition;
            _targetSelector = gameObjectManager._targetSelector;
            _menu = gameObjectManager._menu;
            _spellData = new ChampionSpellValues(_champion);
        }

        /// <summary>
        /// Setup the event triggers.
        /// </summary>
        private void SetupEventTriggers()
        {
            SpellBook.OnCastSpell += OnCastSpell;
            SpellBook.OnStopCast += OnStopCast;
            SpellBook.OnUpdateChargedSpell += OnUpdateChargedSpell;
            Render.OnPresent += OnPresent;
            Render.OnRender += OnRender;
            Obj_AI_Base.OnProcessSpellCast += OnProcessSpellCast;
            Obj_AI_Base.OnIssueOrder += OnIssueOrder;
            Obj_AI_Base.OnChangeAnimationState += OnChangeAnimationState;
            Obj_AI_Base.OnInteraction += OnInteraction;
            Obj_AI_Base.OnLevelUp += OnLevelUp;
            Obj_AI_Base.OnNewPath += OnNewPath;
            Obj_AI_Base.OnPerformCast += OnPerformCast;
            Obj_AI_Base.OnPlayAnimation += OnPlayAnimation;
            Obj_AI_Base.OnProcessAutoAttack += OnProcessAutoAttack;
            Obj_AI_Base.OnTeleport += OnTeleport;
            AttackableUnit.OnDamage += OnDamage;
            AttackableUnit.OnEnterVisible += OnEnterVisible;
            AttackableUnit.OnLeaveVisible += OnLeaveVisible;
            GameObject.OnCreate += OnCreate;
            GameObject.OnDestroy += OnDestroy;
            Dash.HeroDashed += OnGapcloser;
            BuffManager.OnAddBuff += OnAddBuff;
            BuffManager.OnRemoveBuff += OnRemoveBuff;
            HudManager.OnSelectUnit += OnSelectUnit;
            _orbwalker.PreAttack += OnPreAttack;
            _orbwalker.PostAttack += OnPostAttack;
            _orbwalker.PreMove += OnPreMove;
            _orbwalker.OnNonKillableMinion += OnNonKillableMinion;
        }

        /// <summary>
        /// Called when [cast spell].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SpellBookCastSpellEventArgs"/> instance containing the event data.</param>
        protected virtual void OnCastSpell(Obj_AI_Base sender, SpellBookCastSpellEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [stop cast].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SpellBookStopCastEventArgs"/> instance containing the event data.</param>
        protected virtual void OnStopCast(Obj_AI_Base sender, SpellBookStopCastEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [update charged spell].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SpellBookUpdateChargedSpellEventArgs"/> instance containing the event data.</param>
        protected virtual void OnUpdateChargedSpell(Obj_AI_Base sender, SpellBookUpdateChargedSpellEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [present].
        /// </summary>
        protected virtual void OnPresent()
        {
            return;
        }

        /// <summary>
        /// Called when [render].
        /// </summary>
        protected virtual void OnRender()
        {
            return;
        }

        /// <summary>
        /// Called when [process spell cast].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseMissileClientDataEventArgs"/> instance containing the event data.</param>
        protected virtual void OnProcessSpellCast(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [issue order].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseIssueOrderEventArgs"/> instance containing the event data.</param>
        protected virtual void OnIssueOrder(Obj_AI_Base sender, Obj_AI_BaseIssueOrderEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="sender">The sender.</param>
        protected virtual void OnCreate(GameObject sender)
        {
            return;
        }

        /// <summary>
        /// Called when [destroy].
        /// </summary>
        /// <param name="sender">The sender.</param>
        protected virtual void OnDestroy(GameObject sender)
        {
            return;
        }

        /// <summary>
        /// Called when [pre attack].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PreAttackEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPreAttack(object sender, PreAttackEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [post attack].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PostAttackEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPostAttack(object sender, PostAttackEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [pre move].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PreMoveEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPreMove(object sender, PreMoveEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [non killable minion].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="NonKillableMinionEventArgs"/> instance containing the event data.</param>
        protected virtual void OnNonKillableMinion(object sender, NonKillableMinionEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [gapcloser].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected virtual void OnGapcloser(object sender, Dash.DashArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [add buff].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="buff">The buff.</param>
        protected virtual void OnAddBuff(Obj_AI_Base sender, Buff buff)
        {
            return;
        }

        /// <summary>
        /// Called when [remove buff].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="buff">The buff.</param>
        protected virtual void OnRemoveBuff(Obj_AI_Base sender, Buff buff)
        {
            return;
        }

        /// <summary>
        /// Called when [select unit].
        /// </summary>
        /// <param name="e">The e.</param>
        protected virtual void OnSelectUnit(GameObject e)
        {
            return;
        }

        /// <summary>
        /// Performs the obwalking mode.
        /// </summary>
        /// <param name="orbWalkingMode">The orb walking mode.</param>
        /// <param name="spellData">The spell data.</param>
        public abstract void PerformAssemblyLogic();

        /// <summary>
        /// Called when [enter visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="NotImplementedException"></exception>
        protected virtual void OnEnterVisible(AttackableUnit sender, EventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [leave visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnLeaveVisible(AttackableUnit sender, EventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [damage].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AttackableUnitDamageEventArgs"/> instance containing the event data.</param>
        protected virtual void OnDamage(AttackableUnit sender, AttackableUnitDamageEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [teleport].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseTeleportEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTeleport(Obj_AI_Base sender, Obj_AI_BaseTeleportEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [process automatic attack].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseMissileClientDataEventArgs"/> instance containing the event data.</param>
        protected virtual void OnProcessAutoAttack(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [play animation].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BasePlayAnimationEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPlayAnimation(Obj_AI_Base sender, Obj_AI_BasePlayAnimationEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [perform cast].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseMissileClientDataEventArgs"/> instance containing the event data.</param>
        protected virtual void OnPerformCast(Obj_AI_Base sender, Obj_AI_BaseMissileClientDataEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [new path].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseNewPathEventArgs"/> instance containing the event data.</param>
        protected virtual void OnNewPath(Obj_AI_Base sender, Obj_AI_BaseNewPathEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [level up].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseLevelUpEventArgs"/> instance containing the event data.</param>
        protected virtual void OnLevelUp(Obj_AI_Base sender, Obj_AI_BaseLevelUpEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [interaction].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseInteractionEventArgs"/> instance containing the event data.</param>
        protected virtual void OnInteraction(Obj_AI_Base sender, Obj_AI_BaseInteractionEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Called when [change animation state].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Obj_AI_BaseChangeAnimationStateEventArgs"/> instance containing the event data.</param>
        protected virtual void OnChangeAnimationState(Obj_AI_Base sender, Obj_AI_BaseChangeAnimationStateEventArgs e)
        {
            return;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;
       
            if (disposing)
            {
                //For future refrence I should dispose any other objects here 
                //if I add them that also implement IDisposable.
            }

            //If in the future any objects are added that do not implement
            //IDisposable I will free them up here (= null)

            _disposed = true;
        }
    }
}
