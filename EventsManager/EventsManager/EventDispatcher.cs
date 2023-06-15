using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsManager
{
    class EventCommon : IDisposable
    {
        public void Dispose()
        {

        }
        protected Action exception = null;
        public EventCommon(Action exception = null)
        {
            this.exception = exception;
        }
        public virtual void Publish()
        {

        }
        public virtual void Publish(object args1)
        {

        }
        public virtual void Publish(object args1, object args2)
        {

        }
        public virtual void Publish(object args1, object args2, object args3)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4, object args5)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4, object args5, object args6)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7, object args8)
        {

        }
        public virtual void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7, object args8, object args9)
        {

        }

        public virtual object Call()
        {
            return default;
        }
        public virtual object Call(object args)
        {
            return default;
        }
    }
    class EventAction : EventCommon
    {
        public Action Action { get; set; }

        public EventAction(Action action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish()
        {
            try { Action?.Invoke(); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1> : EventCommon
    {
        public Action<T1> Action { get; set; }
        public EventAction(Action<T1> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args)
        {
            try { Action?.Invoke((T1)args); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2> : EventCommon
    {
        public Action<T1, T2> Action { get; set; }
        public EventAction(Action<T1, T2> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2)
        {
            try { Action?.Invoke((T1)args1, (T2)args2); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3> : EventCommon
    {
        public Action<T1, T2, T3> Action { get; set; }
        public EventAction(Action<T1, T2, T3> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4> : EventCommon
    {
        public Action<T1, T2, T3, T4> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4, T5> : EventCommon
    {
        public Action<T1, T2, T3, T4, T5> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4, T5> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4, object args5)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4, (T5)args5); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4, T5, T6> : EventCommon
    {
        public Action<T1, T2, T3, T4, T5, T6> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4, T5, T6> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4, object args5, object args6)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4, (T5)args5, (T6)args6); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4, T5, T6, T7> : EventCommon
    {
        public Action<T1, T2, T3, T4, T5, T6, T7> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4, T5, T6, T7> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4, (T5)args5, (T6)args6, (T7)args7); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4, T5, T6, T7, T8> : EventCommon
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7, object args8)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4, (T5)args5, (T6)args6, (T7)args7, (T8)args8); }
            catch { exception?.Invoke(); }
        }
    }
    class EventAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> : EventCommon
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Action { get; set; }
        public EventAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, Action exception = null) : base(exception)
        {
            Action += action;
        }
        public override void Publish(object args1, object args2, object args3, object args4, object args5, object args6, object args7, object args8, object args9)
        {
            try { Action?.Invoke((T1)args1, (T2)args2, (T3)args3, (T4)args4, (T5)args5, (T6)args6, (T7)args7, (T8)args8, (T9)args9); }
            catch { exception?.Invoke(); }
        }
    }
    class EventFunc<T> : EventCommon
    {
        public Func<T> Func { get; set; }
        public EventFunc(Func<T> func, Action exception = null) : base(exception) { Func += func; }
        public override object Call() { try { return Func.Invoke(); } catch { exception?.Invoke(); return default; } }
    }
    class EventFunc<T1, T> : EventCommon
    {
        public Func<T1, T> Func { get; set; }
        public EventFunc(Func<T1, T> func, Action exception = null) : base(exception) { Func += func; }
        public override object Call(object args) { try { return Func.Invoke((T1)args); } catch { exception?.Invoke(); return default; } }
    }
    class EventDispatcher
    {
        private static EventDispatcher instance = null;
        public static EventDispatcher Instance 
        {
            get
            {
                if (instance == null) instance = new EventDispatcher();
                return instance;
            }
        }
        private EventDispatcher() 
        {
            events = new Dictionary<Enum, EventCommon>();
        }
        private Dictionary<Enum, EventCommon> events;

        // method của event action
        public void AddListener(Enum ActionName,Action action,Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName,new EventAction(action));
            else ((EventAction)events[ActionName]).Action += action;
        }
        public void AddListener<T1>(Enum ActionName, Action<T1> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1>(action));
            else ((EventAction<T1>)events[ActionName]).Action += action;
        }
        public void AddListener<T1,T2>(Enum ActionName, Action<T1,T2> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1,T2>(action));
            else ((EventAction<T1,T2>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3>(Enum ActionName, Action<T1, T2, T3> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3>(action));
            else ((EventAction<T1, T2, T3>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4>(Enum ActionName, Action<T1, T2, T3, T4> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4>(action));
            else ((EventAction<T1, T2, T3, T4>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4, T5>(Enum ActionName, Action<T1, T2, T3, T4, T5> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4, T5>(action));
            else ((EventAction<T1, T2, T3, T4, T5>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4, T5, T6>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4, T5, T6>(action));
            else ((EventAction<T1, T2, T3, T4, T5, T6>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4, T5, T6, T7>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4, T5, T6, T7>(action));
            else ((EventAction<T1, T2, T3, T4, T5, T6, T7>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7, T8> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4, T5, T6, T7, T8>(action));
            else ((EventAction<T1, T2, T3, T4, T5, T6, T7, T8>)events[ActionName]).Action += action;
        }
        public void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, Action exception = null)
        {
            if (!events.ContainsKey(ActionName)) events.Add(ActionName, new EventAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(action));
            else ((EventAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>)events[ActionName]).Action += action;
        }
        public void RemoveListener(Enum ActionName,Action action) 
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction eventAction = (EventAction)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if(eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1>(Enum ActionName, Action<T1> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1> eventAction = (EventAction<T1>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2>(Enum ActionName, Action<T1, T2> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2> eventAction = (EventAction<T1, T2>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3>(Enum ActionName, Action<T1, T2, T3> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3> eventAction = (EventAction<T1, T2, T3>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3,T4>(Enum ActionName, Action<T1, T2, T3, T4> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4> eventAction = (EventAction<T1, T2, T3, T4>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3, T4, T5>(Enum ActionName, Action<T1, T2, T3, T4, T5> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4, T5> eventAction = (EventAction<T1, T2, T3, T4, T5>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3, T4, T5, T6>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4, T5, T6> eventAction = (EventAction<T1, T2, T3, T4, T5, T6>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4, T5, T6, T7> eventAction = (EventAction<T1, T2, T3, T4, T5, T6, T7>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4, T5, T6, T7, T8> eventAction = (EventAction<T1, T2, T3, T4, T5, T6, T7, T8>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void RemoveListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Enum ActionName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (events.ContainsKey(ActionName))
            {
                EventAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> eventAction = (EventAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>)events[ActionName];
                if (eventAction.Action != null) eventAction.Action -= action;
                if (eventAction.Action == null) events.Remove(ActionName);
            }
        }
        public void TriggerEvent(Enum eventName)
        {
            if(events.ContainsKey(eventName)) events[eventName].Publish();
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1>(Enum eventName, T1 args1)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2>(Enum eventName, T1 args1, T2 args2)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1,args2);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3>(Enum eventName, T1 args1, T2 args2, T3 args3)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4>(Enum eventName, T1 args1, T2 args2, T3 args3,T4 args4)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4, T5>(Enum eventName, T1 args1, T2 args2, T3 args3, T4 args4,T5 args5)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4, args5);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4, T5, T6>(Enum eventName, T1 args1, T2 args2, T3 args3, T4 args4, T5 args5, T6 args6)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4, args5, args6);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4, T5, T6, T7>(Enum eventName, T1 args1, T2 args2, T3 args3, T4 args4, T5 args5, T6 args6, T7 args7)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4, args5, args6,args7);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4, T5, T6, T7, T8>(Enum eventName, T1 args1, T2 args2, T3 args3, T4 args4, T5 args5, T6 args6, T7 args7, T8 args8)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4, args5, args6, args7, args8);
            else throw new Exception("Empty event!");
        }
        public void TriggerEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Enum eventName, T1 args1, T2 args2, T3 args3, T4 args4, T5 args5, T6 args6, T7 args7, T8 args8, T9 args9)
        {
            if (events.ContainsKey(eventName)) events[eventName].Publish(args1, args2, args3, args4, args5, args6, args7, args8,args9);
            else throw new Exception("Empty event!");
        }

        //method của event func
        public void Register<T>(Enum FuncName,Func<T> func,Action exception = null)
        {
            if (!events.ContainsKey(FuncName)) events.Add(FuncName, new EventFunc<T>(func, exception));
            else events[FuncName] = new EventFunc<T>(func, exception);
        }
        public T CallEvent<T>(Enum FuncName)
        {
            if (events.ContainsKey(FuncName)) return (T)events[FuncName].Call();
            else throw new Exception("Empty event!"); 
        }

        public void RemoveEvent(Enum Name)
        {
            if(events.ContainsKey(Name)) events.Remove(Name);
        }
    }
}
