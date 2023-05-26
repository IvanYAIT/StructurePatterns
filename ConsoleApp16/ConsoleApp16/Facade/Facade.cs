//Используется если есть много методов в которые не хочешь влезать которые можно соединить в один

namespace Facade
{
    public class Facade
    {
        private SybSystemA _sybSystemA;
        private SybSystemB _sybSystemB;
        private SybSystemC _sybSystemC;

        public Facade(SybSystemC sybSystemC)
        {
            _sybSystemA = new SybSystemA();
            _sybSystemB = new SybSystemB();
            _sybSystemC = sybSystemC;
        }

        public void OperationAC()
        {
            _sybSystemA.DoA();
            _sybSystemC.DoC();
        }

        public void OperationAB()
        {
            _sybSystemA.DoA();
            _sybSystemB.DoB();
        }
    }

    public class SybSystemA
    {
        public void DoA() { }
    }

    public class SybSystemB
    {
        public void DoB() { }
    }

    public class SybSystemC
    {
        public void DoC() { }
    }
}