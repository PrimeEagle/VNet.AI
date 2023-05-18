//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VNet.AI.Behavior
//{
//    public class SenseAggregator : IEventAggregator
//    {
//        private readonly List<WeakReference<Handler>> _handlers = new List<WeakReference<Handler>>();

//        public void Subscribe(object subscriber)
//        {
//            lock (_handlers)
//            {
//                if (_handlers.Any(x => x == subscriber))
//                {
//                    return;
//                }

//                _handlers.Add(new WeakReference<Handler>(new Handler(subscriber)));
//            }
//        }

//        public void Unsubscribe(object subscriber)
//        {
//            lock (_handlers)
//            {
//                WeakReference<Handler> toRemove = null;
//                lock (_handlers)
//                {

//                    foreach (var handler in _handlers)
//                    {
//                        if (handler.TryGetTarget(out var target))
//                        {
//                            if (target.Subscriber == subscriber)
//                                toRemove = handler;
//                        }
//                    }

//                    if (toRemove != null)
//                    {
//                        _handlers.Remove(toRemove);
//                    }
//                }
//            }
//        }

//        public void PublishMessage(object message)
//        {
//            if (message == null) throw new ArgumentNullException(nameof(message));

//            var handlersToNotify = new List<Handler>();
//            lock (_handlers)
//            {

//                foreach (var handler in _handlers)
//                {
//                    if (handler.TryGetTarget(out var target))
//                    {
//                        handlersToNotify.Add(target);
//                    }
//                }
//            }

//            foreach (var handler in handlersToNotify)
//            {
//                handler.Handle(message.GetType(), message);
//            }
//        }
//    }
//}
