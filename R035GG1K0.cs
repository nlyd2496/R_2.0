using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_家具系统_2._0
{
    public class R035GG1K0 : GameStateMachine<R035GG1K0, R035GG1K0.Instance>
    {
        public override void InitializeStates(out StateMachine.BaseState default_state)
        {
            default_state = this.off;
            this.off.PlayAnim("off").EventTransition(GameHashes.OperationalChanged, this.working_pre, (R035GG1K0.Instance smi) => smi.GetComponent<Operational>().IsOperational);
            this.working_pre.PlayAnim("working_pre").OnAnimQueueComplete(this.working_loop);
            this.working_loop.PlayAnim("working_loop", KAnim.PlayMode.Loop).EventTransition(GameHashes.OperationalChanged, this.off, (R035GG1K0.Instance smi) => !smi.GetComponent<Operational>().IsOperational).ToggleStatusItem(Db.Get().BuildingStatusItems.EmittingLight, null).Enter("SetActive", delegate (R035GG1K0.Instance smi)
            {
                smi.GetComponent<Operational>().SetActive(true, false);
            });
        }
        public GameStateMachine<R035GG1K0, R035GG1K0.Instance, IStateMachineTarget, object>.State off;
        public GameStateMachine<R035GG1K0, R035GG1K0.Instance, IStateMachineTarget, object>.State working_pre;
        public GameStateMachine<R035GG1K0, R035GG1K0.Instance, IStateMachineTarget, object>.State working_loop;
        public class Def : StateMachine.BaseDef
        {
        }
        public new class Instance : GameStateMachine<R035GG1K0, R035GG1K0.Instance, IStateMachineTarget, object>.GameInstance
        {
            public Instance(IStateMachineTarget master, R035GG1K0.Def def) : base(master, def)
            {
            }
        }
    }
}
