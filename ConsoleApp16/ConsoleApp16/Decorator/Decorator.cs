//Для расширения логики класса но при этом не изменять основной класс

using System;

namespace Decorator
{
    public interface IComponent
    {
        void Do();
    }

    public class ConcreteComponent : IComponent
    {
        public void Do()
        {
            Console.WriteLine("Do");
        }
    }

    public abstract class AComponentDecorator : IComponent
    {
        private IComponent _component;

        protected AComponentDecorator(IComponent component)
        {
            _component = component;
        }

        public void Do()
        {
            _component.Do();
        }

        public virtual void Operation()
        {
            Console.WriteLine("Operation");
        }
    }

    public class ConcreteDecoratorA : AComponentDecorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("OperationA");
        }
    }

    public class ConcreteDecoratorB : AComponentDecorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }
    }
}