using System;

namespace NRedux {
    public class Store<TState> {
        public Store(Func<Object, Object> dispatch, Func<Action, Action> subscribe, Func<TState> getState, Action<Reducer<TState>> replaceReducer) {
            GetState = getState;
            Subscribe = subscribe;
            Dispatch = dispatch;
            ReplaceReducer = replaceReducer;
        }
        public Func<TState> GetState { get; }
        public Func<Action, Action> Subscribe { get; }
        public Func<Object, Object> Dispatch { get; }
        public Action<Reducer<TState>> ReplaceReducer { get; }
    }
}