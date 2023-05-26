//Для создания иерархии классов

using System;
using System.Collections.Generic;

namespace Composite
{
    public interface IComponent
    {
        string Name { get; }
        void Display();
    }

    public interface ICompositeComponent : IComponent
    {
        void Add(IComponent component);
        void Remove(IComponent component);
    }
    public interface ILeafComponent : IComponent { }

    public class CompositeComponent : ICompositeComponent
    {
        public string Name { get; }
        private List<IComponent> _childrens;

        public CompositeComponent(string name)
        {
            _childrens = new List<IComponent>();
            Name = name;
        }

        public void Add(IComponent component)
        {
            _childrens.Add(component);
        }

        public void Display()
        {
            foreach (IComponent item in _childrens)
                item.Display();
        }

        public void Remove(IComponent component)
        {
            _childrens.Remove(component);
        }
    }

    public class Leaf : ILeafComponent
    {
        public string Name { get; }

        public Leaf(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"{Name}");
        }
    }
}