//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using PrototypeB.Web.Modules.Busines_logic.Backend;
//using Serenity.Data;
//using Serenity.Services;

//namespace VantagePoint.Web.Modules.Backend
//{
//    public class EvaluateRulesBehaviour : IImplicitBehavior, ISaveBehavior
//    {

//        // PWK: Initializing "EvaluateDispatcher" instance to use throughout
//        // This block must be converted to Thread-safe 
//        private EvaluateDispatcher dispatcher = new EvaluateDispatcher();
//        private IEvaluateRulesRow evalRow;

//        // PWK: This is the selector for the behaviour
//        // when returns true base handlers will be modified with extensions below
//        public bool ActivateFor(Row row)
//        {
//            var evalRow = row as IEvaluateRulesRow;

//            if (evalRow == null)
//                return false;

//            return true;
            
//        }

//        public void OnBeforeSave(ISaveRequestHandler handler)
//        {
//            return;
            
//        }

//        public void OnAfterSave(ISaveRequestHandler handler)
//        {
//            dispatcher.EvaluateBeforeSave(handler); ;
//        }

//        public void OnAudit(ISaveRequestHandler handler) { }
//        public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query) { }
//        public void OnReturn(ISaveRequestHandler handler) { }
//        public void OnSetInternalFields(ISaveRequestHandler handler) { }
//        public void OnValidateRequest(ISaveRequestHandler handler) { }
//    }
//}
